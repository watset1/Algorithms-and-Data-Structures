using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuffmanCoding
{
    public partial class Form1 : Form
    {
        Graphics canvas;
        HuffmanTree huffmanTree;

        public Form1()
        {
            InitializeComponent();
            canvas = panel2.CreateGraphics();                    
        }

        private Dictionary<String, int> createUserInputDictionary()
        {
            Dictionary<String, int> data = new Dictionary<string, int>();
             //Runs through each textBox pairing checking for values in both pairs          
            addCheck(data, txtSymbol1.Text, txtFreq1.Text);
            addCheck(data, txtSymbol2.Text, txtFreq2.Text);
            addCheck(data, txtSymbol3.Text, txtFreq3.Text);
            addCheck(data, txtSymbol4.Text, txtFreq4.Text);
            addCheck(data, txtSymbol5.Text, txtFreq5.Text);
            addCheck(data, txtSymbol6.Text, txtFreq6.Text);
            addCheck(data, txtSymbol7.Text, txtFreq7.Text);
            addCheck(data, txtSymbol8.Text, txtFreq8.Text);

            return data;          
        }

        //Creates a dictionary for a file chosen by the user
        private Dictionary<String, int> createFileDictionary()
        {
            List<char> symbols = new List<char>();
            Dictionary<String, int> data = new Dictionary<string, int>();
            OpenFileDialog fileBrowserDialog = new OpenFileDialog();
            fileBrowserDialog.Filter = "Text Files (.txt)|*.txt";

            DialogResult result = fileBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Char ch;
                String fileName = fileBrowserDialog.FileName;
                txtFile.Text = fileName;
                StreamReader sr = new StreamReader(fileName);
                do
                {
                    ch = (char)sr.Read();
                    symbols.Add(ch);
                } while (!sr.EndOfStream);
                sr.Close();

                foreach (char symbol in symbols)
                {
                    int frequency = 0;
                    foreach (char comparable in symbols)
                        if (symbol.Equals(comparable))
                            frequency++;
                    addCheck(data, symbol.ToString(), frequency.ToString());
                }
            }
            return data;
        }

        private void addCheck(Dictionary<String, int> data, String symbol, String frequency)
        {
            //Wont store values unless both values are entered
            if (symbol != "" && frequency != "")
                try
                {
                    data.Add(symbol, Convert.ToInt32(frequency));
                }
                catch (ArgumentException) { }              
        }

        //Displays the frequency symbols appear in the input data
        private void showSymbolFrequencies(Dictionary<String, int> inputData)
        {
            listBox2.Items.Clear();
            foreach (var pair in inputData)
            {
                String symbol = pair.Key;
                int frequency = pair.Value;
                listBox2.Items.Add(symbol + " : " + frequency);
            }
        }

        //Displays the codes for each symbol
        private void showSymbolCodes()
        {
            listBox1.Items.Clear();
            foreach (var pair in huffmanTree.EncodedValues)
            {
                String symbol = pair.Key;
                String code = pair.Value;
                listBox1.Items.Add(symbol + " : " + code);
            }
        }

        private void btnTreeBuilder_Click(object sender, EventArgs e)
        {
            //Clear previous displays
            btnComparison.Enabled = false;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            txtFixed.Text = "";
            txtHuffman.Text = "";
            txtDecoded.Text = "";
            btnCodes.Enabled = true;
            btnDecode.Enabled = true;
            //Create Data Dictionary
            Dictionary<String, int> userData = createUserInputDictionary();

            //If dictionary has data
            if (userData.Count() > 0)
            {
                //Create the tree
                huffmanTree = new HuffmanTree(userData);

                //Draw tree
                canvas.Clear(Color.White);
                Size nodeSize = new Size(100, 30); //size of each node in tree
                Point treePosition = new Point((panel2.Width / 2) - (nodeSize.Width / 2), 20); //Position of tree on canvas
                huffmanTree.DrawTree(canvas, treePosition, nodeSize);
            }
        }

        //Encodes and displays encoded binary values
        private void btnCodes_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            btnComparison.Enabled = true;
            if (huffmanTree != null)
            {
                huffmanTree.Encode();
                showSymbolCodes();
            }
        }

        //Decodes and displays decoded string
        private void btnDecode_Click(object sender, EventArgs e)
        {
            if (huffmanTree != null)
            {
                huffmanTree.Decode(txtCode.Text);
                txtDecoded.Text = huffmanTree.DecodedString;
            }
        }

        //Displays bit comparisons
        private void btnComparison_Click(object sender, EventArgs e)
        {
            if (huffmanTree != null && huffmanTree.EncodedValues != null)
            {
                txtFixed.Text = "Fixed Length Code Bits: " + huffmanTree.TotalFixedBits;
                txtHuffman.Text = "Huffman Code Bits: " + huffmanTree.TotalHuffmanBits;
            }
        }

        //Encodes a text file
        private void btnEncodeFile_Click(object sender, EventArgs e)
        {
            //Clear all current display stats
            canvas.Clear(Color.White);
            btnComparison.Enabled = false;
            btnDecode.Enabled = true;
            listBox1.Items.Clear();
            txtFixed.Text = "";
            txtHuffman.Text = "";
            txtDecoded.Text = "";
            //Create Data Dictionary
            Dictionary<String, int> userData = createFileDictionary();

            //If dictionary has data
            if (userData.Count() > 0)
            {
                //Create the tree
                huffmanTree = new HuffmanTree(userData);

                //Display the frequencies
                showSymbolFrequencies(userData);

                //Encode the symbols
                listBox1.Items.Clear();
                btnComparison.Enabled = true;
                huffmanTree.Encode();
                
                //Display the symbols
                showSymbolCodes();

                //Display bit comparison
                txtFixed.Text = "Fixed Length Code Bits : " + huffmanTree.TotalFixedBits;
                txtHuffman.Text = "Huffman Code Bits : " + huffmanTree.TotalHuffmanBits;
            }            
        }
    }
}
