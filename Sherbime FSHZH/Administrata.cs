using Sherbime_IT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace Sherbime_FSHZH
{
    public partial class Administrata : Form
    {
        private string selectedEmail, selectedSubject, selectedBody,cc;
        private Dictionary<Button, bool> buttonClickedState = new Dictionary<Button, bool>();
        private Button[] allButtons; // Lista e të gjithë butonave
        public Administrata()
        {
            InitializeComponent();
            allButtons = new[] { button1, button2, button3 };
            InitializeButtons(allButtons);
        }
        private void InitializeButtons(Button[] buttons)
        {
            foreach (var btn in buttons)
            {
                buttonClickedState[btn] = false; // Gjendja fillestare: e pa klikuar
                btn.MouseEnter += button_MouseEnter;
                btn.MouseLeave += button_MouseLeave;
                btn.Click += button_Click;
                btn.BackColor = Color.SteelBlue;
            }
        }
        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.SteelBlue;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            // Ruaj ngjyrën e klikimit ose rikthe ngjyrën fillestare
            if (buttonClickedState.ContainsKey(btn) && buttonClickedState[btn])
            {
                btn.BackColor = Color.MediumSlateBlue; // Ruaj ngjyrën e klikimit
            }
            else
            {
                btn.BackColor = Color.SteelBlue; // Rikthe ngjyrën fillestare
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;


            // Rikthe të gjithë butonat në gjendjen fillestare
            foreach (var btn in allButtons)
            {
                if (btn == clickedButton) continue; // Mos ndrysho butonin e klikuar

                btn.BackColor = Color.SteelBlue; // Rikthe ngjyrën fillestare
                buttonClickedState[btn] = false;  // Rikthe gjendjen fillestare

            }

            // Përditëso gjendjen e butonit të klikuar

            clickedButton.BackColor = Color.LightBlue;
            buttonClickedState[clickedButton] = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            selectedEmail = "administrata@albaniandf.org";
            cc = null;
            selectedSubject = button2.Text;
            label5.Visible = true;
            HbxtextBox.Visible = true;
            Dergo.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            selectedEmail = "administrata@albaniandf.org";
            cc = null;
            selectedSubject = button3.Text;
            label5.Visible = true;
            HbxtextBox.Visible = true;
            Dergo.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this.MdiParent;
            form2.WindowState = FormWindowState.Maximized;
            form2.Size = new Size(800, 1700);   // Set width and height
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = new Point(0, 0);
            form2.Show();
            this.Close();
        }

        private void Dergo_Click(object sender, EventArgs e)
        {
            try
            {
                Outlook.Application outlookApp = new Outlook.Application();
                Outlook.MailItem mail = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);
                mail.To = selectedEmail;
                mail.Subject = selectedSubject;
                mail.Body = selectedBody;
                if (cc != null)
                {
                    mail.CC =cc;
                }
                mail.Send();
                MessageBox.Show("Përshëndetje! Ky email i dërgohet administratës së FSHZH dhe ju do të njoftoheni së shpejti për kërkesën tuaj.");
                HbxtextBox.Text = "";
                InitializeButtons(allButtons);
                Dergo.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show($"Ndodhi një gabim, ju lutem provoni përsëri më vonë");
            }
        }

        private void HbxtextBox_TextChanged(object sender, EventArgs e)
        {
            selectedBody = HbxtextBox.Text;
            Dergo.Visible = true;
        }

        private void Administrata_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectedEmail = "bselenica@albaniandf.org";
            cc = "lbardhi@albaniandf.org";
            selectedSubject = button1.Text;
            label5.Visible = true;
            HbxtextBox.Visible = true;
            Dergo.Visible = true;
        }
    }
}
