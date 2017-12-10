namespace FDC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picFarmer = new System.Windows.Forms.PictureBox();
            this.picFox = new System.Windows.Forms.PictureBox();
            this.picDuck = new System.Windows.Forms.PictureBox();
            this.picCorn = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSolve = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFarmer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDuck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCorn)).BeginInit();
            this.SuspendLayout();
            // 
            // picFarmer
            // 
            this.picFarmer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFarmer.BackgroundImage")));
            this.picFarmer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFarmer.Location = new System.Drawing.Point(27, 30);
            this.picFarmer.Name = "picFarmer";
            this.picFarmer.Size = new System.Drawing.Size(82, 85);
            this.picFarmer.TabIndex = 0;
            this.picFarmer.TabStop = false;
            // 
            // picFox
            // 
            this.picFox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFox.BackgroundImage")));
            this.picFox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picFox.Location = new System.Drawing.Point(27, 132);
            this.picFox.Name = "picFox";
            this.picFox.Size = new System.Drawing.Size(82, 85);
            this.picFox.TabIndex = 1;
            this.picFox.TabStop = false;
            // 
            // picDuck
            // 
            this.picDuck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picDuck.BackgroundImage")));
            this.picDuck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDuck.Location = new System.Drawing.Point(27, 234);
            this.picDuck.Name = "picDuck";
            this.picDuck.Size = new System.Drawing.Size(82, 85);
            this.picDuck.TabIndex = 2;
            this.picDuck.TabStop = false;
            // 
            // picCorn
            // 
            this.picCorn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCorn.BackgroundImage")));
            this.picCorn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCorn.Location = new System.Drawing.Point(27, 336);
            this.picCorn.Name = "picCorn";
            this.picCorn.Size = new System.Drawing.Size(82, 85);
            this.picCorn.TabIndex = 3;
            this.picCorn.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(126, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 433);
            this.panel1.TabIndex = 4;
            // 
            // btnSolve
            // 
            this.btnSolve.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolve.Location = new System.Drawing.Point(579, 13);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(208, 35);
            this.btnSolve.TabIndex = 5;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(579, 68);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 381);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picCorn);
            this.Controls.Add(this.picDuck);
            this.Controls.Add(this.picFox);
            this.Controls.Add(this.picFarmer);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picFarmer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDuck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCorn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picFarmer;
        private System.Windows.Forms.PictureBox picFox;
        private System.Windows.Forms.PictureBox picDuck;
        private System.Windows.Forms.PictureBox picCorn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.ListBox listBox1;
    }
}

