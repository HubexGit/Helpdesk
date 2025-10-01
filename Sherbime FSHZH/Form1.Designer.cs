using System.Drawing;
using System.Windows.Forms;
using System;

namespace Sherbime_FSHZH
{
    partial class Nderfaqe1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox HbxCombo;
        private System.Windows.Forms.ComboBox AmiCombo;
        private System.Windows.Forms.ComboBox AemCombo;
        private System.Windows.Forms.TextBox HbxtextBox;
        private System.Windows.Forms.Button Dergo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip; // Përdorimi i ToolTip
        private Panel leftPanel;
        private Panel rightPanel;  
        private ListBox serviceList;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Printim");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Pc-Hardware");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("PC-Software");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Email");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Internet");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Meetings");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Server");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Tjeter");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Sherbim IT", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nderfaqe1));
            this.label1 = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label9 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.HbxtextBox = new System.Windows.Forms.TextBox();
            this.Dergo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.serviceList = new System.Windows.Forms.ListBox();
            this.Develop = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.Develop.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(806, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kjo është hapësira juaj e shërbimeve IT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.SandyBrown;
            this.leftPanel.Controls.Add(this.button8);
            this.leftPanel.Controls.Add(this.button7);
            this.leftPanel.Controls.Add(this.button4);
            this.leftPanel.Controls.Add(this.button3);
            this.leftPanel.Controls.Add(this.button2);
            this.leftPanel.Controls.Add(this.button1);
            this.leftPanel.Controls.Add(this.label9);
            this.leftPanel.Controls.Add(this.button5);
            this.leftPanel.Controls.Add(this.button6);
            this.leftPanel.Location = new System.Drawing.Point(10, 43);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(199, 564);
            this.leftPanel.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.SandyBrown;
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeView1.ForeColor = System.Drawing.Color.DarkBlue;
            this.treeView1.Indent = 10;
            this.treeView1.ItemHeight = 25;
            this.treeView1.LineColor = System.Drawing.Color.Azure;
            this.treeView1.Location = new System.Drawing.Point(187, 84);
            this.treeView1.Name = "treeView1";
            treeNode1.BackColor = System.Drawing.Color.SandyBrown;
            treeNode1.ForeColor = System.Drawing.Color.DarkBlue;
            treeNode1.Name = "Printim";
            treeNode1.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode1.Text = "Printim";
            treeNode2.BackColor = System.Drawing.Color.SandyBrown;
            treeNode2.ForeColor = System.Drawing.Color.DarkBlue;
            treeNode2.Name = "PC-Hardware";
            treeNode2.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode2.Text = "Pc-Hardware";
            treeNode3.BackColor = System.Drawing.Color.SandyBrown;
            treeNode3.ForeColor = System.Drawing.Color.DarkBlue;
            treeNode3.Name = "PC-Software";
            treeNode3.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode3.Text = "PC-Software";
            treeNode4.BackColor = System.Drawing.Color.SandyBrown;
            treeNode4.ForeColor = System.Drawing.Color.DarkBlue;
            treeNode4.Name = "Email";
            treeNode4.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode4.Text = "Email";
            treeNode5.BackColor = System.Drawing.Color.SandyBrown;
            treeNode5.ForeColor = System.Drawing.Color.DarkBlue;
            treeNode5.Name = "Internet";
            treeNode5.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode5.Text = "Internet";
            treeNode6.BackColor = System.Drawing.Color.SandyBrown;
            treeNode6.ForeColor = System.Drawing.Color.DarkBlue;
            treeNode6.Name = "Meetings";
            treeNode6.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode6.Text = "Meetings";
            treeNode7.BackColor = System.Drawing.Color.SandyBrown;
            treeNode7.ForeColor = System.Drawing.Color.DarkBlue;
            treeNode7.Name = "Server";
            treeNode7.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode7.Text = "Server";
            treeNode8.BackColor = System.Drawing.Color.SandyBrown;
            treeNode8.ForeColor = System.Drawing.Color.DarkBlue;
            treeNode8.Name = "Tjeter";
            treeNode8.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode8.Text = "Tjeter";
            treeNode9.BackColor = System.Drawing.Color.SandyBrown;
            treeNode9.ForeColor = System.Drawing.Color.Indigo;
            treeNode9.Name = "Sherbim IT";
            treeNode9.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode9.Text = "Sherbim IT";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.treeView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.treeView1.Scrollable = false;
            this.treeView1.Size = new System.Drawing.Size(180, 346);
            this.treeView1.TabIndex = 4;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "*Zgjidhni kategorinë";
            // 
            // button5
            // 
            this.button5.BackColor = this.leftPanel.BackColor;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.DarkBlue;
            this.button5.Location = new System.Drawing.Point(7, 59);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(180, 50);
            this.button5.TabIndex = 2;
            this.button5.Text = "Printim";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button5.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button6
            // 
            this.button6.BackColor = this.leftPanel.BackColor;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.DarkBlue;
            this.button6.Location = new System.Drawing.Point(7, 115);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(180, 50);
            this.button6.TabIndex = 2;
            this.button6.Text = "Pc-Hardware";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            this.button6.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button6.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.PeachPuff;
            this.rightPanel.Controls.Add(this.treeView1);
            this.rightPanel.Controls.Add(this.label5);
            this.rightPanel.Controls.Add(this.HbxtextBox);
            this.rightPanel.Controls.Add(this.Dergo);
            this.rightPanel.Location = new System.Drawing.Point(230, 43);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(500, 564);
            this.rightPanel.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(121, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "* Përshkruani problemin tuaj";
            this.label5.Visible = false;
            // 
            // HbxtextBox
            // 
            this.HbxtextBox.BackColor = System.Drawing.Color.Linen;
            this.HbxtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HbxtextBox.Location = new System.Drawing.Point(50, 84);
            this.HbxtextBox.Multiline = true;
            this.HbxtextBox.Name = "HbxtextBox";
            this.HbxtextBox.Size = new System.Drawing.Size(400, 400);
            this.HbxtextBox.TabIndex = 1;
            this.HbxtextBox.Visible = false;
            this.HbxtextBox.TextChanged += new System.EventHandler(this.HbxtextBox_TextChanged);
            // 
            // Dergo
            // 
            this.Dergo.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Dergo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dergo.Font = new System.Drawing.Font("Arial", 10F);
            this.Dergo.ForeColor = System.Drawing.Color.White;
            this.Dergo.Location = new System.Drawing.Point(201, 495);
            this.Dergo.Name = "Dergo";
            this.Dergo.Size = new System.Drawing.Size(100, 40);
            this.Dergo.TabIndex = 2;
            this.Dergo.Text = "Dërgo";
            this.Dergo.UseVisualStyleBackColor = false;
            this.Dergo.Visible = false;
            this.Dergo.Click += new System.EventHandler(this.Dergo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "* Zgjidhni Kategorinë e Shërbimit";
            this.label4.Visible = false;
            // 
            // serviceList
            // 
            this.serviceList.Location = new System.Drawing.Point(0, 0);
            this.serviceList.Name = "serviceList";
            this.serviceList.Size = new System.Drawing.Size(120, 96);
            this.serviceList.TabIndex = 0;
            // 
            // Develop
            // 
            this.Develop.Controls.Add(this.linkLabel1);
            this.Develop.Location = new System.Drawing.Point(2, 613);
            this.Develop.Name = "Develop";
            this.Develop.Size = new System.Drawing.Size(188, 24);
            this.Develop.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.OrangeRed;
            this.linkLabel1.Location = new System.Drawing.Point(12, 6);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(142, 16);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Developed by HUBEX";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.OrangeRed;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = this.leftPanel.BackColor;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(7, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pc-Sotware";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = this.leftPanel.BackColor;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkBlue;
            this.button2.Location = new System.Drawing.Point(7, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "Email";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = this.leftPanel.BackColor;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkBlue;
            this.button3.Location = new System.Drawing.Point(7, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 50);
            this.button3.TabIndex = 6;
            this.button3.Text = "Internet";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = this.leftPanel.BackColor;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.DarkBlue;
            this.button4.Location = new System.Drawing.Point(7, 339);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 50);
            this.button4.TabIndex = 7;
            this.button4.Text = "Meetings";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = this.leftPanel.BackColor;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.DarkBlue;
            this.button7.Location = new System.Drawing.Point(7, 395);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(180, 50);
            this.button7.TabIndex = 8;
            this.button7.Text = "Server";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = this.leftPanel.BackColor;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.DarkBlue;
            this.button8.Location = new System.Drawing.Point(7, 451);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(180, 50);
            this.button8.TabIndex = 9;
            this.button8.Text = "Tjeter";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // Nderfaqe1
            // 
            this.ClientSize = new System.Drawing.Size(797, 634);
            this.Controls.Add(this.Develop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.rightPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Nderfaqe1";
            this.Text = "Shërbime IT HUBEX";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.Develop.ResumeLayout(false);
            this.Develop.PerformLayout();
            this.ResumeLayout(false);

        }

        private Panel Develop;
        private LinkLabel linkLabel1;
        private Label label5;
        private Label label4;
        private TreeView treeView1;
        private Label label9;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button8;
    }
}