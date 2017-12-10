using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuffmanCoding
{
    public class HuffmanTree : BinaryTree
    {
        BinaryTree[] treeSet;
        Dictionary<String, int> inputData;
        public Dictionary<String, String> EncodedValues { get; set; }
        public String DecodedString { get; set; }
        public double TotalHuffmanBits { get; set; }
        public double TotalFixedBits { get; set; } 

        public HuffmanTree(Dictionary<String, int> inputData)
        {
            this.inputData = inputData;
            CreateTree();
        }

        //Creating tree and setting rootNode as completed tree in set
        public void CreateTree()
        {
            GenerateTrees();
            MergeTrees();
            RootNode = treeSet[0].RootNode;
        }

        //Generate the one-node binary trees for each symbol in the input data
        public void GenerateTrees()
        {
            treeSet = new BinaryTree[inputData.Count];

            int index = 0;
            foreach (var pair in inputData)
            {
                String symbol = pair.Key;
                int frequency = pair.Value;
                treeSet[index] = new BinaryTree(symbol, frequency);
                index++;
            }
        }
        //Merge the tree array into one large Tree
        public void MergeTrees()
        {
            //if more than one tree in treeSet(if tree contains only one non null value)
            if (treeSet.Count(tree => tree != null) > 1)
            {
                //Sort the tree frequencies from lowest to highest
                SortTrees();
                //Combine the lowest trees
                String combinedSymbol = treeSet[0].RootNode.Symbol + treeSet[1].RootNode.Symbol;
                int combinedFrequency = treeSet[0].RootNode.Frequency + treeSet[1].RootNode.Frequency;
                treeSet[0] = CombineTrees(treeSet[0], treeSet[1]);
                //Null second tree position used to combine
                treeSet[1] = null;
                //Move all other trees down one - after moving position becomes null
                ShiftArrayTreesDown();
                //Recursive call
                MergeTrees();                             
            }
        }

        //Combine two trees
        public BinaryTree CombineTrees(BinaryTree leftChild, BinaryTree rightChild)
        {
            //Combine the two lowest tree frequency values (and concatonate symbols)
            String combinedSymbol = leftChild.RootNode.Symbol + rightChild.RootNode.Symbol;
            int combinedFrequency = leftChild.RootNode.Frequency + rightChild.RootNode.Frequency;
            //Two rootNodes become the two children of new tree root
            BinaryTree newTree = new BinaryTree(combinedSymbol, combinedFrequency, treeSet[0], treeSet[1]);
            return newTree;
        }

        //Moving values down the array of binary trees
        public void ShiftArrayTreesDown()
        {           
            int setValueCount = treeSet.Count(tree => tree != null); //Get number of trees in array that are not null              
            for (int index = 1; index < setValueCount; index++)
                treeSet[index] = treeSet[index + 1];
            //Null the last tree still left over from move
            int indexToNull = setValueCount;
            treeSet[indexToNull] = null;
        }

        public void SortTrees() //Insertion
        {
            BinaryTree heldTree; //Holds the array value being compared
            int currentNum; //The current index 
            for (int i = 1; i < treeSet.Count(tree => tree != null); i++)
            {
                heldTree = treeSet[i]; //Stores the value where the first number may be shifted to
                currentNum = i - 1; //
                while (currentNum >= 0 && treeSet[currentNum].RootNode.Frequency > heldTree.RootNode.Frequency) //Goes down each array index shifting larger values up until values are no longer larger or 0 index position has been reached
                {
                    //If the next value is less than the current value being compared the current value will be shifted up one space
                    //if(treeSet[currentNum] != null)                   
                    treeSet[currentNum + 1] = treeSet[currentNum];
                    currentNum--;
                }
                treeSet[currentNum + 1] = heldTree; //Replaces value where the decending while loop ended with the held value 
            }
        }        

        //Traversing the tree to generate a binary code for each leaf symbol in the tree
        public void Encode()
        {
            if (RootNode != null)
            {
                String codeString = "";
                EncodedValues = new Dictionary<string, string>();
                GenerateCodes(RootNode, EncodedValues, codeString);
                TotalFixedBits = 0;
                TotalHuffmanBits = 0;
                TotalFixedBits = calculateTotalFixedBits();
                TotalHuffmanBits = calculateTotalHuffmanBits();
            }
        }

        //Iterating through tree nodes to produce a decoded string from the encoded user inputed code
        public void Decode(String userCode)
        {
            DecodedString = "";
            HuffmanNode currentNode = RootNode;
            if (RootNode != null)
            {
                foreach (char code in userCode)
                {
                    if (code.Equals('1'))
                        currentNode = currentNode.leftChild;
                    else
                        currentNode = currentNode.rightChild;
                    if (currentNode.leftChild == null && currentNode.rightChild == null)
                    {
                        DecodedString += currentNode.Symbol;
                        currentNode = RootNode;
                    }
                }
            }
        }

        //Traverses tree to generate each symbols binary code
        public void GenerateCodes(HuffmanNode inputRootNode, Dictionary<String, String> encodedData, String codeString)
        {
            if (inputRootNode != null)
            {
                //Adds "1" to string if traverses to left child
                HuffmanNode leftRoot = inputRootNode.leftChild;
                String left = "1";
                GenerateCodes(leftRoot, encodedData, codeString + left);

                //Adds "0" to string if traverses to right child
                HuffmanNode rightRoot = inputRootNode.rightChild;
                String right = "0";
                GenerateCodes(rightRoot, encodedData, codeString + right);

                //If currentNode is a leaf, the current string is added to the dictionary
                if (inputRootNode.leftChild == null && inputRootNode.rightChild == null)
                {
                    String currentNodeSymbol = inputRootNode.Symbol;
                    encodedData.Add(currentNodeSymbol, codeString);
                }
                //String is nulled
                codeString = "";
            }
        }  

        //Calculating the amount of bits that would have been used without huffman coding
        public double calculateTotalFixedBits()
        {
            double symbolTotalfixedBits = 0;
            double fixedCodeBits = (int)Math.Log(inputData.Count(), 2) + 1; //Added one to make up the first binary bit
            foreach (var pair in inputData)
                symbolTotalfixedBits += pair.Value * fixedCodeBits; 

            return symbolTotalfixedBits;
        }

        //Calculating the amount of bits that were used without huffman coding
        public double calculateTotalHuffmanBits()
        {
            double symbolTotalHuffmanBits = 0;
            foreach (var codePair in EncodedValues)
                foreach (var inputPair in inputData)
                    if (codePair.Key.Equals(inputPair.Key))
                        symbolTotalHuffmanBits += codePair.Value.Length * inputPair.Value;

            return symbolTotalHuffmanBits;
        }        
    }
}
