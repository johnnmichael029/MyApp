namespace MyApp.View
{
    partial class AddView
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
            BtnAdd = new Button();
            txtNum2 = new TextBox();
            txtNum1 = new TextBox();
            DataGridViewAdd = new DataGridView();
            BtnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGridViewAdd).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(621, 12);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 17;
            label2.Text = "Enter num1: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(621, 79);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 16;
            label1.Text = "Enter num2: ";
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(621, 162);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(165, 30);
            BtnAdd.TabIndex = 15;
            BtnAdd.Text = "Add";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(621, 97);
            txtNum2.Multiline = true;
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(165, 32);
            txtNum2.TabIndex = 14;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(621, 29);
            txtNum1.Multiline = true;
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(165, 32);
            txtNum1.TabIndex = 13;
            // 
            // DataGridViewAdd
            // 
            DataGridViewAdd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewAdd.BackgroundColor = SystemColors.Control;
            DataGridViewAdd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewAdd.Location = new Point(15, 12);
            DataGridViewAdd.Name = "DataGridViewAdd";
            DataGridViewAdd.Size = new Size(583, 426);
            DataGridViewAdd.TabIndex = 12;
            DataGridViewAdd.CellContentClick += DataGridViewAdd_CellContentClick;
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(621, 198);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(165, 30);
            BtnClear.TabIndex = 18;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // AddView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnClear);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnAdd);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(DataGridViewAdd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddView";
            Text = "AddView";
            Load += AddView_Load;
            ((System.ComponentModel.ISupportInitialize)DataGridViewAdd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button BtnAdd;
        private TextBox txtNum2;
        private TextBox txtNum1;
        private DataGridView DataGridViewAdd;
        private Button BtnClear;
    }
}