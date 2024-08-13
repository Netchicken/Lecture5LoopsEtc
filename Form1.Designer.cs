namespace Lecture5LoopsEtc
{
    partial class Form1
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
            btnWhileLoop = new Button();
            txtData1 = new TextBox();
            txtData2 = new TextBox();
            lbxLoop = new ListBox();
            label1 = new Label();
            label2 = new Label();
            btnDoWhile = new Button();
            btnRandom = new Button();
            button1 = new Button();
            btnForLoop = new Button();
            btnWritetofile = new Button();
            btnAppendtext = new Button();
            btnReadTextFromFile = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            btnOpenFile = new Button();
            btnSaveFile = new Button();
            btnForEach = new Button();
            SuspendLayout();
            // 
            // btnWhileLoop
            // 
            btnWhileLoop.Location = new Point(19, 72);
            btnWhileLoop.Margin = new Padding(4, 5, 4, 5);
            btnWhileLoop.Name = "btnWhileLoop";
            btnWhileLoop.Size = new Size(107, 38);
            btnWhileLoop.TabIndex = 0;
            btnWhileLoop.Text = "While Loop";
            btnWhileLoop.UseVisualStyleBackColor = true;
            btnWhileLoop.Click += btnWhileLoop_Click;
            // 
            // txtData1
            // 
            txtData1.Location = new Point(169, 40);
            txtData1.Margin = new Padding(4, 5, 4, 5);
            txtData1.Name = "txtData1";
            txtData1.Size = new Size(141, 31);
            txtData1.TabIndex = 1;
            // 
            // txtData2
            // 
            txtData2.Location = new Point(320, 38);
            txtData2.Margin = new Padding(4, 5, 4, 5);
            txtData2.Name = "txtData2";
            txtData2.Size = new Size(141, 31);
            txtData2.TabIndex = 2;
            // 
            // lbxLoop
            // 
            lbxLoop.FormattingEnabled = true;
            lbxLoop.ItemHeight = 25;
            lbxLoop.Location = new Point(169, 88);
            lbxLoop.Margin = new Padding(4, 5, 4, 5);
            lbxLoop.Name = "lbxLoop";
            lbxLoop.Size = new Size(564, 629);
            lbxLoop.TabIndex = 4;
            lbxLoop.SelectedIndexChanged += lbxLoop_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 5;
            label1.Text = "Data 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(320, 8);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 6;
            label2.Text = "Data 2";
            // 
            // btnDoWhile
            // 
            btnDoWhile.Location = new Point(17, 120);
            btnDoWhile.Margin = new Padding(4, 5, 4, 5);
            btnDoWhile.Name = "btnDoWhile";
            btnDoWhile.Size = new Size(109, 68);
            btnDoWhile.TabIndex = 7;
            btnDoWhile.Text = "Do While Loop";
            btnDoWhile.UseVisualStyleBackColor = true;
            btnDoWhile.Click += btnDoWhile_Click;
            // 
            // btnRandom
            // 
            btnRandom.Location = new Point(19, 213);
            btnRandom.Margin = new Padding(4, 5, 4, 5);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(107, 102);
            btnRandom.TabIndex = 8;
            btnRandom.Text = "While Random Number";
            btnRandom.UseVisualStyleBackColor = true;
            btnRandom.Click += btnRandom_Click;
            // 
            // button1
            // 
            button1.Location = new Point(17, 325);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(107, 113);
            button1.TabIndex = 9;
            button1.Text = "Do Random Number";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnForLoop
            // 
            btnForLoop.Location = new Point(19, 448);
            btnForLoop.Margin = new Padding(4, 5, 4, 5);
            btnForLoop.Name = "btnForLoop";
            btnForLoop.Size = new Size(106, 80);
            btnForLoop.TabIndex = 10;
            btnForLoop.Text = "For Loop";
            btnForLoop.UseVisualStyleBackColor = true;
            btnForLoop.Click += btnForLoop_Click;
            // 
            // btnWritetofile
            // 
            btnWritetofile.Location = new Point(784, 88);
            btnWritetofile.Margin = new Padding(4, 5, 4, 5);
            btnWritetofile.Name = "btnWritetofile";
            btnWritetofile.Size = new Size(137, 80);
            btnWritetofile.TabIndex = 11;
            btnWritetofile.Text = "Write to File";
            btnWritetofile.UseVisualStyleBackColor = true;
            btnWritetofile.Click += btnWritetofile_Click;
            // 
            // btnAppendtext
            // 
            btnAppendtext.Location = new Point(784, 197);
            btnAppendtext.Margin = new Padding(4, 5, 4, 5);
            btnAppendtext.Name = "btnAppendtext";
            btnAppendtext.Size = new Size(140, 75);
            btnAppendtext.TabIndex = 12;
            btnAppendtext.Text = "Add text to file";
            btnAppendtext.UseVisualStyleBackColor = true;
            btnAppendtext.Click += btnAppendtext_Click;
            // 
            // btnReadTextFromFile
            // 
            btnReadTextFromFile.Location = new Point(784, 307);
            btnReadTextFromFile.Margin = new Padding(4, 5, 4, 5);
            btnReadTextFromFile.Name = "btnReadTextFromFile";
            btnReadTextFromFile.Size = new Size(140, 73);
            btnReadTextFromFile.TabIndex = 13;
            btnReadTextFromFile.Text = "Read Text";
            btnReadTextFromFile.UseVisualStyleBackColor = true;
            btnReadTextFromFile.Click += btnReadTextFromFile_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(784, 423);
            btnOpenFile.Margin = new Padding(4, 5, 4, 5);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(137, 55);
            btnOpenFile.TabIndex = 14;
            btnOpenFile.Text = "Open File";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Location = new Point(794, 525);
            btnSaveFile.Margin = new Padding(4, 5, 4, 5);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(116, 42);
            btnSaveFile.TabIndex = 15;
            btnSaveFile.Text = "Save File";
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // btnForEach
            // 
            btnForEach.Location = new Point(17, 551);
            btnForEach.Name = "btnForEach";
            btnForEach.Size = new Size(107, 80);
            btnForEach.TabIndex = 16;
            btnForEach.Text = "For Each loop";
            btnForEach.UseVisualStyleBackColor = true;
            btnForEach.Click += btnForEach_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(1143, 750);
            Controls.Add(btnForEach);
            Controls.Add(btnSaveFile);
            Controls.Add(btnOpenFile);
            Controls.Add(btnReadTextFromFile);
            Controls.Add(btnAppendtext);
            Controls.Add(btnWritetofile);
            Controls.Add(btnForLoop);
            Controls.Add(button1);
            Controls.Add(btnRandom);
            Controls.Add(btnDoWhile);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbxLoop);
            Controls.Add(txtData2);
            Controls.Add(txtData1);
            Controls.Add(btnWhileLoop);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnWhileLoop;
        private TextBox txtData1;
        private TextBox txtData2;
        private ListBox lbxLoop;
        private Label label1;
        private Label label2;
        private Button btnDoWhile;
        private Button btnRandom;
        private Button button1;
        private Button btnForLoop;
        private Button btnWritetofile;
        private Button btnAppendtext;
        private Button btnReadTextFromFile;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button btnOpenFile;
        private Button btnSaveFile;
        private Button btnForEach;
    }
}
