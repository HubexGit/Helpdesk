using Sherbime_FSHZH;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sherbime_IT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IT form1 = new IT();
            form1.MdiParent = this.MdiParent;
            form1.WindowState = FormWindowState.Maximized;
            form1.Size = new Size(800, 1700);   // Set width and height
            form1.StartPosition = FormStartPosition.Manual;
            form1.Location = new Point(0, 0);
            form1.Show();
            this.Close();
        }

        private void godina_Click(object sender, EventArgs e)
        {
            Godina form2 = new Godina();
            form2.MdiParent = this.MdiParent;
            form2.WindowState = FormWindowState.Maximized;
            form2.Size = new Size(800, 1700);   // Set width and height
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = new Point(0, 0);
            form2.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Administrata form3 = new Administrata();
            form3.MdiParent = this.MdiParent;
            form3.WindowState = FormWindowState.Maximized;
            form3.Size = new Size(800, 1700);   // Set width and height
            form3.StartPosition = FormStartPosition.Manual;
            form3.Location = new Point(0, 0);
            form3.Show();
            this.Close();
        }
    }
}
