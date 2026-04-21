namespace MyApp.View
{
    partial class CalculatorView
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
            BtnAdd = new Button();
            label1 = new Label();
            BtnSub = new Button();
            BtnMul = new Button();
            BtnDiv = new Button();
            DockPanel = new Panel();
            SuspendLayout();
            // 
            // BtnAdd
            // 
            BtnAdd.Location = new Point(81, 55);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(93, 37);
            BtnAdd.TabIndex = 0;
            BtnAdd.Text = "Addition";
            BtnAdd.UseVisualStyleBackColor = true;
            BtnAdd.Click += BtnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(378, 33);
            label1.TabIndex = 1;
            label1.Text = "Basic Arithmetic Operation";
            // 
            // BtnSub
            // 
            BtnSub.Location = new Point(248, 55);
            BtnSub.Name = "BtnSub";
            BtnSub.Size = new Size(93, 37);
            BtnSub.TabIndex = 2;
            BtnSub.Text = "Substruction";
            BtnSub.UseVisualStyleBackColor = true;
            BtnSub.Click += BtnSub_Click;
            // 
            // BtnMul
            // 
            BtnMul.Location = new Point(414, 55);
            BtnMul.Name = "BtnMul";
            BtnMul.Size = new Size(93, 37);
            BtnMul.TabIndex = 3;
            BtnMul.Text = "Multiplication";
            BtnMul.UseVisualStyleBackColor = true;
            BtnMul.Click += BtnMul_Click;
            // 
            // BtnDiv
            // 
            BtnDiv.Location = new Point(583, 55);
            BtnDiv.Name = "BtnDiv";
            BtnDiv.Size = new Size(93, 37);
            BtnDiv.TabIndex = 4;
            BtnDiv.Text = "Division";
            BtnDiv.UseVisualStyleBackColor = true;
            BtnDiv.Click += BtnDiv_Click;
            // 
            // DockPanel
            // 
            DockPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DockPanel.Location = new Point(1, 98);
            DockPanel.Name = "DockPanel";
            DockPanel.Size = new Size(799, 353);
            DockPanel.TabIndex = 5;
            DockPanel.Paint += DockPanel_Paint;
            // 
            // CalculatorView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(DockPanel);
            Controls.Add(BtnDiv);
            Controls.Add(BtnMul);
            Controls.Add(BtnSub);
            Controls.Add(label1);
            Controls.Add(BtnAdd);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CalculatorView";
            Text = "CalculatorView";
            Load += CalculatorView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAdd;
        private Label label1;
        private Button BtnSub;
        private Button BtnMul;
        private Button BtnDiv;
        private Panel DockPanel;
    }
}