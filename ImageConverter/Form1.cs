using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImageConverter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            imageList.Items.Insert(0, "Waiting for files");
        }

        #region Methods

        private async Task ConvertFiles(string[] files)
        {
            imageList.Items.Insert(0, DateTime.Now.ToString("h:mm:ss tt") + " | Converting " + files.Length + " images");
            var tasks = new List<Task>();
            foreach (var file in files)
            {
                if (Path.GetExtension(file) != ".webp")
                {
                    imageList.Items.Insert(0, Path.GetFileName(file) + " is not a WEBP file-type");
                    continue;
                }

                string output = file.Replace(".webp", ".jpg");
                byte[] rawWebP = File.ReadAllBytes(file);
                using (WebP webp = new WebP())
                {
                    var bitmap = webp.Decode(rawWebP);
                    bitmap.Save(output, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                imageList.Items.Insert(0, DateTime.Now.ToString("h:mm:ss tt") + " | " + Path.GetFileName(file) + " converted");
            }
            await Task.WhenAll(tasks);
            imageList.Items.Insert(0, DateTime.Now.ToString("h:mm:ss tt") + " | Finished Converting");
        }

        #endregion

        #region Events

        private async void btnSelectImages_Click(object sender, EventArgs e)
        {
            imageList.Items.Clear();

            var openFileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "WEBP files (*.webp)|*.webp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                await ConvertFiles(openFileDialog.FileNames);
            }
        }

        private async void imageList_DragDrop(object sender, DragEventArgs e)
        {
            imageList.Items.Clear();

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Any())
            {
                await ConvertFiles(files);
            }
        }

        private void imageList_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This utility is used to convert WEBP images to JPG." + Environment.NewLine + Environment.NewLine + "Add images to process by:" + Environment.NewLine + "1) Dragging and dropping the images" + Environment.NewLine + "2) Use the 'Select Images' button" + Environment.NewLine + Environment.NewLine + "Brought to you by RapidPC.net", "About WEBP to JPG Converter", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

    }
}