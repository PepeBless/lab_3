using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_3
{
    public partial class blank : Form
    {
        public string DocName = "";
        public bool IsSaved = false;
        public blank()
        {
            InitializeComponent();
            //Свойству Text панели sbTime устанавливаем системное время, 
            // конвертировав его в тип String
            sbTime.Text = Convert.ToString(System.DateTime.Now.ToLongTimeString());
            //В тексте всплывающей подсказки  выводим текущую дату
            sbTime.ToolTipText = Convert.ToString(System.DateTime.Today.ToLongDateString());
        }

        private void blank_Load(object sender, EventArgs e)
        {

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void sellectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //Свойству Text панели sbAmount устанавливаем надпись "Аmount of symbols" 
            //и длину  текста в RichTextBox.
            sbAmount.Text = "Sym: " + richTextBox1.Text.Length.ToString();
        }

        private void blank_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Если переменная IsSaved имеет значение true, т. е.  новый документ 
            //был сохранен (Save As) или в открытом документе были сохранены изменения (Save), то //выполняется условие
            if (IsSaved == true)
            {
                //Появляется диалоговое окно, предлагающее сохранить документ.
                if (MessageBox.Show("Do you want save changes in " + this.DocName + "?",
                        "Message", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                //Если была нажата  кнопка Yes, вызываем метод Save
                {
                    this.Save(this.DocName);
                }
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sbAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
