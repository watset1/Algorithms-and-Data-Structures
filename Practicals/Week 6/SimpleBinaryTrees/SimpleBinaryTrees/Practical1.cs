using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleBinaryTrees
{
    public partial class Practical1 : Form
    {
        AppMenu menu;
        IntBinaryTree t1, t2, t3, t4, t5, t6;
        ExpressionTree et1, et2, et3, st1, st2, st3;

        public Practical1(AppMenu menu)
        {
            InitializeComponent();
            this.menu = menu;
            buildTree();
            traverseTrees();
            buildExpressionTreeOne();
            buildExpressionTreeTwo();
            parseExpression(et3, textBox1);
            parseExpression(st3, textBox2);
            getNotation(et3, textBox3);
            getNotation(st3, textBox4);
        }

        //Building integer binary tree
        private void buildTree()
        {
            t1 = new IntBinaryTree(6);
            t1.MakeLeftChildNode(9);

            t2 = new IntBinaryTree(4);
            t2.AddLeftSubtree(t1);

            t3 = new IntBinaryTree(5);
            t3.MakeLeftChildNode(7);
            t3.MakeRightChildNode(8);

            t4 = new IntBinaryTree(2, t2, t3);

            t5 = new IntBinaryTree(3);

            t6 = new IntBinaryTree(1, t4, t5);
        }

        //Building Expression Tree using the expression (2*6) + 3
        private void buildExpressionTreeOne()
        {
            et1 = new ExpressionTree("*");
            et1.MakeLeftChildNode("2");
            et1.MakeRightChildNode("6");

            et2 = new ExpressionTree("3");

            et3 = new ExpressionTree("+", et1, et2);
        }

        //Building Expression Tree using the expression 2 * (6+3)
        private void buildExpressionTreeTwo()
        {
            st1 = new ExpressionTree("2");
          
            st2 = new ExpressionTree("+");
            st2.MakeLeftChildNode("6");
            st2.MakeRightChildNode("3");

            st3 = new ExpressionTree("*", st1, st2);
        }

        //Parse to solve expression
        private void parseExpression(ExpressionTree et, TextBox textBox)
        {
            textBox.Text = (et.ParseExpressionTree(et.RootNode)).ToString();
        }

        //Parse to write out postfix notation
        private void getNotation(ExpressionTree et, TextBox textBox)
        {
            et.GeneratePostfixNotation(et.RootNode, textBox);
            //et3.GeneratePostfixNotation(et3.RootNode, textBox3);
            //st3.GeneratePostfixNotation(st3.RootNode, textBox4);
        }

        //Traverse trees to write out three different types of traversal
        private void traverseTrees()
        { 
            IntBinaryTreeNode startNode = t6.RootNode;
            t6.PreorderTraversal(startNode, listBox1);
            t6.InorderTraversal(startNode, listBox2);
            t6.PostorderTraversal(startNode, listBox3);
        }

        //Unhides the main menu when this form is closed
        private void Practical1_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Show();
        }
    }
}
