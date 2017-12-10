namespace SortingAlgorithms
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
            this.btnBubble = new System.Windows.Forms.Button();
            this.btnSelection = new System.Windows.Forms.Button();
            this.btnInsertion = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.numberInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lblType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberInput)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(212, 62);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(183, 308);
            this.listBox1.TabIndex = 0;
            // 
            // btnBubble
            // 
            this.btnBubble.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBubble.Location = new System.Drawing.Point(13, 24);
            this.btnBubble.Name = "btnBubble";
            this.btnBubble.Size = new System.Drawing.Size(182, 42);
            this.btnBubble.TabIndex = 1;
            this.btnBubble.Text = "Bubble Sort";
            this.btnBubble.UseVisualStyleBackColor = true;
            this.btnBubble.Click += new System.EventHandler(this.btnBubble_Click);
            // 
            // btnSelection
            // 
            this.btnSelection.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelection.Location = new System.Drawing.Point(13, 72);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(182, 42);
            this.btnSelection.TabIndex = 2;
            this.btnSelection.Text = "Selection Sort";
            this.btnSelection.UseVisualStyleBackColor = true;
            this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
            // 
            // btnInsertion
            // 
            this.btnInsertion.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertion.Location = new System.Drawing.Point(13, 120);
            this.btnInsertion.Name = "btnInsertion";
            this.btnInsertion.Size = new System.Drawing.Size(182, 42);
            this.btnInsertion.TabIndex = 3;
            this.btnInsertion.Text = "Insertion Sort";
            this.btnInsertion.UseVisualStyleBackColor = true;
            this.btnInsertion.Click += new System.EventHandler(this.btnInsertion_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMerge.Location = new System.Drawing.Point(12, 168);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(183, 42);
            this.btnMerge.TabIndex = 4;
            this.btnMerge.Text = "Merge Sort";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // numberInput
            // 
            this.numberInput.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberInput.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numberInput.Location = new System.Drawing.Point(12, 242);
            this.numberInput.Maximum = new decimal(new int[] {
            8192,
            0,
            0,
            0});
            this.numberInput.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(183, 32);
            this.numberInput.TabIndex = 5;
            this.numberInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numberInput.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number of elements";
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(24, 288);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(156, 28);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "Must be a power of 2";
            this.lblError.Visible = false;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 19;
            this.listBox2.Location = new System.Drawing.Point(414, 62);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(183, 308);
            this.listBox2.TabIndex = 8;
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(212, 24);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(385, 35);
            this.lblType.TabIndex = 9;
            this.lblType.Text = "Sorting Type";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 384);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberInput);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnInsertion);
            this.Controls.Add(this.btnSelection);
            this.Controls.Add(this.btnBubble);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numberInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnBubble;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.Button btnInsertion;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.NumericUpDown numberInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lblType;
    }
}

