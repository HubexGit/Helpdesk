namespace Sherbime_IT
{
    partial class Godina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HbxtextBox = new System.Windows.Forms.TextBox();
            this.Kthehu = new System.Windows.Forms.Button();
            this.Dergo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HbxtextBox
            // 
            this.HbxtextBox.Location = new System.Drawing.Point(17, 22);
            this.HbxtextBox.Multiline = true;
            this.HbxtextBox.Name = "HbxtextBox";
            this.HbxtextBox.Size = new System.Drawing.Size(633, 286);
            this.HbxtextBox.TabIndex = 2;
            this.HbxtextBox.Visible = false;
            this.HbxtextBox.TextChanged += new System.EventHandler(this.HbxtextBox_TextChanged);
            // 
            // Kthehu
            // 
            this.Kthehu.BackColor = System.Drawing.Color.Red;
            this.Kthehu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kthehu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Kthehu.Image = global::Sherbime_FSHZH.Properties.Resources.back_icon;
            this.Kthehu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Kthehu.Location = new System.Drawing.Point(30, 369);
            this.Kthehu.Name = "Kthehu";
            this.Kthehu.Size = new System.Drawing.Size(248, 42);
            this.Kthehu.TabIndex = 4;
            this.Kthehu.Text = "Kthehu";
            this.Kthehu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Kthehu.UseVisualStyleBackColor = false;
            this.Kthehu.Click += new System.EventHandler(this.Kthehu_Click);
            // 
            // Dergo
            // 
            this.Dergo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.Dergo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dergo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Dergo.Image = global::Sherbime_FSHZH.Properties.Resources.send_icon;
            this.Dergo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dergo.Location = new System.Drawing.Point(460, 369);
            this.Dergo.Name = "Dergo";
            this.Dergo.Size = new System.Drawing.Size(203, 42);
            this.Dergo.TabIndex = 3;
            this.Dergo.Text = "Dergo";
            this.Dergo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Dergo.UseVisualStyleBackColor = false;
            this.Dergo.Visible = false;
            this.Dergo.Click += new System.EventHandler(this.Dergo_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Coral;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::Sherbime_FSHZH.Properties.Resources.clean_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(10, 55);
            this.button2.Margin = new System.Windows.Forms.Padding(10, 16, 3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = "Pastrim";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PeachPuff;
            this.panel1.Controls.Add(this.HbxtextBox);
            this.panel1.Controls.Add(this.Kthehu);
            this.panel1.Controls.Add(this.Dergo);
            this.panel1.Location = new System.Drawing.Point(337, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 432);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.PeachPuff;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(button1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(32, 64);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(281, 507);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(20, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Zgjidhni kategorinë";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::Sherbime_FSHZH.Properties.Resources.maintain_icon__2_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(10, 135);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 16, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mirëmbajtje godine";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(52, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(906, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kjo është hapësira juaj e shërbimeve të pastrimit && mirëmbajtjes së godinës.";
            // 
            // Godina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 763);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Godina";
            this.Text = "Godina";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox HbxtextBox;
        private System.Windows.Forms.Button Dergo;
        private System.Windows.Forms.Button Kthehu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}