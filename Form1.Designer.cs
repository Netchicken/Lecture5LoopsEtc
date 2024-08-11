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
            lblWhileOutput = new Label();
            lbxLoop = new ListBox();
            label1 = new Label();
            label2 = new Label();
            btnDoWhile = new Button();
            SuspendLayout();
            // 
            // btnWhileLoop
            // 
            btnWhileLoop.Location = new Point(12, 24);
            btnWhileLoop.Name = "btnWhileLoop";
            btnWhileLoop.Size = new Size(75, 23);
            btnWhileLoop.TabIndex = 0;
            btnWhileLoop.Text = "While Loop";
            btnWhileLoop.UseVisualStyleBackColor = true;
            btnWhileLoop.Click += btnWhileLoop_Click;
            // 
            // txtData1
            // 
            txtData1.Location = new Point(118, 24);
            txtData1.Name = "txtData1";
            txtData1.Size = new Size(100, 23);
            txtData1.TabIndex = 1;
            // 
            // txtData2
            // 
            txtData2.Location = new Point(224, 23);
            txtData2.Name = "txtData2";
            txtData2.Size = new Size(100, 23);
            txtData2.TabIndex = 2;
            // 
            // lblWhileOutput
            // 
            lblWhileOutput.Location = new Point(123, 254);
            lblWhileOutput.Name = "lblWhileOutput";
            lblWhileOutput.Size = new Size(137, 28);
            lblWhileOutput.TabIndex = 3;
            lblWhileOutput.Text = "label1";
            // 
            // lbxLoop
            // 
            lbxLoop.FormattingEnabled = true;
            lbxLoop.ItemHeight = 15;
            lbxLoop.Location = new Point(118, 53);
            lbxLoop.Name = "lbxLoop";
            lbxLoop.Size = new Size(206, 154);
            lbxLoop.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 6);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Data 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 5);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 6;
            label2.Text = "Data 2";
            // 
            // btnDoWhile
            // 
            btnDoWhile.Location = new Point(12, 72);
            btnDoWhile.Name = "btnDoWhile";
            btnDoWhile.Size = new Size(76, 41);
            btnDoWhile.TabIndex = 7;
            btnDoWhile.Text = "Do While Loop";
            btnDoWhile.UseVisualStyleBackColor = true;
            btnDoWhile.Click += btnDoWhile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDoWhile);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbxLoop);
            Controls.Add(lblWhileOutput);
            Controls.Add(txtData2);
            Controls.Add(txtData1);
            Controls.Add(btnWhileLoop);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnWhileLoop;
        private TextBox txtData1;
        private TextBox txtData2;
        private Label lblWhileOutput;
        private ListBox lbxLoop;
        private Label label1;
        private Label label2;
        private Button btnDoWhile;
    }
}
