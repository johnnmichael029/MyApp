namespace MyApp.View
{
    partial class ConvertView
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
            DockPanel = new Panel();
            BtnCel = new Button();
            label1 = new Label();
            BtnFah = new Button();
            SuspendLayout();
            // 
            // DockPanel
            // 
            DockPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DockPanel.Location = new Point(1, 93);
            DockPanel.Name = "DockPanel";
            DockPanel.Size = new Size(799, 353);
            DockPanel.TabIndex = 11;
            // 
            // BtnCel
            // 
            BtnCel.Location = new Point(436, 50);
            BtnCel.Name = "BtnCel";
            BtnCel.Size = new Size(93, 37);
            BtnCel.TabIndex = 8;
            BtnCel.Text = "Celsius";
            BtnCel.UseVisualStyleBackColor = true;
            BtnCel.Click += BtnCel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(415, 33);
            label1.TabIndex = 7;
            label1.Text = "Convert Fahrenheit to Celsius";
            // 
            // BtnFah
            // 
            BtnFah.Location = new Point(269, 50);
            BtnFah.Name = "BtnFah";
            BtnFah.Size = new Size(93, 37);
            BtnFah.TabIndex = 6;
            BtnFah.Text = "Fahrenheit";
            BtnFah.UseVisualStyleBackColor = true;
            BtnFah.Click += BtnFah_Click;
            // 
            // ConvertView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(DockPanel);
            Controls.Add(BtnCel);
            Controls.Add(label1);
            Controls.Add(BtnFah);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConvertView";
            Text = "ConvertView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel DockPanel;
        private Button BtnCel;
        private Label label1;
        private Button BtnFah;
    }
}