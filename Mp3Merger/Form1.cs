using Mp3Merger.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mp3Merger
{
    public partial class Form1 : Form
    {
        public static int progressBarIncrement = 1;
        public static int currentFileProcessing = 0;
        public static string outPutFileName = "Mp3MergerOut.mp3";

        public Form1()
        {
            InitializeComponent();
        }

        private void LBFiles_MouseDown(object sender, MouseEventArgs e)
        {
            if (LBFiles.SelectedItem == null) return;
            LBFiles.DoDragDrop(LBFiles.SelectedItem, DragDropEffects.Move);
        }

        private void LBFiles_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void LBFiles_DragDrop(object sender, DragEventArgs e)
        {
            Point point = LBFiles.PointToClient(new Point(e.X, e.Y));
            int index = LBFiles.IndexFromPoint(point);
            if (index < 0) index = LBFiles.Items.Count - 1;
            object data = e.Data.GetData(typeof(FilesLBModel));
            if (data != null)
            {
                LBFiles.Items.Remove(data);
                LBFiles.Items.Insert(index, data);
            }
        }
        
        private void BtnSelectFiles_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Mp3 files (*.mp3)|*.mp3";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog.FileNames.Length < 2)
                    {
                        MessageBox.Show("you must choose atleast 2 files to merge");
                    }
                    else
                    {
                        foreach (var item in openFileDialog.FileNames)
                        {
                            var fileName = Path.GetFileName(item);
                            LBFiles.Items.Add(new FilesLBModel()
                            {
                                ShortName = fileName,
                                FullPath = item
                            });
                        }
                        label_filesNumber.Text = currentFileProcessing + "/" + openFileDialog.FileNames.Length;

                        progressBarIncrement = 100 / openFileDialog.FileNames.Length;
                        if (progressBarIncrement < 0)
                            progressBarIncrement = 1;
                    }
                }
            }
        }

        private void BtnSelectOutputPath_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    label_outputPath.Text = fbd.SelectedPath;
                }
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (LBFiles.Items != null && LBFiles.Items.Count > 0)
            {
                if (!string.IsNullOrWhiteSpace(label_outputPath.Text))
                {
                    ProcessFiles();
                    MessageBox.Show("Done");
                    resetEverything();
                }
                else
                {
                    MessageBox.Show("you must choose output Path");
                }
            }
            else
            {
                MessageBox.Show("you must choose files to merge");
            }
        }

        private void resetEverything()
        {
            LBFiles.Items.Clear();
            progressBarIncrement = 1;
            currentFileProcessing = 0;

            label_filesNumber.Text = @"0\0";
            label_outputPath.Text = @"";
            progressBar.Value = 0;
        }

        private void ProcessFiles()
        {
            var outputPath = label_outputPath.Text + @"\" + outPutFileName;

            using (var fs = File.OpenWrite(outputPath))
            {
                for (int i = 0; i < LBFiles.Items.Count; i++)
                {
                    var filePath = ((FilesLBModel)LBFiles.Items[i]).FullPath;
                    var buffer = File.ReadAllBytes(filePath);
                    fs.Write(buffer, 0, buffer.Length);

                    progressBar.Increment(progressBarIncrement);
                    currentFileProcessing += 1;
                    label_filesNumber.Text = currentFileProcessing.ToString() + "/" + LBFiles.Items.Count.ToString();
                }
                fs.Flush();
            }
        }

        private void BtnMoveUP_Click(object sender, EventArgs e)
        {
            if (LBFiles.SelectedItem == null)
            {
                MessageBox.Show("please select a file from the list to move");
                return;
            }

            var currentIndex = LBFiles.SelectedIndex;
            var currentItem = LBFiles.SelectedItem;

            if (currentIndex != 0)
            {
                currentIndex--;
                LBFiles.Items.Remove(currentItem);
                LBFiles.Items.Insert(currentIndex, currentItem);
                LBFiles.SelectedIndex = currentIndex;
            }
        }

        private void BtnMoveDown_Click(object sender, EventArgs e)
        {
            if (LBFiles.SelectedItem == null)
            {
                MessageBox.Show("please select a file from the list to move");
                return;
            }

            var currentIndex = LBFiles.SelectedIndex;
            var currentItem = LBFiles.SelectedItem;

            if (currentIndex != LBFiles.Items.Count - 1)
            {
                currentIndex++;
                LBFiles.Items.Remove(currentItem);
                LBFiles.Items.Insert(currentIndex, currentItem);
                LBFiles.SelectedIndex = currentIndex;
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (LBFiles.SelectedItem == null)
            {
                MessageBox.Show("please select a file from the list to remove");
                return;
            }

            if (LBFiles.Items.Count == 2)
            {
                MessageBox.Show("a minimum of 2 files must remain in list");
                return;
            }

            LBFiles.Items.Remove(LBFiles.SelectedItem);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            resetEverything();
        }
    }
}
