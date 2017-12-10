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

namespace SimpleBinaryTrees
{
    public partial class Practical2 : Form
    {
        //Search function string result values
        const String FOUND = "Value found!";
        const String NOT_FOUND = "Value not found...";
        const int NUM_AMOUNT = 32; //Amount of numbers randomly generated for the tree search functions
        const int RAND_NUM_RANGE = 100; //Range for the randomly generated numbers
        const int TOTAL_ITERATIONS = 1000; //Number of iterations for the comparison tests

        Random random;
        AppMenu menu;
        BinarySearchTree bst1;
        BinarySearchTree bst2;
        int[] bst1Nums; 
        int[] bst2Nums;
        int[] randomNums;

        public Practical2(AppMenu menu)
        {
            InitializeComponent();
            this.menu = menu;
            random = new Random();
            bst1 = new BinarySearchTree();
            bst2 = new BinarySearchTree();        
            createArrays();
            createBinaryTree(bst1, bst1Nums);
            createBinaryTree(bst2, bst2Nums);
        }

        //Creates the arrays with the numbers used for the practical exercises
        private void createArrays()
        {
            bst1Nums = new int[] { 84, 67, 59, 43, 56, 25, 18, 14};
            bst2Nums = new int[] { 56, 18, 67, 14, 25, 59, 84, 43};
        }

        //Builds the Binary tree using the created arrays
        private void createBinaryTree(BinarySearchTree bst, int[] nums)
        {       
            foreach (int num in nums)
                bst.AddNode(num);
        }
        
        //Calls the trees search function, changes UI depending on result
        private void searchTree(BinarySearchTree bst, int searchValue)
        {
            bool result = bst.Search(searchValue);
            if (result) 
            {
                lblResult.ForeColor = Color.LimeGreen;
                lblResult.Text = FOUND;              
            }
            else
            {
                lblResult.ForeColor = Color.DarkRed;
                lblResult.Text = NOT_FOUND;
            }
            showPicture(result);
            label4.Text = bst.InspectionCount.ToString();
        }

        //Shows a tick or cross depending on search result
        private void showPicture(bool found)
        {
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            if (found)
                pictureBox1.BackgroundImage = Image.FromFile("tick.png");
            else
                pictureBox1.BackgroundImage = Image.FromFile("ex.png");
        }
        
        //Generates the random numbers, saving them into an array, to be used to create trees for the practical exercises
        private void generateRandomNumbers()
        {
            randomNums = new int[NUM_AMOUNT];
            for (int i = 0; i < NUM_AMOUNT; i++)
            {
                int rGen = random.Next(RAND_NUM_RANGE);
                randomNums[i] = rGen;
            }
        }

        //Returns a random number existing in the randomly generated array of numbers
        private int getTestNumber(int[] nums)
        {
            int rGen = random.Next(NUM_AMOUNT);
            return nums[rGen];
        }

        //Runs a single comparison test, outputing the results to a label
        private int singleComparisonTest()
        {
            BinarySearchTree randomTree = new BinarySearchTree();
            generateRandomNumbers();
            //Builds the tree of random numbers to be tested
            for (int i = 0; i < NUM_AMOUNT; i++)
                randomTree.AddNode(randomNums[i]);
            randomTree.Search(getTestNumber(randomNums));
            return randomTree.InspectionCount;
        }

        //Runs a batch of comparison tests based on a constant value length
        private void BatchComparison()
        {
            int[] comparisonArray = new int[TOTAL_ITERATIONS];
            for (int i = 0; i < TOTAL_ITERATIONS; i++)
                comparisonArray[i] = singleComparisonTest();
            //Writes the results of the tests to a txt file
            WriteArrayToFile(comparisonArray);
            //Outputs the mean, standard distribution and frequency distribution of the batch results
            lblMean.Text = comparisonArray.Average().ToString();
            lblStd.Text = getStandardDeviation(comparisonArray).ToString();
            getFrequencyDistribution(comparisonArray);
        }

        private void WriteArrayToFile(int[] array)
        {
            String fileLength = array.Length.ToString();
            StreamWriter sw = new StreamWriter("Batch Comparisons - " + fileLength + ".txt");
            for (int i = 0; i < array.Length; i++)
                sw.WriteLine(array[i].ToString());
            sw.Close();
        }

        private double getStandardDeviation(int[] array)
        {
            double average = array.Average();
            double sumOfDerivation = 0;
            foreach (int num in array)
                sumOfDerivation += (num) * (num);
            double sumOfDerivationAverage = sumOfDerivation / (array.Length - 1);
            return Math.Sqrt(sumOfDerivationAverage - (average * average));
        }  

        private void getFrequencyDistribution(int[] array)
        {
            listBox3.Items.Clear();
            for (int i = 1; i < (NUM_AMOUNT / 2) + 1; i++)
            {
                int numCount = 0;
                for (int j = 0; j < array.Length; j++)
                    if (array[j] == i)
                        numCount++;
                listBox3.Items.Add(i + " : " + numCount);
            }
        }

        //Calls the search function
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("BST1"))
                searchTree(bst1, (int)numericUpDown1.Value);
            else
                searchTree(bst2, (int)numericUpDown1.Value);
        }

        //Calls the random generation and sort function
        private void btnGenRand_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            BinarySearchTree randomTree = new BinarySearchTree();
            generateRandomNumbers();
            for (int i = 0; i < NUM_AMOUNT; i++)
            {
                randomTree.AddNode(randomNums[i]);
                listBox1.Items.Add(randomNums[i]);
            }
            randomTree.InorderTraversal(randomTree.RootNode, listBox2);
        }

        //Calls the single test function
        private void btnSingleTest_Click(object sender, EventArgs e)
        {
            lblSingleTest.Text = singleComparisonTest().ToString();
        }

        //Calls the batch function
        private void btnBatch_Click(object sender, EventArgs e)
        {
            BatchComparison();
        }

        //Previous search results are cleared when starting a new search
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lblResult.Text = "";
            pictureBox1.BackgroundImage = null;
        }

        //Shows main menu when this form is closed
        private void Practical2_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Show();
        }
    }
}
