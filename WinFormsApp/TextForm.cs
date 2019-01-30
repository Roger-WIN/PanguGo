using System;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class TextForm : Form
    {
        private static readonly PanguService service = new PanguService();

        public TextForm()
        {
            InitializeComponent();
        }

        private void label_ToFile_Click(object sender, EventArgs e)
        {
            Hide();
            var fileForm = new FileForm();
            fileForm.Show();
        }

        private void button_empty_Click(object sender, EventArgs e)
        {
            textBox_Preconvert.Clear();
            textBox_Postconvert.Clear();
        }

        private void button_convert_Click(object sender, EventArgs e)
        {
            try
            {
                var text_preconvert = textBox_Preconvert.Text;
                var text_postconvert = service.SpacingText(text_preconvert);
                textBox_Postconvert.Text = !text_postconvert.Contains(Environment.NewLine) ? text_postconvert.Replace("\n", Environment.NewLine) : text_postconvert; // 将 LF 替换为 CRLF

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            service.ClearFiles();
            Application.Exit();
        }
    }
}