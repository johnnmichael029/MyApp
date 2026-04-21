using MyApp.Controller;
using MyApp.Services;
using System;
using System.Windows.Forms;

namespace MyApp.View
{
    public partial class FahrenheitView : Form
    {
        public FahrenheitView()
        {
            InitializeComponent();
            txtFahrenheit.KeyPress += OnlyNumbers_KeyPress;
            this.Load += (s, e) => FetchRecords();
        }

        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) e.Handled = true;
        }

        private void BtnConvert_Click(object sender, EventArgs e)
        {

        }

        private void FetchRecords()
        {
            ConvertRecordsHelper db = new ConvertRecordsHelper();
            DataGridViewConvert.DataSource = db.GetAllRecords();
        }

        private void BtnConvert_Click_1(object sender, EventArgs e)
        {
            try
            {
                double f = double.Parse(txtFahrenheit.Text);
                ArithmeticController calc = new ArithmeticController();
                double c = calc.FahrenheitToCelsius(f);

                ConvertRecordsHelper db = new ConvertRecordsHelper();
                db.SaveConvertRecord(f, c);
                FetchRecords();

                MessageBox.Show($"Converted! {f}°F is {c:F2}°C", "Result");
                txtFahrenheit.Clear();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void BtnClear_Click_1(object sender, EventArgs e)
        { txtFahrenheit.Clear(); }
    }
}
