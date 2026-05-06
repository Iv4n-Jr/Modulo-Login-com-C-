using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D; // Certifique-se de adicionar esta using

namespace pdj_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            {
                // Define a PictureBox como um círculo
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Region = new Region(path);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
