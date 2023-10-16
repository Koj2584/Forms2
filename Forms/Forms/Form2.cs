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
        Font font = new Font("Arial", 12);

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
                panel1.BackColor = colorDialog.Color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() == DialogResult.OK)
                label1.Font = fontDialog.Font;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new Form();
            f2.Width = w;
            f2.Height = h;
            f2.BackColor = color;
            
            Label l1 = new Label();
            Button ok = new Button();
            Button cancel = new Button();

            ok.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            ok.Location = new Point(w - 40, h - 60);
            ok.Size = new Size(35, 20);
            ok.Text = "Ok";

            cancel.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            cancel.Location = new Point(20, h - 60);
            cancel.Size = new Size(45, 20);
            cancel.Text = "Cancel";

            l1.AutoSize = false;
            //l1.Dock = DockStyle.Fill;
            l1.BackColor = Color.Transparent;
            l1.Text = "Abc";
            l1.TextAlign = ContentAlignment.MiddleCenter;


            f2.Controls.Add(l1);
            f2.Controls.Add(ok);
            f2.Controls.Add(cancel);

            f2.Show();
        }
    }
}
