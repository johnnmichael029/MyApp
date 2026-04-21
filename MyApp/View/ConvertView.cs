using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyApp.View
{
    public partial class ConvertView : Form
    {
        public ConvertView()
        {
            InitializeComponent();
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

        private void BtnFah_Click(object sender, EventArgs e)
        {
            loadForm(new FahrenheitView());
        }

        private void BtnCel_Click(object sender, EventArgs e)
        {
            loadForm(new CelsiusView());
        }
    }
}
