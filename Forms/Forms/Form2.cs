using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int w = 200, h = 200;
        Color color = Color.White;
        Font font = null;
        bool nemenit = false;

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = colorDialog.Color;
                color = colorDialog.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                label1.Font = fontDialog.Font;
                font = fontDialog.Font;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value*25 + " px";
            w = trackBar1.Value * 25;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBar2.Value * 25 + " px";
            h = trackBar2.Value * 25;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            nemenit = checkBox1.Checked;
        }

        Form f2;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            f2 = new Form();
            f2.Width = w;
            f2.Height = h;
            f2.BackColor = color;
            f2.ControlBox = false;
            f2.StartPosition = FormStartPosition.CenterScreen;
            if(nemenit)
                f2.FormBorderStyle = FormBorderStyle.FixedSingle;
            else
                f2.FormBorderStyle = FormBorderStyle.Sizable;
            
            Label l1 = new Label();
            Button ok = new Button();
            Button cancel = new Button();

            ok.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            ok.Location = new Point(w - 80, h - 60);
            ok.Size = new Size(50, 20);
            ok.Text = "Konec";
            ok.Click += Ok_Click;

            cancel.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            cancel.Location = new Point(20, h - 60);
            cancel.Size = new Size(45, 20);
            cancel.Text = "Zpět";
            cancel.Click += Cancel_Click;

            l1.AutoSize = false;
            l1.Anchor = AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left;
            l1.Location = new Point(0,0);
            l1.Size = new Size(w, h-60);
            
            l1.BackColor = Color.Transparent;
            l1.Font = font;
            l1.Text = "Abc";
            l1.TextAlign = ContentAlignment.MiddleCenter;


            f2.Controls.Add(l1);
            f2.Controls.Add(ok);
            f2.Controls.Add(cancel);

            f2.Show();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            f2.Close();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
