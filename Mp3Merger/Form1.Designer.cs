
namespace Mp3Merger
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
            this.button1 = new System.Windows.Forms.Button();
            this.label_outputPath = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label_filesNumber = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.LBFiles = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 101);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Select Files";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnSelectFiles_Click);
            // 
            // label_outputPath
            // 
            this.label_outputPath.AutoSize = true;
            this.label_outputPath.Location = new System.Drawing.Point(16, 57);
            this.label_outputPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_outputPath.Name = "label_outputPath";
            this.label_outputPath.Size = new System.Drawing.Size(0, 16);
            this.label_outputPath.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(292, 50);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Select Output Path";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnSelectOutputPath_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(189, 471);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 28);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // label_filesNumber
            // 
            this.label_filesNumber.AutoSize = true;
            this.label_filesNumber.Location = new System.Drawing.Point(16, 15);
            this.label_filesNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_filesNumber.Name = "label_filesNumber";
            this.label_filesNumber.Size = new System.Drawing.Size(25, 16);
            this.label_filesNumber.TabIndex = 1;
            this.label_filesNumber.Text = "0/0";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(85, 15);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(373, 28);
            this.progressBar.TabIndex = 0;
            // 
            // LBFiles
            // 
            this.LBFiles.AllowDrop = true;
            this.LBFiles.DisplayMember = "ShortName";
            this.LBFiles.FormattingEnabled = true;
            this.LBFiles.ItemHeight = 16;
            this.LBFiles.Location = new System.Drawing.Point(19, 101);
            this.LBFiles.Name = "LBFiles";
            this.LBFiles.Size = new System.Drawing.Size(332, 356);
            this.LBFiles.TabIndex = 6;
            this.LBFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.LBFiles_DragDrop);
            this.LBFiles.DragOver += new System.Windows.Forms.DragEventHandler(this.LBFiles_DragOver);
            this.LBFiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LBFiles_MouseDown);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(358, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 50);
            this.button3.TabIndex = 7;
            this.button3.Text = "Move UP";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnMoveUP_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(357, 277);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 50);
            this.button4.TabIndex = 8;
            this.button4.Text = "Move Down";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BtnMoveDown_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(358, 429);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 28);
            this.button5.TabIndex = 9;
            this.button5.Text = "Remove";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(19, 474);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Reset";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 512);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.LBFiles);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label_outputPath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_filesNumber);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mp3 Merger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_outputPath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label_filesNumber;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ListBox LBFiles;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

