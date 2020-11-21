using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reflector_Keygen
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {

        }
        private bool mouseDown;
        private Point lastLocation;
        private void About_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void About_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void About_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
    
            Clipboard.SetText("https://www.youtube.com/channel/UC8i5I_JDQ3rFllSbez7iN-w?view_as=subscriber");
            MessageBox.Show("Succesfully Copied to clipboard", "Succes");
        }
    }
}
