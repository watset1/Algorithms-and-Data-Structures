namespace SimpleBinaryTrees
{
    partial class AppMenu
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
            this.btnPrac1 = new System.Windows.Forms.Button();
            this.btnPrac2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrac1
            // 
            this.btnPrac1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrac1.Location = new System.Drawing.Point(33, 67);
            this.btnPrac1.Name = "btnPrac1";
            this.btnPrac1.Size = new System.Drawing.Size(219, 34);
            this.btnPrac1.TabIndex = 0;
            this.btnPrac1.Text = "Practical 6.1";
            this.btnPrac1.UseVisualStyleBackColor = true;
            this.btnPrac1.Click += new System.EventHandler(this.btnPrac1_Click);
            // 
            // btnPrac2
            // 
            this.btnPrac2.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrac2.Location = new System.Drawing.Point(33, 113);
            this.btnPrac2.Name = "btnPrac2";
            this.btnPrac2.Size = new System.Drawing.Size(219, 34);
            this.btnPrac2.TabIndex = 1;
            this.btnPrac2.Text = "Practical 6.2";
            this.btnPrac2.UseVisualStyleBackColor = true;
            this.btnPrac2.Click += new System.EventHandler(this.btnPrac2_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Binary Trees";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AppMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrac2);
            this.Controls.Add(this.btnPrac1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AppMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Binary Trees";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrac1;
        private System.Windows.Forms.Button btnPrac2;
        private System.Windows.Forms.Label label1;
    }
}