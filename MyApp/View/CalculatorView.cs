using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyApp.View
{
    public partial class CalculatorView : Form
    {
        public CalculatorView()
        {
            InitializeComponent();

        }

        private void DockPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            loadForm(new AddView());
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            loadForm(new SubView());
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            loadForm(new MulView());
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            loadForm(new DivView());
        }

        private void CalculatorView_Load(object sender, EventArgs e)
        {

        }
        private void loadForm(Form form)
        {
            if (this.DockPanel.Controls.Count > 0)
                this.DockPanel.Controls.RemoveAt(0);
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;

            this.DockPanel.Controls.Add(form);
            this.DockPanel.Tag = form;
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
