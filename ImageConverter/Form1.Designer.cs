namespace ImageConverter
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imageList = new System.Windows.Forms.ListBox();
            this.btnSelectImages = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.AllowDrop = true;
            this.imageList.FormattingEnabled = true;
            this.imageList.ItemHeight = 15;
            this.imageList.Location = new System.Drawing.Point(6, 60);
            this.imageList.Name = "imageList";
            this.imageList.Size = new System.Drawing.Size(342, 364);
            this.imageList.TabIndex = 0;
            this.imageList.DragDrop += new System.Windows.Forms.DragEventHandler(this.imageList_DragDrop);
            this.imageList.DragOver += new System.Windows.Forms.DragEventHandler(this.imageList_DragOver);
            // 
            // btnSelectImages
            // 
            this.btnSelectImages.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSelectImages.Image = global::ImageConverter.Properties.Resources.image;
            this.btnSelectImages.Location = new System.Drawing.Point(6, 12);
            this.btnSelectImages.Name = "btnSelectImages";
            this.btnSelectImages.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSelectImages.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSelectImages.Size = new System.Drawing.Size(294, 42);
            this.btnSelectImages.TabIndex = 1;
            this.btnSelectImages.Text = "Select WEBP Images";
            this.btnSelectImages.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelectImages.UseVisualStyleBackColor = true;
            this.btnSelectImages.Click += new System.EventHandler(this.btnSelectImages_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInfo.Image = global::ImageConverter.Properties.Resources.info;
            this.btnInfo.Location = new System.Drawing.Point(306, 12);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnInfo.Size = new System.Drawing.Size(42, 42);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 456);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnSelectImages);
            this.Controls.Add(this.imageList);
            this.Name = "MainForm";
            this.Text = "RapidPC | WEBP to JPG Converter";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.imageList_DragDrop);
            this.ResumeLayout(false);

        }

        #endregion
        private ListBox imageList;
        private Button btnSelectImages;
        private Button btnInfo;
    }
}