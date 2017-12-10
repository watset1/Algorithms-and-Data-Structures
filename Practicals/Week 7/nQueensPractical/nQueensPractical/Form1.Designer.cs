namespace nQueensPractical
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSolutions = new System.Windows.Forms.Button();
            this.btnTree = new System.Windows.Forms.Button();
            this.spinBoxQueens = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPruned = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxQueens)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(215, 21);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(302, 644);
            this.listBox1.TabIndex = 0;
            // 
            // btnSolutions
            // 
            this.btnSolutions.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolutions.Location = new System.Drawing.Point(12, 107);
            this.btnSolutions.Name = "btnSolutions";
            this.btnSolutions.Size = new System.Drawing.Size(187, 40);
            this.btnSolutions.TabIndex = 1;
            this.btnSolutions.Text = "Print Solutions";
            this.btnSolutions.UseVisualStyleBackColor = true;
            this.btnSolutions.Click += new System.EventHandler(this.btnSolutions_Click);
            // 
            // btnTree
            // 
            this.btnTree.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTree.Location = new System.Drawing.Point(12, 64);
            this.btnTree.Name = "btnTree";
            this.btnTree.Size = new System.Drawing.Size(187, 40);
            this.btnTree.TabIndex = 2;
            this.btnTree.Text = "Print Tree";
            this.btnTree.UseVisualStyleBackColor = true;
            this.btnTree.Click += new System.EventHandler(this.btnTree_Click);
            // 
            // spinBoxQueens
            // 
            this.spinBoxQueens.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinBoxQueens.Location = new System.Drawing.Point(145, 25);
            this.spinBoxQueens.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.spinBoxQueens.Name = "spinBoxQueens";
            this.spinBoxQueens.Size = new System.Drawing.Size(53, 32);
            this.spinBoxQueens.TabIndex = 3;
            this.spinBoxQueens.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.spinBoxQueens.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number of Queens";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPruned
            // 
            this.btnPruned.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPruned.Location = new System.Drawing.Point(12, 153);
            this.btnPruned.Name = "btnPruned";
            this.btnPruned.Size = new System.Drawing.Size(187, 40);
            this.btnPruned.TabIndex = 5;
            this.btnPruned.Text = "Pruned Tree";
            this.btnPruned.UseVisualStyleBackColor = true;
            this.btnPruned.Click += new System.EventHandler(this.btnPruned_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 679);
            this.Controls.Add(this.btnPruned);
            this.Controls.Add(this.spinBoxQueens);
            this.Controls.Add(this.btnTree);
            this.Controls.Add(this.btnSolutions);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.spinBoxQueens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSolutions;
        private System.Windows.Forms.Button btnTree;
        private System.Windows.Forms.NumericUpDown spinBoxQueens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPruned;
    }
}

