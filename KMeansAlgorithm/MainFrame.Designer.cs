namespace KMeansAlgorithm
{
    partial class MainFrame
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
            this.picboxBeforeClusterization = new System.Windows.Forms.PictureBox();
            this.picBoxAfterClusterization = new System.Windows.Forms.PictureBox();
            this.tboxDots = new System.Windows.Forms.TextBox();
            this.tboxClusters = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnClusterize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxBeforeClusterization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAfterClusterization)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxBeforeClusterization
            // 
            this.picboxBeforeClusterization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picboxBeforeClusterization.Location = new System.Drawing.Point(12, 12);
            this.picboxBeforeClusterization.Name = "picboxBeforeClusterization";
            this.picboxBeforeClusterization.Size = new System.Drawing.Size(420, 421);
            this.picboxBeforeClusterization.TabIndex = 0;
            this.picboxBeforeClusterization.TabStop = false;
            // 
            // picBoxAfterClusterization
            // 
            this.picBoxAfterClusterization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxAfterClusterization.Location = new System.Drawing.Point(575, 12);
            this.picBoxAfterClusterization.Name = "picBoxAfterClusterization";
            this.picBoxAfterClusterization.Size = new System.Drawing.Size(420, 420);
            this.picBoxAfterClusterization.TabIndex = 1;
            this.picBoxAfterClusterization.TabStop = false;
            // 
            // tboxDots
            // 
            this.tboxDots.Location = new System.Drawing.Point(453, 30);
            this.tboxDots.Name = "tboxDots";
            this.tboxDots.Size = new System.Drawing.Size(100, 20);
            this.tboxDots.TabIndex = 2;
            // 
            // tboxClusters
            // 
            this.tboxClusters.Location = new System.Drawing.Point(453, 85);
            this.tboxClusters.Name = "tboxClusters";
            this.tboxClusters.Size = new System.Drawing.Size(100, 20);
            this.tboxClusters.TabIndex = 3;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(453, 127);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(100, 51);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // btnClusterize
            // 
            this.btnClusterize.Location = new System.Drawing.Point(453, 372);
            this.btnClusterize.Name = "btnClusterize";
            this.btnClusterize.Size = new System.Drawing.Size(100, 60);
            this.btnClusterize.TabIndex = 5;
            this.btnClusterize.Text = "Clusterize";
            this.btnClusterize.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(450, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dots quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Clusters quantity:";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 445);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClusterize);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.tboxClusters);
            this.Controls.Add(this.tboxDots);
            this.Controls.Add(this.picBoxAfterClusterization);
            this.Controls.Add(this.picboxBeforeClusterization);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainFrame";
            this.Text = "K-means algorithm";
            ((System.ComponentModel.ISupportInitialize)(this.picboxBeforeClusterization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAfterClusterization)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxBeforeClusterization;
        private System.Windows.Forms.PictureBox picBoxAfterClusterization;
        private System.Windows.Forms.TextBox tboxDots;
        private System.Windows.Forms.TextBox tboxClusters;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnClusterize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

