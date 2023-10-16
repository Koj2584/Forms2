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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new Form();
            TextBox tb = new TextBox();
            Button btn = new Button();
            Button btn2 = new Button();

            tb.Location = new Point(10, 30);
            tb.Size = new Size(100, 35);
            tb.Text = "Vložte text";
            tb.Multiline = true;


            btn.Location = new Point(70, 70);
            btn.Text = "OK";
            btn.UseVisualStyleBackColor = true;
            btn.Size = new Size(50, 20);
            btn.DialogResult = DialogResult.OK;

            btn2.Location = new Point(10, 70);
            btn2.Text = "Cencel";
            btn2.UseVisualStyleBackColor = false;
            btn2.Size = new Size(50, 20);
            btn2.DialogResult = DialogResult.Cancel;


            f2.Controls.Add(tb);
            f2.Controls.Add(btn);
            f2.Controls.Add(btn2);

            if(f2.ShowDialog() == DialogResult.OK)
            {
                label1.Text = tb.Text;
            }
        }
    }
}
