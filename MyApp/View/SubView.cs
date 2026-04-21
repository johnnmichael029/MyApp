using MyApp.Controller;
using MyApp.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace MyApp.View
{
    public partial class SubView : Form
    {
        public SubView()
        {
            InitializeComponent();
            textBox1.KeyPress += OnlyNumbers_KeyPress;
            textBox2.KeyPress += OnlyNumbers_KeyPress;
            this.Load += (s, e) => FetchAllRecords();
        }

        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = double.Parse(textBox1.Text);
                double n2 = double.Parse(textBox2.Text);
                ArithmeticController calc = new();
                double result = calc.Subtraction(n1, n2);

                CalculatorRecordsHelper db = new();
                db.SaveRecord(n1, n2, result);
                FetchAllRecords();

                MessageBox.Show($"Subtraction Success! Result: {result}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                textBox2.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void FetchAllRecords()
        {
            CalculatorRecordsHelper db = new();
            DataGridViewSub.DataSource = db.GetAllRecords();
        }
    }
}
