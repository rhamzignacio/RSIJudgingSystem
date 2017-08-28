namespace RSI_Judging_System
{
    partial class MainWindow
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
            this.btnTop10 = new System.Windows.Forms.Button();
            this.btnTop5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTop10
            // 
            this.btnTop10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTop10.Location = new System.Drawing.Point(25, 27);
            this.btnTop10.Name = "btnTop10";
            this.btnTop10.Size = new System.Drawing.Size(564, 76);
            this.btnTop10.TabIndex = 0;
            this.btnTop10.Text = "Top 10";
            this.btnTop10.UseVisualStyleBackColor = true;
            // 
            // btnTop5
            // 
            this.btnTop5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTop5.Location = new System.Drawing.Point(25, 119);
            this.btnTop5.Name = "btnTop5";
            this.btnTop5.Size = new System.Drawing.Size(564, 76);
            this.btnTop5.TabIndex = 1;
            this.btnTop5.Text = "Top 5";
            this.btnTop5.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 227);
            this.Controls.Add(this.btnTop5);
            this.Controls.Add(this.btnTop10);
            this.Name = "MainWindow";
            this.Text = "RSI Judging System 1.0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTop10;
        private System.Windows.Forms.Button btnTop5;
    }
}