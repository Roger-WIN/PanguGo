using System;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void button_chooseText_Click(object sender, EventArgs e)
        {
            Hide();
            var textForm = new TextForm();
            textForm.Show();
        }

        private void button_chooseFile_Click(object sender, EventArgs e)
        {
            Hide();
            var fileForm = new FileForm();
            fileForm.Show();
        }
    }
}
