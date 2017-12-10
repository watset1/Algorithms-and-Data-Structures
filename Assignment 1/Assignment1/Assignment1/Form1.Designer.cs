namespace Assignment1
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
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoTree = new System.Windows.Forms.RadioButton();
            this.rdoSnowflake = new System.Windows.Forms.RadioButton();
            this.rdoTriangle = new System.Windows.Forms.RadioButton();
            this.rdoDragon = new System.Windows.Forms.RadioButton();
            this.rdoCircle = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "RUN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(12, 51);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(206, 26);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoCircle);
            this.groupBox1.Controls.Add(this.rdoDragon);
            this.groupBox1.Controls.Add(this.rdoTree);
            this.groupBox1.Controls.Add(this.rdoSnowflake);
            this.groupBox1.Controls.Add(this.rdoTriangle);
            this.groupBox1.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 216);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // rdoTree
            // 
            this.rdoTree.AutoSize = true;
            this.rdoTree.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTree.Location = new System.Drawing.Point(4, 95);
            this.rdoTree.Name = "rdoTree";
            this.rdoTree.Size = new System.Drawing.Size(120, 24);
            this.rdoTree.TabIndex = 2;
            this.rdoTree.Text = "Fractal Tree";
            this.rdoTree.UseVisualStyleBackColor = true;
            // 
            // rdoSnowflake
            // 
            this.rdoSnowflake.AutoSize = true;
            this.rdoSnowflake.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSnowflake.Location = new System.Drawing.Point(4, 56);
            this.rdoSnowflake.Name = "rdoSnowflake";
            this.rdoSnowflake.Size = new System.Drawing.Size(165, 24);
            this.rdoSnowflake.TabIndex = 1;
            this.rdoSnowflake.Text = "Koch\'s Snowflake";
            this.rdoSnowflake.UseVisualStyleBackColor = true;
            // 
            // rdoTriangle
            // 
            this.rdoTriangle.AutoSize = true;
            this.rdoTriangle.Checked = true;
            this.rdoTriangle.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTriangle.Location = new System.Drawing.Point(4, 20);
            this.rdoTriangle.Name = "rdoTriangle";
            this.rdoTriangle.Size = new System.Drawing.Size(184, 24);
            this.rdoTriangle.TabIndex = 0;
            this.rdoTriangle.TabStop = true;
            this.rdoTriangle.Text = "Serpinksi\'s Triangle";
            this.rdoTriangle.UseVisualStyleBackColor = true;
            // 
            // rdoDragon
            // 
            this.rdoDragon.AutoSize = true;
            this.rdoDragon.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoDragon.Location = new System.Drawing.Point(6, 134);
            this.rdoDragon.Name = "rdoDragon";
            this.rdoDragon.Size = new System.Drawing.Size(167, 24);
            this.rdoDragon.TabIndex = 3;
            this.rdoDragon.Text = "Heighway Dragon";
            this.rdoDragon.UseVisualStyleBackColor = true;
            // 
            // rdoCircle
            // 
            this.rdoCircle.AutoSize = true;
            this.rdoCircle.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCircle.Location = new System.Drawing.Point(4, 173);
            this.rdoCircle.Name = "rdoCircle";
            this.rdoCircle.Size = new System.Drawing.Size(140, 24);
            this.rdoCircle.TabIndex = 4;
            this.rdoCircle.Text = "Fractal Circles";
            this.rdoCircle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1238, 695);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoTriangle;
        private System.Windows.Forms.RadioButton rdoSnowflake;
        private System.Windows.Forms.RadioButton rdoTree;
        private System.Windows.Forms.RadioButton rdoDragon;
        private System.Windows.Forms.RadioButton rdoCircle;
    }
}

