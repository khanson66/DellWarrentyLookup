using System;
using System.Windows.Forms;

namespace DellWarrenty
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.clientID != null)
            {
                textBox1.Text = Properties.Settings.Default.clientID.ToString();
            }
            if (Properties.Settings.Default.clientSecret != null)
            {
                textBox2.Text = Properties.Settings.Default.clientSecret.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.clientID = textBox1.Text;
            Properties.Settings.Default.clientSecret = textBox2.Text;

            Properties.Settings.Default.Save();
            Properties.Settings.Default.Upgrade();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
