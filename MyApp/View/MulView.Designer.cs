namespace MyApp.View
{
    partial class MulView
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
            label2 = new Label();
            label1 = new Label();
            BtnMul = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            DataGridViewMul = new DataGridView();
            BtnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewMul).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(621, 12);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 11;
            label2.Text = "Enter num1: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(621, 79);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 10;
            label1.Text = "Enter num2: ";
            // 
            // BtnMul
            // 
            BtnMul.Location = new Point(621, 162);
            BtnMul.Name = "BtnMul";
            BtnMul.Size = new Size(165, 30);
            BtnMul.TabIndex = 9;
            BtnMul.Text = "Multiply";
            BtnMul.UseVisualStyleBackColor = true;
            BtnMul.Click += BtnMul_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(621, 97);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 32);
            textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(621, 29);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 32);
            textBox1.TabIndex = 7;
            // 
            // DataGridViewMul
            // 
            DataGridViewMul.BackgroundColor = SystemColors.Control;
            DataGridViewMul.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewMul.Location = new Point(15, 12);
            DataGridViewMul.Name = "DataGridViewMul";
            DataGridViewMul.Size = new Size(583, 426);
            DataGridViewMul.TabIndex = 6;
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(621, 198);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(165, 30);
            BtnClear.TabIndex = 19;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // MulView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnClear);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnMul);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(DataGridViewMul);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MulView";
            Text = "MulView";
            ((System.ComponentModel.ISupportInitialize)DataGridViewMul).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button BtnMul;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView DataGridViewMul;
        private Button BtnClear;
    }
}