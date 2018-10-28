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
    public partial class frmmain : Form
    {
        private int openDocuments = 0;
        public frmmain()
        {
            InitializeComponent();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {

        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Создаем новый экземпляр формы  frm
            blank frm = new blank();
            //Указываем, что родительским контейнером 
            //нового экземпляра будет эта, главная форма.
            frm.MdiParent = this;
            //Вызываем форму
            frm.Show();
        }
    }
}
