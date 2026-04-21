namespace MyApp
{
    partial class App
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
            dockPanel = new Panel();
            BtnCalculator = new Button();
            BtnConvertion = new Button();
            SuspendLayout();
            // 
            // dockPanel
            // 
            dockPanel.Location = new Point(229, 0);
            dockPanel.Name = "dockPanel";
            dockPanel.Size = new Size(848, 618);
            dockPanel.TabIndex = 0;
            // 
            // BtnCalculator
            // 
            BtnCalculator.Location = new Point(43, 62);
            BtnCalculator.Name = "BtnCalculator";
            BtnCalculator.Size = new Size(122, 50);
            BtnCalculator.TabIndex = 1;
            BtnCalculator.Text = "Calculator";
            BtnCalculator.UseVisualStyleBackColor = true;
            // 
            // BtnConvertion
            // 
            BtnConvertion.Location = new Point(43, 128);
            BtnConvertion.Name = "BtnConvertion";
            BtnConvertion.Size = new Size(122, 50);
            BtnConvertion.TabIndex = 2;
            BtnConvertion.Text = "Convert";
            BtnConvertion.UseVisualStyleBackColor = true;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 615);
            Controls.Add(BtnConvertion);
            Controls.Add(BtnCalculator);
            Controls.Add(dockPanel);
            Name = "App";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel dockPanel;
        private Button BtnCalculator;
        private Button BtnConvertion;
    }
}
