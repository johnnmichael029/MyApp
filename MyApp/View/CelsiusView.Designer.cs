namespace MyApp.View
{
    partial class CelsiusView
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
            BtnClear = new Button();
            label2 = new Label();
            BtnConvert = new Button();
            txtCelsius = new TextBox();
            DataGridViewConvert = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DataGridViewConvert).BeginInit();
            SuspendLayout();
            // 
            // BtnClear
            // 
            BtnClear.Location = new Point(617, 114);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(165, 30);
            BtnClear.TabIndex = 35;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(617, 12);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 34;
            label2.Text = "Celsius";
            // 
            // BtnConvert
            // 
            BtnConvert.Location = new Point(617, 78);
            BtnConvert.Name = "BtnConvert";
            BtnConvert.Size = new Size(165, 30);
            BtnConvert.TabIndex = 33;
            BtnConvert.Text = "Convert";
            BtnConvert.UseVisualStyleBackColor = true;
            BtnConvert.Click += BtnConvert_Click;
            // 
            // txtCelsius
            // 
            txtCelsius.Location = new Point(617, 29);
            txtCelsius.Multiline = true;
            txtCelsius.Name = "txtCelsius";
            txtCelsius.Size = new Size(165, 32);
            txtCelsius.TabIndex = 32;
            // 
            // DataGridViewConvert
            // 
            DataGridViewConvert.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewConvert.BackgroundColor = SystemColors.Control;
            DataGridViewConvert.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewConvert.Location = new Point(18, 12);
            DataGridViewConvert.Name = "DataGridViewConvert";
            DataGridViewConvert.Size = new Size(583, 426);
            DataGridViewConvert.TabIndex = 31;
            // 
            // CelsiusView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnClear);
            Controls.Add(label2);
            Controls.Add(BtnConvert);
            Controls.Add(txtCelsius);
            Controls.Add(DataGridViewConvert);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CelsiusView";
            Text = "CelsiusView";
            ((System.ComponentModel.ISupportInitialize)DataGridViewConvert).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnClear;
        private Label label2;
        private Button BtnConvert;
        private TextBox txtCelsius;
        private DataGridView DataGridViewConvert;
    }
}