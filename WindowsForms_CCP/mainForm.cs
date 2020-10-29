using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsForms_CCP
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void setTargetLocation()
        {
            int x = targetButton.Location.X;
            int y = targetButton.Location.Y;
            targetButton.Text = $"Target\nX = {x}\nY = {y}";
        }

        private void setFormLocation()
        {
            int x = this.Location.X;
            int y = this.Location.Y;
            this.Text = $"({x}, {y}) Winforms Components - Common Controls";
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            setTargetLocation();
            setFormLocation();
        }

        private void mainForm_Move(object sender, EventArgs e)
        {
            setFormLocation();
        }

        private void mainForm_Resize(object sender, EventArgs e)
        {
            int x = this.Width;
            int y = this.Height;

            formSizeLabel.Text = $"Form Size: {x}, {y}";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = comboBox1.SelectedIndex;
            switch (a)
            {
                case 0:
                    this.FormBorderStyle = FormBorderStyle.None;
                    break;
                case 1:
                    this.FormBorderStyle = FormBorderStyle.FixedSingle;
                    break;
                case 2:
                    this.FormBorderStyle = FormBorderStyle.Fixed3D;
                    break;
                case 3:
                    this.FormBorderStyle = FormBorderStyle.FixedDialog;
                    break;
                case 5:
                    this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                    break;
                case 6:
                    this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
                    break;
                default:
                    this.FormBorderStyle = FormBorderStyle.Sizable;
                    break;
            }
        }

        private void visibilityButton_Click(object sender, EventArgs e)
        {
            if(targetButton.Visible == true)
            {
                targetButton.Visible = false;
                visibilityButton.Text = "Visible = False";
            }
            else
            {
                targetButton.Visible = true;
                visibilityButton.Text = "Visible = True";
            }  
        }

        private void enableButton_Click(object sender, EventArgs e)
        {
            if (targetButton.Enabled == true)
            {
                targetButton.Enabled = false;
                enableButton.Text = "Enabled = False";
            }
            else
            {
                targetButton.Enabled = true;
                enableButton.Text = "Enabled = True";
            }
        }

        private void centerTargetButton_Click(object sender, EventArgs e)
        {
            int x = (this.Width) / 2;
            int y = (this.Height) / 2;

            targetButton.Location = new Point((x - 50),(y - 50));
        }

        private void targetButton_Click(object sender, EventArgs e)
        {
            
        }

        private void targetButton_Move(object sender, EventArgs e)
        {
            setTargetLocation();
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            int positionY = (targetButton.Location.Y) + 5;
            int positionX = (targetButton.Location.X);
            targetButton.Location = new Point(positionX, positionY);
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            int positionY = (targetButton.Location.Y);
            int positionX = (targetButton.Location.X) + 5;
            targetButton.Location = new Point(positionX, positionY);
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            int positionY = (targetButton.Location.Y) - 5;
            int positionX = (targetButton.Location.X);
            targetButton.Location = new Point(positionX, positionY);
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            int positionY = (targetButton.Location.Y);
            int positionX = (targetButton.Location.X) - 5;
            targetButton.Location = new Point(positionX, positionY);
        }
    }
}
