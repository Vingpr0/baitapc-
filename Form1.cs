using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace maytinhbotui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                mot.BackColor = colorDialog1.Color;
                hai.BackColor = colorDialog1.Color;
                ba.BackColor = colorDialog1.Color;
                bon.BackColor = colorDialog1.Color;
                nam.BackColor = colorDialog1.Color;
                sau.BackColor = colorDialog1.Color;
                bay.BackColor = colorDialog1.Color;
                tam.BackColor = colorDialog1.Color;
                chin.BackColor = colorDialog1.Color;
                khong.BackColor = colorDialog1.Color;
                cong.BackColor = colorDialog1.Color;
                tru.BackColor = colorDialog1.Color;
                nhan.BackColor = colorDialog1.Color;
                chia.BackColor = colorDialog1.Color;
                clear.BackColor = colorDialog1.Color;
                bang.BackColor = colorDialog1.Color;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog()== DialogResult.OK)
            {
                mot.Font = fontDialog1.Font;
                hai.Font = fontDialog1.Font;
                ba.Font = fontDialog1.Font;
                bon.Font = fontDialog1.Font;
                nam.Font = fontDialog1.Font;
                sau.Font = fontDialog1.Font;
                bay.Font = fontDialog1.Font;
                tam.Font = fontDialog1.Font;
                chin.Font = fontDialog1.Font;
                khong.Font = fontDialog1.Font;
                cong.Font = fontDialog1.Font;
                tru.Font = fontDialog1.Font;
                nhan.Font = fontDialog1.Font;
                chia.Font = fontDialog1.Font;
                clear.Font = fontDialog1.Font;
                bang.Font = fontDialog1.Font;
            }    
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mot_Click(object sender, EventArgs e)
        {
            txtPhepToan.Text += mot.Text;
        }

        private void hai_Click(object sender, EventArgs e)
        {
            txtPhepToan.Text += mot.Text;
        }

        private void ba_Click(object sender, EventArgs e)
        {
            txtPhepToan.Text += mot.Text;
        }

        private void bon_Click(object sender, EventArgs e)
        {
            txtPhepToan.Text += mot.Text;
        }

        private void nam_Click(object sender, EventArgs e)
        {
            txtPhepToan.Text += mot.Text;
        }

        private void sau_Click(object sender, EventArgs e)
        {
            txtPhepToan.Text += mot.Text;
        }

        private void bay_Click(object sender, EventArgs e)
        {
            txtPhepToan.Text += mot.Text;
        }

        private void tam_Click(object sender, EventArgs e)
        {
            txtPhepToan.Text += mot.Text;
        }

        private void chin_Click(object sender, EventArgs e)
        {
            txtPhepToan.Text += mot.Text;
        }

        private void khong_Click(object sender, EventArgs e)
        {
            txtPhepToan.Text += mot.Text;
        }
    }
}
