namespace ProcessesApp
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            activeProcessList = new ListBox();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(52, 12);
            button1.Name = "button1";
            button1.Size = new Size(699, 29);
            button1.TabIndex = 0;
            button1.Text = "Refresh list of processes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(52, 47);
            button2.Name = "button2";
            button2.Size = new Size(699, 29);
            button2.TabIndex = 1;
            button2.Text = "End process";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(52, 409);
            button3.Name = "button3";
            button3.Size = new Size(699, 29);
            button3.TabIndex = 2;
            button3.Text = "New process";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // activeProcessList
            // 
            activeProcessList.FormattingEnabled = true;
            activeProcessList.ItemHeight = 20;
            activeProcessList.Location = new Point(56, 111);
            activeProcessList.Name = "activeProcessList";
            activeProcessList.Size = new Size(695, 264);
            activeProcessList.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(342, 88);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 4;
            label1.Text = "Active processes";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(55, 381);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(696, 27);
            textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(activeProcessList);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Task Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox activeProcessList;
        private Label label1;
        private TextBox textBox1;
    }
}