namespace EsercitaTowers
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
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(71, 80);
            button1.Name = "button1";
            button1.Size = new Size(117, 66);
            button1.TabIndex = 0;
            button1.Text = "Prelievo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(71, 175);
            button2.Name = "button2";
            button2.Size = new Size(117, 63);
            button2.TabIndex = 1;
            button2.Text = "Deposito";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(302, 236);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(574, 199);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Saldo:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(574, 226);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 5;
            label2.Text = "skibidi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(302, 204);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 6;
            label3.Text = "Denaro:";
            // 
            // button3
            // 
            button3.Location = new Point(302, 33);
            button3.Name = "button3";
            button3.Size = new Size(117, 62);
            button3.TabIndex = 7;
            button3.Text = "Bonifico";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(574, 262);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 8;
            label4.Text = "Saldo2:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(574, 291);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 9;
            label5.Text = "toilet";
            // 
            // button4
            // 
            button4.Location = new Point(71, 262);
            button4.Name = "button4";
            button4.Size = new Size(117, 55);
            button4.TabIndex = 10;
            button4.Text = "Prelievo2";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(71, 342);
            button5.Name = "button5";
            button5.Size = new Size(117, 63);
            button5.TabIndex = 11;
            button5.Text = "Deposito2";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(496, 33);
            button6.Name = "button6";
            button6.Size = new Size(117, 62);
            button6.TabIndex = 12;
            button6.Text = "Bonifico2";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button3;
        private Label label4;
        private Label label5;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
