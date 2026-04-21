using MyApp.Controller; // Add this using
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MyApp.Services; // Add this using for DatabaseHelper

namespace MyApp.View
{
    public partial class AddView : Form
    {
        public AddView()
        {
            InitializeComponent();
            txtNum1.KeyPress += OnlyNumbers_KeyPress;
            txtNum2.KeyPress += OnlyNumbers_KeyPress;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 1. Allow numbers (0-9) and Control keys (like Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Blocks the key
            }
            // 2. Only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true; // Blocks the second decimal point
            }
        }

        private void ClearInputs()
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Get input
                double n1 = double.Parse(txtNum1.Text);
                double n2 = double.Parse(txtNum2.Text);
                // 2. Call the Controller
                ArithmeticController calc = new();
                double result = calc.Addition(n1, n2);
                // 3. Show the result

                CalculatorRecordsHelper db = new();
                db.SaveRecord(n1, n2, result);
                FetchAllRecords();

                MessageBox.Show($"Addition Success! The result is: {result}", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
            catch (Exception ex)
            {
                if (txtNum1.Text == "" || txtNum2.Text == "")
                {
                    MessageBox.Show("Please enter valid numbers in both fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void DataGridViewAdd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddView_Load(object sender, EventArgs e)
        {
            FetchAllRecords();
        }

        private void FetchAllRecords ()
        {
            CalculatorRecordsHelper db = new();
            DataGridViewAdd.DataSource = db.GetAllRecords();
        }
    }
}
