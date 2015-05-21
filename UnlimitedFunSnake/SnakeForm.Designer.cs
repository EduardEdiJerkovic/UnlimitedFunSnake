namespace UnlimitedFunSnake
{
    partial class SnakeForm
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
            this.snakePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.snakePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // snakePictureBox
            // 
            this.snakePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.snakePictureBox.Location = new System.Drawing.Point(0, 0);
            this.snakePictureBox.Name = "snakePictureBox";
            this.snakePictureBox.Size = new System.Drawing.Size(436, 315);
            this.snakePictureBox.TabIndex = 0;
            this.snakePictureBox.TabStop = false;
            // 
            // SnakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 315);
            this.Controls.Add(this.snakePictureBox);
            this.Name = "SnakeForm";
            this.Text = "Snake";
            ((System.ComponentModel.ISupportInitialize)(this.snakePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox snakePictureBox;
    }
}

