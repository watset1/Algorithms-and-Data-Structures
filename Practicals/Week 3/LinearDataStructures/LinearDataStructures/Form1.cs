using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinearDataStructures
{
    public partial class Form1 : Form
    {
        AlgorithmMachine am;
        String message;
        String errorMessage; 

        public Form1()
        {
            InitializeComponent();
            am = new AlgorithmMachine();
            initialButtonCheck();
        }

        private void txtBrackets_TextChanged(object sender, EventArgs e)
        {
            checkInput(txtBrackets.Text, btnBalanceCheck);
        }
       
        private void txtPostfix_TextChanged(object sender, EventArgs e)
        {
            checkInput(txtPostfix.Text, btnPostfix);
        }
       
        private void txtPalindrome_TextChanged(object sender, EventArgs e)
        {
            checkInput(txtPalindrome.Text, btnPalindrome);
        }

        private void btnBalanceCheck_Click(object sender, EventArgs e)
        {
            message = "The entered string has balanced braces!";
            errorMessage = "The entered string has unbalanced braces!";
            setOutput(message, errorMessage, am.IsBalanced(txtBrackets.Text), lblBraceResult);
        }

        private void btnPostfix_Click(object sender, EventArgs e)
        {
            lblPostFixResult.Text = am.PostfixParser(txtPostfix.Text).ToString() ;
        }

        private void btnPalindrome_Click(object sender, EventArgs e)
        {
            message = "The entered string is a palindrome!";
            errorMessage = "The entered string is not a palindrome!";
            setOutput(message, errorMessage,am.IsPalindrome(txtPalindrome.Text), lblPalindromeResult);
        }

        //Depending on the result of the test the appropriate label will be set
        private void setOutput(String message, String errorMessage, bool check, Label label)
        {
            if (check)
            {
                label.ForeColor = Color.Black;
                label.Text = message;
            }
            else
            {
                label.ForeColor = Color.Red;
                label.Text = errorMessage;

            }
        }

        private void checkInput(String userInput, Button button)
        {
            if (!string.IsNullOrWhiteSpace(userInput))
                button.Enabled = true;
            else
                button.Enabled = false;
        }

        private void initialButtonCheck()
        {
            checkInput(txtBrackets.Text, btnBalanceCheck);
            checkInput(txtPostfix.Text, btnPostfix);
            checkInput(txtPalindrome.Text, btnPalindrome);
        }
    }
}
