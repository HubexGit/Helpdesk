using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using Outlook = Microsoft.Office.Interop.Outlook;
using Sherbime_IT;

namespace Sherbime_FSHZH
{
    public partial class IT : Form
    {
        private string selectedEmail, selectedSubject, selectedBody;
        private Dictionary<Button, bool> buttonClickedState = new Dictionary<Button, bool>();
        private Button[] allButtons; // Lista e të gjithë butonave
        public IT()
        {
            InitializeComponent();

            VendosLabelQendror();
            allButtons = new[] { button1, button2, button3,button4, button5, button6, button7, button8 };
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
            }
        }
        private void VendosLabelQendror()
        {
            this.label1.Location = new Point((this.ClientSize.Width - this.label1.Width) / 5, 20);

        }
        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.PeachPuff;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            // Ruaj ngjyrën e klikimit ose rikthe ngjyrën fillestare
            if (buttonClickedState.ContainsKey(btn) && buttonClickedState[btn])
            {
                btn.BackColor = Color.Coral; // Ruaj ngjyrën e klikimit
            }
            else
            {
                btn.BackColor = Color.CornflowerBlue; // Rikthe ngjyrën fillestare
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;


            // Rikthe të gjithë butonat në gjendjen fillestare
            foreach (var btn in allButtons)
            {
                if (btn == clickedButton) continue; // Mos ndrysho butonin e klikuar

                btn.BackColor = Color.CornflowerBlue; // Rikthe ngjyrën fillestare
                buttonClickedState[btn] = false;  // Rikthe gjendjen fillestare
                btn.Size = new Size(180, 50);     // Rikthe madhësinë fillestare (nëse e ke ndryshuar)
            }

            // Përditëso gjendjen e butonit të klikuar
            clickedButton.Size = new Size(clickedButton.Width - 5, clickedButton.Height - 5);
            clickedButton.BackColor = Color.LightGray;
            buttonClickedState[clickedButton] = true;
          
        }
        private void button_Leave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Size = new Size(btn.Width + 5, btn.Height + 5); // Kthejeni butonin në madhësinë e tij fillestare
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(panel1.ClientRectangle,
                Color.FromArgb(255, 105, 180), Color.FromArgb(255, 20, 147), 90F);
            e.Graphics.FillRectangle(brush, e.ClipRectangle);
        }

        private void button1_Click(object sender, EventArgs e)
        { //button5.BackColor = Color.LightCoral;
            selectedEmail = "support@hubex.a;";
            selectedSubject = button1.Text;
            label5.Visible = true;
            HbxtextBox.Visible = true;
            Dergo.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        { //button5.BackColor = Color.LightCoral;
            selectedEmail = "support@hubex.a;";
            selectedSubject = button2.Text;
            label5.Visible = true;
            HbxtextBox.Visible = true;
            Dergo.Visible = true;

        }
        private void button3_Click(object sender, EventArgs e)
        { //button5.BackColor = Color.LightCoral;
            selectedEmail = "support@hubex.a;";
            selectedSubject = button3.Text;
            label5.Visible = true;
            HbxtextBox.Visible = true;
            Dergo.Visible = true;

        }
        private void button4_Click(object sender, EventArgs e)
        { //button5.BackColor = Color.LightCoral;
            selectedEmail = "support@hubex.a;";
            selectedSubject = button4.Text;
            label5.Visible = true;
            HbxtextBox.Visible = true;
            Dergo.Visible = true;
        }
        private void button5_Click(object sender, EventArgs e)
        { //button5.BackColor = Color.LightCoral;
            selectedEmail = "support@hubex.a;";
            selectedSubject = button5.Text;
            label5.Visible = true;
            HbxtextBox.Visible = true;
            Dergo.Visible = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {   //button6.BackColor = Color.LightCoral;
            selectedEmail = "support@hubex.a;";
            selectedSubject = button6.Text;
            label5.Visible = true;
            HbxtextBox.Visible = true;
            Dergo.Visible = true;
        }
        private void button7_Click(object sender, EventArgs e)
        {   //button6.BackColor = Color.LightCoral;
            selectedEmail = "support@hubex.a;";
            selectedSubject = button7.Text;
            label5.Visible = true;
            HbxtextBox.Visible = true;
            Dergo.Visible = true;
        }
        private void button8_Click(object sender, EventArgs e)
        {   //button6.BackColor = Color.LightCoral;
            selectedEmail = "support@hubex.a;";
            selectedSubject = button8.Text;
            label5.Visible = true;
            HbxtextBox.Visible = true;
            Dergo.Visible = true;
        }


        private void HbxtextBox_TextChanged(object sender, EventArgs e)
        {
            selectedBody = HbxtextBox.Text;
            Dergo.Visible = true;
        }

        //private void label9_Click(object sender, EventArgs e)
        //{


        //}

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





        // Funksion për dërgimin e emailit
        private void Dergo_Click(object sender, EventArgs e)
        {
            try
            {
                Outlook.Application outlookApp = new Outlook.Application();
                Outlook.MailItem mail = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);
                mail.To = selectedEmail;
                mail.CC = "evasili@albaniandf.org";
                mail.Subject = selectedSubject;
                mail.Body = selectedBody;
                mail.Send();
                MessageBox.Show("Përshëndetje! Ky email i dërgohet suportit të Hubex-it dhe ju do të njoftoheni së shpejti për kërkesën tuaj.");
                HbxtextBox.Text = "";
                Dergo.Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show($"Ndodhi një gabim, ju lutem provoni përsëri më vonë");
            }
        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // URL që do të hapet kur klikohet
            string url = "https://hubex.al";

            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch
            {
                MessageBox.Show("Nuk mund të hapet lidhja.");
            }
        }
    }



}

