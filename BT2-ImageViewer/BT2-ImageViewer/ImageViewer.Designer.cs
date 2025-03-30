namespace BT2_ImageViewer
{
    partial class imageViewerForm
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
            this.loadFolderButton = new System.Windows.Forms.Button();
            this.imageFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.pathLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loadFolderButton
            // 
            this.loadFolderButton.Location = new System.Drawing.Point(8, 21);
            this.loadFolderButton.Name = "loadFolderButton";
            this.loadFolderButton.Size = new System.Drawing.Size(116, 28);
            this.loadFolderButton.TabIndex = 0;
            this.loadFolderButton.Text = "&Load Folder";
            this.loadFolderButton.UseVisualStyleBackColor = true;
            this.loadFolderButton.Click += new System.EventHandler(this.loadFolderButton_Click);
            // 
            // imageFlowLayoutPanel
            // 
            this.imageFlowLayoutPanel.Location = new System.Drawing.Point(4, 278);
            this.imageFlowLayoutPanel.Name = "imageFlowLayoutPanel";
            this.imageFlowLayoutPanel.Size = new System.Drawing.Size(679, 104);
            this.imageFlowLayoutPanel.TabIndex = 1;
            this.imageFlowLayoutPanel.WrapContents = false;
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePictureBox.Location = new System.Drawing.Point(0, 70);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(799, 204);
            this.imagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePictureBox.TabIndex = 2;
            this.imagePictureBox.TabStop = false;
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(7, 424);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(55, 16);
            this.pathLabel.TabIndex = 3;
            this.pathLabel.Text = "                ";
            // 
            // imageViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.imageFlowLayoutPanel);
            this.Controls.Add(this.loadFolderButton);
            this.Name = "imageViewerForm";
            this.Text = "Image Viewer";
            
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadFolderButton;
        private System.Windows.Forms.FlowLayoutPanel imageFlowLayoutPanel;
        private System.Windows.Forms.PictureBox imagePictureBox;
        private System.Windows.Forms.Label pathLabel;
    }
}

