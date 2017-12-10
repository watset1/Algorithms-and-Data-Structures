using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FDC
{
    public class FoxDuckCornGraph
    {
        public int NodeCount {get;set;}	                // track the number of nodes in the graph
       
            GraphNode[] nodeArray;          // array to hold the nodes in the graph
            int[,] adjacencyMatrix;			// array to hold the adjacency matrix. Note odd syntax. See constructor for generation code
            Graphics targetCanvas;

	        Point[] locationTable;			// where to draw the nodes for a tidy layout
    
	        bool[] visitedArray;			// utility array for traversal. See code

            int[] minDistToTree;
	        int[] mstNeighbour;

	        bool[] inTree;
	        bool[] inFringe;

            const int MAX_NODES = 16;
            const int DEFAULT_SEPARATION = 25;
            const int DEFAULT_DIAMETER = 50;
            const int SLEEP_TIME = 2000;
            const int WEIGHT_OFFSET = 5;
            const int INFINITY = 99999;
            const int NULLNEIGHBOUR = -1;


        //----------------------------------------------------------------------------------------------------------------------
        // This form of the constructor creates a set of generic nodes. The graph is  built by adding values to the adjMatrix
        // This is useful to have for developing methods and testing
        //-----------------------------------------------------------------------------------------------------------------------
        public FoxDuckCornGraph(int startNodeCount, Graphics startTargetCanvas)
        {
	        // allocate memory for the main arrays
	        nodeArray = new GraphNode[MAX_NODES];				// array to hold the nodes in the graph
            adjacencyMatrix = new int[MAX_NODES, MAX_NODES];	// array to hold the adjacency matrix. Note odd syntax. 

	        // clean out the main arrays
	        for (int i=0; i< MAX_NODES; i++)
		        nodeArray[i] = null;

	        for (int col=0; col<MAX_NODES; col++)
		        for (int row=0; row<MAX_NODES; row++)
			        adjacencyMatrix[col,row] = 0;

	        // store the parameter values in the corresponding class properties
	        NodeCount = startNodeCount;
	        targetCanvas = startTargetCanvas;

	        // need an array to keep track of who has been visited during traversal. Two methods need to see it (cf. code below), so make it a property of the class
	        visitedArray = new bool[MAX_NODES];


	        // set up the locations for the nodes so that they sit nicely on the screen
	        locationTable = new Point[MAX_NODES];

	        locationTable[0] = new Point(100,100);
	        locationTable[1] = new Point(600,100);
	        locationTable[2] = new Point(100,400);
	        locationTable[3] = new Point(600,400);
	        locationTable[4] = new Point(230,200);
	        locationTable[5] = new Point(460,200);
	        locationTable[6] = new Point(230,300);
	        locationTable[7] = new Point(460,300);
	        locationTable[8] = new Point(100,200);
	        locationTable[9] = new Point(600,200);
	        locationTable[10]= new Point(100,300);
	        locationTable[11]= new Point(600,300);
	        locationTable[12]= new Point(230,100);
	        locationTable[13]= new Point(230,400);
	        locationTable[14]= new Point(460,100);
	        locationTable[15]= new Point(460,400);
	
        } // end generic constructor


        public FoxDuckCornGraph(int startNodeCount, GraphNode[] startNodeArray, Graphics startTargetCanvas)
        {
	        // left as an exercise
        }

        public FoxDuckCornGraph(int startNodeCount, GraphNode[] startNodeArray, int[,] startAdjacencyMatrix, Graphics startTargetCanvas)
        {
	        // left as an exercise
        }

        //-----------------------------------------------------------------------------------
        // Make a demo graph for testing
        //-----------------------------------------------------------------------------------
        public void makeGraph()
        {
            string[] binaryArray = new string[16];
            binaryArray[0] = "0000";
            binaryArray[1] = "1000";
            binaryArray[2] = "1001";
            binaryArray[3] = "1100";
            binaryArray[4] = "1010";
            binaryArray[5] = "0001";
            binaryArray[6] = "0100";
            binaryArray[7] = "0010";
            binaryArray[8] = "1011";
            binaryArray[9] = "1101";
            binaryArray[10] = "1110";
            binaryArray[11] = "0011";
            binaryArray[12] = "0101";
            binaryArray[13] = "0110";
            binaryArray[14] = "0111";
            binaryArray[15] = "1111";


            //create the set of generic nodes
            for (int i = 0; i < NodeCount; i++)
            {
                int newLeft = locationTable[i].X;
                int newTop = locationTable[i].Y;

                Color newColor = Color.FromArgb(0, 225, 180);
                String newLabel = binaryArray[i];

                nodeArray[i] = new GraphNode(newLeft, newTop, DEFAULT_DIAMETER, newColor, newLabel, targetCanvas);
            }

            // add the edges
            addEdge(0, 1, 0);
            addEdge(0, 2, 0);
            addEdge(0, 3, 0);
            addEdge(0, 4, 1);
            addEdge(2, 5, 0);
            addEdge(3, 6, 1);
            addEdge(4, 7, 1);
            addEdge(5, 8, 1);
            addEdge(5, 9, 1);
            addEdge(6, 9, 1);
            addEdge(7, 10, 1);
            addEdge(8, 11, 0);
            addEdge(9, 12, 1);
            addEdge(10, 13, 0);
            addEdge(10, 6, 1);
            addEdge(11, 15, 0);
            addEdge(12, 15, 1);
            addEdge(13, 15, 0);
            addEdge(5, 9, 1);
            addEdge(14, 15, 0);
        }

        //-----------------------------------------------------------------------------------
        // addNode adds a prepared node to the nodeArray
        //-----------------------------------------------------------------------------------
        public void addNode(GraphNode newNode)
        {
          ++NodeCount;
          nodeArray[NodeCount] = newNode;
        }

        //-----------------------------------------------------------------------------------
        // addNode version to accept node data and create and add the node
        //-----------------------------------------------------------------------------------
        public void addNode(String newLabel, Color newColor)
        {
	        // OPTIONAL EXERCISE
	        // needs to figure out left and top for the new node, create it and add it
        }

        //-----------------------------------------------------------------------------------
        // addEdge adds a new edge to the graph. This is accomplished by modifying the
        // value(s) in the adjacency matrix that represents the edge between the two nodes
        //-----------------------------------------------------------------------------------
        public void addEdge(int node1, int node2, int weight)
        {
          adjacencyMatrix[node1,node2] = weight;

          // for an undirected graph only, you would need to add the symmetric edge
	        adjacencyMatrix[node2,node1] = weight;
        }



        //----------------------------------------------------------------------------------------------
        // deleteEdge removes an edge from the graph by setting the corresponding adjMatrix entry to 0
        //----------------------------------------------------------------------------------------------
        public void deleteEdge(int node1, int node2)
        {
          adjacencyMatrix[node1,node2] = 0;
        }

        //----------------------------------------------------------------------------------------------
        // clearEdges empties the graph by deleting all the edges
        //----------------------------------------------------------------------------------------------
        public void clearEdges()
        {
          for (int i=0; i<MAX_NODES; i++)
            for (int j=0; j<MAX_NODES; j++)
              deleteEdge(i,j);
        }

        //=============================================================================================
        // Traversal and traversal utility methods
        //=============================================================================================

        //----------------------------------------------------------------------------------------------
        // findUnvisited: Accepts a node index and returns the index of the first unvisited neighbour
        //----------------------------------------------------------------------------------------------
        public int findUnvisited(int startNode)
        {
          int foundNode = -1;

          for (int i = 0; i < NodeCount; i++)
          {
            // if not looking at your self, and there is an edge, and that neighbour hasn't been visited...
            if ((i != startNode) && (adjacencyMatrix[startNode,i] != 0) && (!visitedArray[i]))
            {
              foundNode = i;
              break;
            }
          }
          return foundNode;
        }

        public int findLegalNode(int startNode)
        {
            int legalNode = -1;
            for (int i = 0; i < NodeCount; i++)
            {
                if ((i != startNode) && (adjacencyMatrix[startNode, i] == 1) && (!visitedArray[i]))
                    legalNode = i;
            }
            return legalNode;
        }

        public int[] processBinary(string binaryString)
        {
            int[] states = new int[4];

            for (int i = 0; i < binaryString.Length; i++)
            {
                states[i] = Convert.ToInt32(binaryString[i].ToString());
            }
            return states;
        }

        public void MovePictures(int[] currentState, PictureBox[] pictures)
        {
            for (int i = 0; i < currentState.Length; i++)
            {
                if (pictures[i].Left > 90 && currentState[i] == 0)
                    pictures[i].Left -= 140;
                if(pictures[i].Left < 90 && currentState[i] == 1)
                    pictures[i].Left += 140;
            }
        }
        

        //----------------------------------------------------------------------------------------------
        // Depth-First traversal of the graph. Animated by highlighting the nodes as they are touched
        // Run the traversal with a stack. We can manage the nodes via their indices in nodeArray, so we
        // just push ints onto the stack
        //----------------------------------------------------------------------------------------------
        public void solveGraph(ListBox targetListbox, PictureBox[] pictures)
        {
            int currentNode = 0;
            visitedArray[currentNode] = true;

            while(currentNode >= 0)
            {
                int[] currentState = processBinary(nodeArray[currentNode].NodeLabel);
                MovePictures(currentState, pictures);
                targetListbox.Items.Add(currentNode);
                Thread.Sleep(SLEEP_TIME);
                currentNode = findLegalNode(currentNode);
                if(currentNode > 0)
                    visitedArray[currentNode] = true;
                Application.DoEvents();
            }
        }


        public void traverseGraph(ListBox targetListBox)
        {
                // YOUR CODE HERE
            Stack<int> traversalStack;
            int currentNodeIndex;
            String output = "";
            traversalStack = new Stack<int>();
            traversalStack.Push(0);
            output += 0;
            visitedArray[0] = true;
            nodeArray[0].highlightNode();
            targetListBox.Items.Add(output);
            Thread.Sleep(SLEEP_TIME);
            while(traversalStack.Count() > 0)
            {
                currentNodeIndex = traversalStack.Peek();            
                int foundNodeIndex = findUnvisited(currentNodeIndex);
                if (foundNodeIndex >= 0)
                {
                    traversalStack.Push(foundNodeIndex);
                    visitedArray[foundNodeIndex] = true;
                    nodeArray[foundNodeIndex].highlightNode();
                    output += foundNodeIndex;
                }
                else
                {
                    traversalStack.Pop();
                    if(output.Length > 0)
                        output = output.TrimEnd(output[output.Length - 1]);
                }               
                targetListBox.Items.Add(output);
                Thread.Sleep(SLEEP_TIME);
            }
            //
        }


        //==================================================================================
        // drawGraph displays the graph
        // First the nodeArray is looped over, and every node is asked to draw itself
        // Then the adjacency matrix is looped over. For each non-zero value at the intersection
        // of a column and row, an edge is drawn between the column vertex and the row vertex
        //==================================================================================
        public void drawGraph()
        {

	        // create a pen to draw the edges
	        Pen edgePen = new Pen(Color.Black);
	        edgePen.Width = 3;

	        for (int i=0; i<NodeCount; i++)
		        nodeArray[i].drawNode();

	        for (int node1=0; node1<NodeCount; ++node1)
		        for(int node2=0; node2<NodeCount; ++node2)
		        {
			        int currWeight = adjacencyMatrix[node1,node2];
			        if (currWeight > 0)
			        {
				        // work out end points for the edges. In each case end point is the center of the vertex
				        int radius = DEFAULT_DIAMETER/2;
				        int startX = nodeArray[node1].NodeLeft + radius;
				        int startY = nodeArray[node1].NodeTop + radius;
				        int endX = nodeArray[node2].NodeLeft + radius;
				        int endY = nodeArray[node2].NodeTop + radius;

				        // draw the line

				        targetCanvas.DrawLine(edgePen,startX,startY,endX,endY);

		                // draw the weight

				        // prepare the font object. Could do this in the constructor if you want the node to hold onto it (as with the Brush and Pen)
				        System.Drawing.Font weightFont = new Font("Garamond", 12,FontStyle.Bold);

				        // Need a brush to draw the text
				        System.Drawing.SolidBrush weightBrush = new SolidBrush(Color.Black);
	
				        // compute the location of the edge label (this is rough)
		                int weightX = ((startX + endX)/2) - WEIGHT_OFFSET;
				        int weightY = ((startY + endY)/2) + WEIGHT_OFFSET;

				        // write out the label to the computed locations
				        targetCanvas.DrawString(Convert.ToString(currWeight), weightFont, weightBrush, weightX, weightY);
			        }
		        }
        }
        //----------------------------------------------------------------------------------------------
        // Used by the draw method
        //----------------------------------------------------------------------------------------------
        public void drawEdge(int v1, int v2, Color edgeColour)
        {
				        int radius = DEFAULT_DIAMETER/2;
				        int startX = nodeArray[v1].NodeLeft + radius;
				        int startY = nodeArray[v1].NodeTop + radius;
				        int endX = nodeArray[v2].NodeLeft + radius;
				        int endY = nodeArray[v2].NodeTop + radius;

				        // draw the line
				        Pen edgePen = new Pen(edgeColour);
				        edgePen.Width = 4;
				        targetCanvas.DrawLine(edgePen,startX,startY,endX,endY);
        }

        //=========================================================================================
        //Prim's algorithm for finding a minimum spanning tree
        public void primsMST(ListBox targetListBox)
        {
	        // YOUR CODE HERE

        } // end Prims

    } // end class
}
