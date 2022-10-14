using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Project
{
    public partial class Form2 : Form
    {
        private Form1 _ParentForm;

        public Form2(Form1 parentForm)
        {
            InitializeComponent();
            _ParentForm = parentForm;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            StreamWriter Writer = new StreamWriter("main.txt", true);
            using (Writer)
            {
                if (MainTextBox.Text != "")
                {
                    Writer.WriteLine();
                    Writer.Write(MainTextBox.Text);
                    _ParentForm.AddPredictionToList(MainTextBox.Text);
                    MessageBox.Show("Попълненото от вас предсказание е вкарано успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Моля най-напред попълнете полето!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
