namespace LinearDataStructures
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
            this.txtBrackets = new System.Windows.Forms.TextBox();
            this.btnBalanceCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBraceResult = new System.Windows.Forms.Label();
            this.lblPostFixResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPalindromeResult = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPostfix = new System.Windows.Forms.Button();
            this.txtPostfix = new System.Windows.Forms.TextBox();
            this.btnPalindrome = new System.Windows.Forms.Button();
            this.txtPalindrome = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBrackets
            // 
            this.txtBrackets.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrackets.Location = new System.Drawing.Point(259, 79);
            this.txtBrackets.Name = "txtBrackets";
            this.txtBrackets.Size = new System.Drawing.Size(472, 30);
            this.txtBrackets.TabIndex = 0;
            this.txtBrackets.Text = "ab{cde}fg";
            this.txtBrackets.TextChanged += new System.EventHandler(this.txtBrackets_TextChanged);
            // 
            // btnBalanceCheck
            // 
            this.btnBalanceCheck.Enabled = false;
            this.btnBalanceCheck.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalanceCheck.Location = new System.Drawing.Point(22, 79);
            this.btnBalanceCheck.Name = "btnBalanceCheck";
            this.btnBalanceCheck.Size = new System.Drawing.Size(221, 30);
            this.btnBalanceCheck.TabIndex = 1;
            this.btnBalanceCheck.Text = "Balanced Braces";
            this.btnBalanceCheck.UseVisualStyleBackColor = true;
            this.btnBalanceCheck.Click += new System.EventHandler(this.btnBalanceCheck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Result :";
            // 
            // lblBraceResult
            // 
            this.lblBraceResult.AutoSize = true;
            this.lblBraceResult.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBraceResult.Location = new System.Drawing.Point(120, 122);
            this.lblBraceResult.Name = "lblBraceResult";
            this.lblBraceResult.Size = new System.Drawing.Size(0, 21);
            this.lblBraceResult.TabIndex = 3;
            // 
            // lblPostFixResult
            // 
            this.lblPostFixResult.AutoSize = true;
            this.lblPostFixResult.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostFixResult.Location = new System.Drawing.Point(120, 230);
            this.lblPostFixResult.Name = "lblPostFixResult";
            this.lblPostFixResult.Size = new System.Drawing.Size(0, 21);
            this.lblPostFixResult.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result :";
            // 
            // lblPalindromeResult
            // 
            this.lblPalindromeResult.AutoSize = true;
            this.lblPalindromeResult.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalindromeResult.Location = new System.Drawing.Point(120, 340);
            this.lblPalindromeResult.Name = "lblPalindromeResult";
            this.lblPalindromeResult.Size = new System.Drawing.Size(0, 21);
            this.lblPalindromeResult.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Result :";
            // 
            // btnPostfix
            // 
            this.btnPostfix.Enabled = false;
            this.btnPostfix.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostfix.Location = new System.Drawing.Point(22, 176);
            this.btnPostfix.Name = "btnPostfix";
            this.btnPostfix.Size = new System.Drawing.Size(221, 30);
            this.btnPostfix.TabIndex = 9;
            this.btnPostfix.Text = "Postfix Parser";
            this.btnPostfix.UseVisualStyleBackColor = true;
            this.btnPostfix.Click += new System.EventHandler(this.btnPostfix_Click);
            // 
            // txtPostfix
            // 
            this.txtPostfix.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostfix.Location = new System.Drawing.Point(259, 176);
            this.txtPostfix.Name = "txtPostfix";
            this.txtPostfix.Size = new System.Drawing.Size(472, 30);
            this.txtPostfix.TabIndex = 8;
            this.txtPostfix.Text = "234*+5+";
            this.txtPostfix.TextChanged += new System.EventHandler(this.txtPostfix_TextChanged);
            // 
            // btnPalindrome
            // 
            this.btnPalindrome.Enabled = false;
            this.btnPalindrome.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPalindrome.Location = new System.Drawing.Point(22, 284);
            this.btnPalindrome.Name = "btnPalindrome";
            this.btnPalindrome.Size = new System.Drawing.Size(221, 30);
            this.btnPalindrome.TabIndex = 11;
            this.btnPalindrome.Text = "Palindrome Checker";
            this.btnPalindrome.UseVisualStyleBackColor = true;
            this.btnPalindrome.Click += new System.EventHandler(this.btnPalindrome_Click);
            // 
            // txtPalindrome
            // 
            this.txtPalindrome.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPalindrome.Location = new System.Drawing.Point(259, 284);
            this.txtPalindrome.Name = "txtPalindrome";
            this.txtPalindrome.Size = new System.Drawing.Size(472, 30);
            this.txtPalindrome.TabIndex = 10;
            this.txtPalindrome.Text = "tattarrattat";
            this.txtPalindrome.TextChanged += new System.EventHandler(this.txtPalindrome_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(26, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(705, 37);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Algorithms using Stack and Queue";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 389);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnPalindrome);
            this.Controls.Add(this.txtPalindrome);
            this.Controls.Add(this.btnPostfix);
            this.Controls.Add(this.txtPostfix);
            this.Controls.Add(this.lblPalindromeResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPostFixResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBraceResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBalanceCheck);
            this.Controls.Add(this.txtBrackets);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBrackets;
        private System.Windows.Forms.Button btnBalanceCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBraceResult;
        private System.Windows.Forms.Label lblPostFixResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPalindromeResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPostfix;
        private System.Windows.Forms.TextBox txtPostfix;
        private System.Windows.Forms.Button btnPalindrome;
        private System.Windows.Forms.TextBox txtPalindrome;
        private System.Windows.Forms.Label lblTitle;
    }
}

