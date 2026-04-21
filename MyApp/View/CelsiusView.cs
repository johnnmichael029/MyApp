using MyApp.Controller;
using MyApp.Services;
using System;
using System.Windows.Forms;

namespace MyApp.View
{
    public partial class CelsiusView : Form
    {
        public CelsiusView()
        {
            InitializeComponent();
            txtCelsius.KeyPress += OnlyNumbers_KeyPress;
            this.Load += (s, e) => FetchRecords();
        }

        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) e.Handled = true;
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                double c = double.Parse(txtCelsius.Text);
                ArithmeticController calc = new ArithmeticController();
                double f = calc.CelsiusToFahrenheit(c);

                ConvertRecordsHelper db = new ConvertRecordsHelper();
                db.SaveConvertRecord(f, c);
                FetchRecords();

                MessageBox.Show($"Converted! {c}°C is {f:F2}°F", "Result");
                txtCelsius.Clear();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnClear_Click(object sender, EventArgs e) { txtCelsius.Clear(); }

        private void FetchRecords()
        {
            ConvertRecordsHelper db = new ConvertRecordsHelper();
            DataGridViewConvert.DataSource = db.GetAllRecords();
        }
    }
}
