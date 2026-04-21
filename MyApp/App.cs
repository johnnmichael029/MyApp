using MyApp.Services;
using MyApp.View; // Add this to see your Calculator and Convert views

namespace MyApp
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();

            // Hook up the button clicks
            BtnCalculator.Click += BtnCalculator_Click;
            BtnConvertion.Click += BtnConvertion_Click;

            // Optional: Test connection
            DatabaseHelper db = new();
            db.TestConnection();
        }

        private void loadForm(Form form)
        {
            if (this.dockPanel.Controls.Count > 0)
                this.dockPanel.Controls.RemoveAt(0);
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;

            this.dockPanel.Controls.Add(form);
            this.dockPanel.Tag = form;
            form.Show();
        }

        private void BtnCalculator_Click(object sender, EventArgs e)
        {
            loadForm(new CalculatorView());
        }

        private void BtnConvertion_Click(object sender, EventArgs e)
        {
            loadForm(new ConvertView());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
