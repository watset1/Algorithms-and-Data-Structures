namespace HuffmanCoding
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
            this.btnTreeBuilder = new System.Windows.Forms.Button();
            this.txtSymbol1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.btnEncodeFile = new System.Windows.Forms.Button();
            this.txtHuffman = new System.Windows.Forms.TextBox();
            this.txtFixed = new System.Windows.Forms.TextBox();
            this.btnComparison = new System.Windows.Forms.Button();
            this.txtFreq8 = new System.Windows.Forms.TextBox();
            this.txtFreq7 = new System.Windows.Forms.TextBox();
            this.txtFreq6 = new System.Windows.Forms.TextBox();
            this.txtFreq5 = new System.Windows.Forms.TextBox();
            this.txtFreq4 = new System.Windows.Forms.TextBox();
            this.txtFreq3 = new System.Windows.Forms.TextBox();
            this.txtFreq2 = new System.Windows.Forms.TextBox();
            this.txtFreq1 = new System.Windows.Forms.TextBox();
            this.txtSymbol8 = new System.Windows.Forms.TextBox();
            this.txtSymbol7 = new System.Windows.Forms.TextBox();
            this.txtSymbol6 = new System.Windows.Forms.TextBox();
            this.txtSymbol5 = new System.Windows.Forms.TextBox();
            this.txtSymbol4 = new System.Windows.Forms.TextBox();
            this.txtSymbol3 = new System.Windows.Forms.TextBox();
            this.txtSymbol2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.txtDecoded = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.btnCodes = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTreeBuilder
            // 
            this.btnTreeBuilder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTreeBuilder.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTreeBuilder.Location = new System.Drawing.Point(9, 15);
            this.btnTreeBuilder.Name = "btnTreeBuilder";
            this.btnTreeBuilder.Size = new System.Drawing.Size(190, 35);
            this.btnTreeBuilder.TabIndex = 0;
            this.btnTreeBuilder.Text = "Build Tree";
            this.btnTreeBuilder.UseVisualStyleBackColor = true;
            this.btnTreeBuilder.Click += new System.EventHandler(this.btnTreeBuilder_Click);
            // 
            // txtSymbol1
            // 
            this.txtSymbol1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSymbol1.Location = new System.Drawing.Point(9, 56);
            this.txtSymbol1.Name = "txtSymbol1";
            this.txtSymbol1.Size = new System.Drawing.Size(91, 26);
            this.txtSymbol1.TabIndex = 1;
            this.txtSymbol1.Text = "a";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtFile);
            this.panel1.Controls.Add(this.btnEncodeFile);
            this.panel1.Controls.Add(this.txtHuffman);
            this.panel1.Controls.Add(this.txtFixed);
            this.panel1.Controls.Add(this.btnComparison);
            this.panel1.Controls.Add(this.txtFreq8);
            this.panel1.Controls.Add(this.txtFreq7);
            this.panel1.Controls.Add(this.txtFreq6);
            this.panel1.Controls.Add(this.txtFreq5);
            this.panel1.Controls.Add(this.txtFreq4);
            this.panel1.Controls.Add(this.txtFreq3);
            this.panel1.Controls.Add(this.txtFreq2);
            this.panel1.Controls.Add(this.txtFreq1);
            this.panel1.Controls.Add(this.txtSymbol8);
            this.panel1.Controls.Add(this.txtSymbol7);
            this.panel1.Controls.Add(this.txtSymbol6);
            this.panel1.Controls.Add(this.txtSymbol5);
            this.panel1.Controls.Add(this.txtSymbol4);
            this.panel1.Controls.Add(this.txtSymbol3);
            this.panel1.Controls.Add(this.txtSymbol2);
            this.panel1.Controls.Add(this.btnTreeBuilder);
            this.panel1.Controls.Add(this.txtSymbol1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 517);
            this.panel1.TabIndex = 2;
            // 
            // txtFile
            // 
            this.txtFile.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFile.Location = new System.Drawing.Point(10, 478);
            this.txtFile.Name = "txtFile";
            this.txtFile.ReadOnly = true;
            this.txtFile.Size = new System.Drawing.Size(189, 22);
            this.txtFile.TabIndex = 24;
            // 
            // btnEncodeFile
            // 
            this.btnEncodeFile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEncodeFile.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncodeFile.Location = new System.Drawing.Point(9, 437);
            this.btnEncodeFile.Name = "btnEncodeFile";
            this.btnEncodeFile.Size = new System.Drawing.Size(190, 35);
            this.btnEncodeFile.TabIndex = 23;
            this.btnEncodeFile.Text = "Encode Text File";
            this.btnEncodeFile.UseVisualStyleBackColor = true;
            this.btnEncodeFile.Click += new System.EventHandler(this.btnEncodeFile_Click);
            // 
            // txtHuffman
            // 
            this.txtHuffman.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHuffman.Location = new System.Drawing.Point(10, 409);
            this.txtHuffman.Name = "txtHuffman";
            this.txtHuffman.ReadOnly = true;
            this.txtHuffman.Size = new System.Drawing.Size(189, 22);
            this.txtHuffman.TabIndex = 22;
            // 
            // txtFixed
            // 
            this.txtFixed.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFixed.Location = new System.Drawing.Point(10, 376);
            this.txtFixed.Name = "txtFixed";
            this.txtFixed.ReadOnly = true;
            this.txtFixed.Size = new System.Drawing.Size(189, 22);
            this.txtFixed.TabIndex = 21;
            // 
            // btnComparison
            // 
            this.btnComparison.Enabled = false;
            this.btnComparison.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnComparison.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComparison.Location = new System.Drawing.Point(9, 335);
            this.btnComparison.Name = "btnComparison";
            this.btnComparison.Size = new System.Drawing.Size(190, 35);
            this.btnComparison.TabIndex = 21;
            this.btnComparison.Text = "Compare";
            this.btnComparison.UseVisualStyleBackColor = true;
            this.btnComparison.Click += new System.EventHandler(this.btnComparison_Click);
            // 
            // txtFreq8
            // 
            this.txtFreq8.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFreq8.Location = new System.Drawing.Point(108, 280);
            this.txtFreq8.Name = "txtFreq8";
            this.txtFreq8.Size = new System.Drawing.Size(91, 26);
            this.txtFreq8.TabIndex = 16;
            // 
            // txtFreq7
            // 
            this.txtFreq7.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFreq7.Location = new System.Drawing.Point(108, 248);
            this.txtFreq7.Name = "txtFreq7";
            this.txtFreq7.Size = new System.Drawing.Size(91, 26);
            this.txtFreq7.TabIndex = 15;
            // 
            // txtFreq6
            // 
            this.txtFreq6.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFreq6.Location = new System.Drawing.Point(108, 216);
            this.txtFreq6.Name = "txtFreq6";
            this.txtFreq6.Size = new System.Drawing.Size(91, 26);
            this.txtFreq6.TabIndex = 14;
            // 
            // txtFreq5
            // 
            this.txtFreq5.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFreq5.Location = new System.Drawing.Point(108, 184);
            this.txtFreq5.Name = "txtFreq5";
            this.txtFreq5.Size = new System.Drawing.Size(91, 26);
            this.txtFreq5.TabIndex = 13;
            // 
            // txtFreq4
            // 
            this.txtFreq4.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFreq4.Location = new System.Drawing.Point(108, 152);
            this.txtFreq4.Name = "txtFreq4";
            this.txtFreq4.Size = new System.Drawing.Size(91, 26);
            this.txtFreq4.TabIndex = 12;
            this.txtFreq4.Text = "41";
            // 
            // txtFreq3
            // 
            this.txtFreq3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFreq3.Location = new System.Drawing.Point(108, 120);
            this.txtFreq3.Name = "txtFreq3";
            this.txtFreq3.Size = new System.Drawing.Size(91, 26);
            this.txtFreq3.TabIndex = 11;
            this.txtFreq3.Text = "8";
            // 
            // txtFreq2
            // 
            this.txtFreq2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFreq2.Location = new System.Drawing.Point(108, 88);
            this.txtFreq2.Name = "txtFreq2";
            this.txtFreq2.Size = new System.Drawing.Size(91, 26);
            this.txtFreq2.TabIndex = 10;
            this.txtFreq2.Text = "10";
            // 
            // txtFreq1
            // 
            this.txtFreq1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFreq1.Location = new System.Drawing.Point(108, 56);
            this.txtFreq1.Name = "txtFreq1";
            this.txtFreq1.Size = new System.Drawing.Size(91, 26);
            this.txtFreq1.TabIndex = 9;
            this.txtFreq1.Text = "25";
            // 
            // txtSymbol8
            // 
            this.txtSymbol8.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSymbol8.Location = new System.Drawing.Point(9, 280);
            this.txtSymbol8.Name = "txtSymbol8";
            this.txtSymbol8.Size = new System.Drawing.Size(91, 26);
            this.txtSymbol8.TabIndex = 8;
            // 
            // txtSymbol7
            // 
            this.txtSymbol7.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSymbol7.Location = new System.Drawing.Point(9, 248);
            this.txtSymbol7.Name = "txtSymbol7";
            this.txtSymbol7.Size = new System.Drawing.Size(91, 26);
            this.txtSymbol7.TabIndex = 7;
            // 
            // txtSymbol6
            // 
            this.txtSymbol6.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSymbol6.Location = new System.Drawing.Point(9, 216);
            this.txtSymbol6.Name = "txtSymbol6";
            this.txtSymbol6.Size = new System.Drawing.Size(91, 26);
            this.txtSymbol6.TabIndex = 6;
            // 
            // txtSymbol5
            // 
            this.txtSymbol5.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSymbol5.Location = new System.Drawing.Point(9, 184);
            this.txtSymbol5.Name = "txtSymbol5";
            this.txtSymbol5.Size = new System.Drawing.Size(91, 26);
            this.txtSymbol5.TabIndex = 5;
            // 
            // txtSymbol4
            // 
            this.txtSymbol4.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSymbol4.Location = new System.Drawing.Point(9, 152);
            this.txtSymbol4.Name = "txtSymbol4";
            this.txtSymbol4.Size = new System.Drawing.Size(91, 26);
            this.txtSymbol4.TabIndex = 4;
            this.txtSymbol4.Text = "d";
            // 
            // txtSymbol3
            // 
            this.txtSymbol3.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSymbol3.Location = new System.Drawing.Point(9, 120);
            this.txtSymbol3.Name = "txtSymbol3";
            this.txtSymbol3.Size = new System.Drawing.Size(91, 26);
            this.txtSymbol3.TabIndex = 3;
            this.txtSymbol3.Text = "c";
            // 
            // txtSymbol2
            // 
            this.txtSymbol2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSymbol2.Location = new System.Drawing.Point(9, 88);
            this.txtSymbol2.Name = "txtSymbol2";
            this.txtSymbol2.Size = new System.Drawing.Size(91, 26);
            this.txtSymbol2.TabIndex = 2;
            this.txtSymbol2.Text = "b";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(230, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 517);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.listBox2);
            this.panel3.Controls.Add(this.txtDecoded);
            this.panel3.Controls.Add(this.txtCode);
            this.panel3.Controls.Add(this.btnDecode);
            this.panel3.Controls.Add(this.btnCodes);
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Location = new System.Drawing.Point(1007, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 517);
            this.panel3.TabIndex = 17;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(11, 335);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(189, 164);
            this.listBox2.Sorted = true;
            this.listBox2.TabIndex = 21;
            // 
            // txtDecoded
            // 
            this.txtDecoded.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecoded.Location = new System.Drawing.Point(11, 300);
            this.txtDecoded.Name = "txtDecoded";
            this.txtDecoded.ReadOnly = true;
            this.txtDecoded.Size = new System.Drawing.Size(189, 26);
            this.txtDecoded.TabIndex = 20;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(11, 268);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(189, 26);
            this.txtCode.TabIndex = 19;
            this.txtCode.Text = "000100111";
            // 
            // btnDecode
            // 
            this.btnDecode.Enabled = false;
            this.btnDecode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDecode.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecode.Location = new System.Drawing.Point(10, 226);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(190, 35);
            this.btnDecode.TabIndex = 18;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // btnCodes
            // 
            this.btnCodes.Enabled = false;
            this.btnCodes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCodes.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodes.Location = new System.Drawing.Point(10, 15);
            this.btnCodes.Name = "btnCodes";
            this.btnCodes.Size = new System.Drawing.Size(190, 35);
            this.btnCodes.TabIndex = 17;
            this.btnCodes.Text = "Encode";
            this.btnCodes.UseVisualStyleBackColor = true;
            this.btnCodes.Click += new System.EventHandler(this.btnCodes_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(11, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(189, 164);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1230, 542);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Huffman Coding";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTreeBuilder;
        private System.Windows.Forms.TextBox txtSymbol1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFreq8;
        private System.Windows.Forms.TextBox txtFreq7;
        private System.Windows.Forms.TextBox txtFreq6;
        private System.Windows.Forms.TextBox txtFreq5;
        private System.Windows.Forms.TextBox txtFreq4;
        private System.Windows.Forms.TextBox txtFreq3;
        private System.Windows.Forms.TextBox txtFreq2;
        private System.Windows.Forms.TextBox txtFreq1;
        private System.Windows.Forms.TextBox txtSymbol8;
        private System.Windows.Forms.TextBox txtSymbol7;
        private System.Windows.Forms.TextBox txtSymbol6;
        private System.Windows.Forms.TextBox txtSymbol5;
        private System.Windows.Forms.TextBox txtSymbol4;
        private System.Windows.Forms.TextBox txtSymbol3;
        private System.Windows.Forms.TextBox txtSymbol2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCodes;
        private System.Windows.Forms.TextBox txtDecoded;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.TextBox txtHuffman;
        private System.Windows.Forms.TextBox txtFixed;
        private System.Windows.Forms.Button btnComparison;
        private System.Windows.Forms.Button btnEncodeFile;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.ListBox listBox2;


    }
}

