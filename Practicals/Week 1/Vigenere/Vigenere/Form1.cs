using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vigenere
{
    public partial class Form1 : Form
    {
        VigenereController vigenere;
        List<String> inputList;

        public Form1()
        {
            InitializeComponent();
            vigenere = new VigenereController();
            inputList = new List<string>();
        }

        //Method to add a text file, line by line, into a list
        private void readFile(String filename)
        {            
            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                    inputList.Add(line);
            }
        }

        //Encrypts the string entered into the textbox
        private void encryptString()
        {
            richTxtOutput.Clear();
            richTxtOutput.Text = vigenere.EncryptWholeString(txtEncrypt.Text, txtKey.Text);
        }

        //Decrypts the string entered into the textbox
        private void decryptString()
        {
            richTxtOutput.Clear();
            richTxtOutput.Text = vigenere.DecryptWholeString(txtEncrypt.Text, txtKey.Text);
        }

        //Decrypts the Strings in the list using each key
        private void decryptFile()
        {
            richTxtOutput.Text = "Decrypted File\n";
            int arrayLength = Convert.ToInt32(inputList[0]);
            String[] keyArray = new String[arrayLength];
            String[] encryptionArray = new String[arrayLength];
            for (int index = 0; index < arrayLength; index++)
            { 
                keyArray[index] = inputList[index + 1];
                encryptionArray[index] = inputList[index + arrayLength + 1];
            }
            for (int key = 0; key < arrayLength; key++)
            {
                richTxtOutput.AppendText(Environment.NewLine + keyArray[key]);
                for (int quote = 0; quote < arrayLength; quote++)                   
                    richTxtOutput.AppendText(Environment.NewLine + vigenere.DecryptWholeString(encryptionArray[quote], keyArray[key]));
                richTxtOutput.AppendText(Environment.NewLine);
            }			          
        }

        //Checks if either text box is empty and enables/disables the encrypt button appropriately
        private void textCheck()
        {
            if (txtEncrypt.Text.Equals("") || (txtKey.Text.Equals("")))
                button2.Enabled = button3.Enabled = false;
            else
                button2.Enabled = button3.Enabled = true;
        }

        //Button to decrypt the text file entered below
        private void button1_Click(object sender, EventArgs e)
        {
            inputList.Clear();
            readFile("ViginereTestInput.txt");
            richTxtOutput.Clear();
            decryptFile();
        }

        //Button that encrypts the text entered into the encrypt text box using the key entered
        private void button2_Click(object sender, EventArgs e)
        {
            encryptString();
        }

        //Button that decrypts the text entered into the encrypt text box using the key entered
        private void button3_Click(object sender, EventArgs e)
        {
            decryptString();
        }

        //If the textboxes contents change they will both be checked to see if they contain text
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textCheck();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textCheck();
        }
    }
}
