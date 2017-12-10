using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDC
{
    public class GraphNode
    {
        // assorted properties to allow the node to draw itself
        public int NodeLeft { get; set; }
        public int NodeTop { get; set; }
        int nodeDiameter;
        Color nodeColor;
        Graphics targetCanvas;
        SolidBrush nodeBrush;
        Pen nodePen;

        // node data value. In this case just a string, but can be anything depending on the application
        public String NodeLabel { get; set; }


        //-----------------------------------------------------------------------------------------------------------------------------
        // GraphoNode constructor stores input parameters and creates the node's Brush and Pen
        //-----------------------------------------------------------------------------------------------------------------------------
        public GraphNode(int startNodeLeft, int startNodeTop, int startNodeDiameter, Color startNodeColor,
            String startNodeLabel, Graphics startTargetCanvas)
        {
            NodeLeft = startNodeLeft;
            NodeTop = startNodeTop;
            nodeDiameter = startNodeDiameter;
            nodeColor = startNodeColor;
            NodeLabel = startNodeLabel;
            targetCanvas = startTargetCanvas;

            nodeBrush = new SolidBrush(nodeColor);
            nodePen = new Pen(Color.Black);
            nodePen.Width = 3;
        }

        //-----------------------------------------------------------------------------------------------------------------------------
        // drawNode() draws the node to targetCanvas
        //-----------------------------------------------------------------------------------------------------------------------------

        public void drawNode()
        {
            // create the RectangleF object to pass to the draw
            RectangleF nodeRect = new RectangleF(NodeLeft, NodeTop, nodeDiameter, nodeDiameter);

            // Draw the fill
            targetCanvas.FillEllipse(nodeBrush, nodeRect);

            // Draw the stroke
            targetCanvas.DrawEllipse(nodePen, nodeRect);

            // compute where to draw the node label.
            // The x location for the label is the horizontal center of the node - an estimate of half the length of the label (subtraction => 'shift left')
            // The y location is the vertical center of the node
            int radius = nodeDiameter / 2;
            int labelAdjustment = NodeLabel.Length * 5;
            int centreX = NodeLeft + radius - labelAdjustment;
            int centreY = NodeTop + radius;

            // prepare the font object. Could do this in the constructor if you want the node to hold onto it (as with the Brush and Pen)
            Font labelFont = new Font("Calibri", 12);

            // Need a brush to draw the text in, in a contrasting colour
            SolidBrush labelBrush = new SolidBrush(Color.Black);

            // write out the label to the computed locations
            targetCanvas.DrawString(NodeLabel, labelFont, labelBrush, centreX, centreY);
        }

        //-----------------------------------------------------------------------------------------------------------------------------
        // change the node color for use in the animation
        //-----------------------------------------------------------------------------------------------------------------------------
        public void highlightNode()
        {
            Color oldColor = nodeBrush.Color;
            nodeBrush.Color = Color.Red;
            drawNode();
            nodeBrush.Color = oldColor;
        }
    }
}
