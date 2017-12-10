namespace Quicksort
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
            this.nupSetSize = new System.Windows.Forms.NumericUpDown();
            this.lblItemAmount = new System.Windows.Forms.Label();
            this.lstUnsorted = new System.Windows.Forms.ListBox();
            this.btnQuickSort = new System.Windows.Forms.Button();
            this.rchSorted = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupSetSize)).BeginInit();
            this.SuspendLayout();
            // 
            // nupSetSize
            // 
            this.nupSetSize.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupSetSize.Location = new System.Drawing.Point(147, 12);
            this.nupSetSize.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.nupSetSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupSetSize.Name = "nupSetSize";
            this.nupSetSize.Size = new System.Drawing.Size(120, 32);
            this.nupSetSize.TabIndex = 0;
            this.nupSetSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nupSetSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblItemAmount
            // 
            this.lblItemAmount.AutoSize = true;
            this.lblItemAmount.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemAmount.Location = new System.Drawing.Point(5, 16);
            this.lblItemAmount.Name = "lblItemAmount";
            this.lblItemAmount.Size = new System.Drawing.Size(140, 20);
            this.lblItemAmount.TabIndex = 1;
            this.lblItemAmount.Text = "Number of Items";
            // 
            // lstUnsorted
            // 
            this.lstUnsorted.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUnsorted.FormattingEnabled = true;
            this.lstUnsorted.ItemHeight = 18;
            this.lstUnsorted.Location = new System.Drawing.Point(9, 53);
            this.lstUnsorted.Name = "lstUnsorted";
            this.lstUnsorted.Size = new System.Drawing.Size(258, 166);
            this.lstUnsorted.TabIndex = 2;
            // 
            // btnQuickSort
            // 
            this.btnQuickSort.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuickSort.Location = new System.Drawing.Point(9, 415);
            this.btnQuickSort.Name = "btnQuickSort";
            this.btnQuickSort.Size = new System.Drawing.Size(258, 36);
            this.btnQuickSort.TabIndex = 3;
            this.btnQuickSort.Text = "QUICKSORT";
            this.btnQuickSort.UseVisualStyleBackColor = true;
            this.btnQuickSort.Click += new System.EventHandler(this.btnQuickSort_Click);
            // 
            // rchSorted
            // 
            this.rchSorted.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchSorted.Location = new System.Drawing.Point(9, 237);
            this.rchSorted.Name = "rchSorted";
            this.rchSorted.Size = new System.Drawing.Size(258, 165);
            this.rchSorted.TabIndex = 4;
            this.rchSorted.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 463);
            this.Controls.Add(this.rchSorted);
            this.Controls.Add(this.btnQuickSort);
            this.Controls.Add(this.lstUnsorted);
            this.Controls.Add(this.lblItemAmount);
            this.Controls.Add(this.nupSetSize);
            this.Name = "Form1";
            this.Text = "QuickSort";
            ((System.ComponentModel.ISupportInitialize)(this.nupSetSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nupSetSize;
        private System.Windows.Forms.Label lblItemAmount;
        private System.Windows.Forms.ListBox lstUnsorted;
        private System.Windows.Forms.Button btnQuickSort;
        private System.Windows.Forms.RichTextBox rchSorted;
    }
}

