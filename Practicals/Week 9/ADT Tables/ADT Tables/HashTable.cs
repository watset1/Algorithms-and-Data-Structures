using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADT_Tables
{
    public enum EHashType { singleHash, doubleHash, chaining }

    public class HashTable : Table
    {
        const int STEP_RANGE = 11;

        int tableSize;
        //bool prime; Unsure if needed

        public HashTable(int tableSize)
        {
            this.tableSize = tableSize;
            Nodes = new Node[tableSize];
        }

        //Inserts items depending on type of hashing function
        public void InsertItem(Node node, EHashType hashType)
        {
            if (hashType == EHashType.chaining)
                ChainInsert(node);
            else
                Nodes[GetHashValue(node.Id, hashType)] = node;
        }

        //Searches for and returns a node if found depending on type of hash function 
        public Node FindItem(int key, EHashType hashType)
        {
            Node retrievedNode;
            if (hashType == EHashType.chaining)
                retrievedNode = RetrieveChainedNode(key);
            else
                retrievedNode = Nodes[GetHashValue(key, hashType)];
            return retrievedNode;
        }

        //First hash function (h1)
        public int HashKey(int key)
        {
            int hashValue = key % tableSize;
            if (hashValue >= tableSize)
                hashValue = Wrap(hashValue);
            return hashValue;
        }

        //Second hash function (h2)
        public int SetStepSize(int hashValue, EHashType hashType)
        {
            if (hashType == EHashType.doubleHash)
                return STEP_RANGE - (hashValue % STEP_RANGE);
            else
                return 1;
        }

        //Gets the hash value for a specified key
        public int GetHashValue(int key, EHashType hashType)
        {           
            int hashValue = HashKey(key); //Hashes the initial key value
            Node tableArrayValue = Nodes[hashValue]; //get the node in the array at the hashValue index
            if (tableArrayValue != null)  //If there is a node already in the hashValue index of the table array  
                hashValue = HashCollision(hashValue, key, tableArrayValue, hashType);
            return hashValue; //Returns the double hashed value
        }

        //If collisions occur they are managed by adding a step value to the original hash value. (Step size dependant on hash type)
        public int HashCollision(int hashValue, int key, Node tableArrayValue, EHashType hashType)
        {
            int stepSize = SetStepSize(key, hashType); //Sets the step size if collisions occur
            while (tableArrayValue != null && tableArrayValue.Id != key) //While there is node populating the hashValue index of the table array
            {
                hashValue += stepSize; //add the stepSize to the hashValue
                if (hashValue >= tableSize)
                    hashValue = Wrap(hashValue);
                tableArrayValue = Nodes[hashValue]; //get the node in the array at the hashValue index
            }
            return hashValue;
        }

        //Inserts a node into the array of nodes
        public void ChainInsert(Node node)
        {
            int hashValue = HashKey(node.Id); //Hashes the initial key value
            if (Nodes[hashValue] != null) //If node already exists in hash value index - node is added to node in that position
                AddChainToNode(node, hashValue);
            else
                Nodes[hashValue] = node;
        }

        //Node is walked until a node is found without a node attached
        public void AddChainToNode(Node node, int hashValue)
        {
            Node nodeWalker = Nodes[hashValue];
            while(nodeWalker.Next != null)
            {
                nodeWalker = nodeWalker.Next;
            }
            nodeWalker.Next = node; //Node is added to the empty next node
        }

        //Returns a node using the chain hash collision method
        public Node RetrieveChainedNode(int key)
        {
            Node retrievedNode;
            int hashValue = HashKey(key); //Hashes the initial key value
            if (Nodes[hashValue] != null)
                retrievedNode = WalkChain(hashValue, key);
            else
                retrievedNode = Nodes[hashValue];
            return retrievedNode;
        }

        //Walks the chain of the original hashvalue nodes until either the key is found or there are no nodes left
        public Node WalkChain(int hashValue, int key)
        {
            Node nodeWalker = Nodes[hashValue];
            while (nodeWalker.Next != null && nodeWalker.Id != key)
            {
                nodeWalker = nodeWalker.Next;
            }
            return nodeWalker;
        }

        //Wraps the hashValue around to the start of the array
        public int Wrap(int hashValue)
        {
            return hashValue -= tableSize; 
        }

        public bool TestPrime(int arrayLength) //Not sure if needed
        {
            //Test if arrayLength is a prime
            return true;
        }
    }
}
