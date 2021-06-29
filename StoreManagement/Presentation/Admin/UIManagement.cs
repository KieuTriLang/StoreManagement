using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.Presentation.Admin
{
    public partial class UIManagement : Form
    {
        private Guna2Button currentButton;
        private Form currentChildForm;
        public UIManagement()
        {
            InitializeComponent();
            timer1.Start();
            lbDate.Text = "Date: " + DateTime.Now.ToString("dd-MM-yyyy");
            lbTime.Text = "Time: " + DateTime.Now.ToString("HH:mm:ss");
            Form childForm = new UIAdmin();
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.BackColor = ChangeColorBrightness(Color.FromArgb(17, 29, 94),0.1);
            this.pnShow.Controls.Add(childForm);
            this.pnShow.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            pnTitle.BackColor = ChangeColorBrightness(Color.FromArgb(17, 29, 94), -0.3);
            lbTitle.Text = childForm.Text;
        }
        //Event
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            LoginForm.instance.Close();
            //this.Close();
        }
        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UIEmployees(), sender, RGBColors.color6);
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UIProducts(), sender, RGBColors.color2);
        }

        private void btnGroceries_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UICategories(), sender, RGBColors.color3);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UISettings(), sender, RGBColors.color4);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UIAdmin(), sender, Color.FromArgb(17, 29, 94));
        }

        //FUNCTION

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentButton = (Guna2Button)senderBtn;
                currentButton.FillColor = color;
                currentButton.ForeColor = Color.White;
                currentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //Left border button

                //Current Child Form Icon

            }
        }
        private void DisableButton()
        {
            foreach (Guna2Button previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Guna2Button) && previousBtn.Name != "guna2Button1") 
                {
                    previousBtn.FillColor = Color.FromArgb(17, 29, 94);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender,Color color)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            ActivateButton(btnSender,color);
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.BackColor = ChangeColorBrightness(Color.FromArgb(17, 29, 94), 0.1);
            this.pnShow.Controls.Add(childForm);
            this.pnShow.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            pnTitle.BackColor = ChangeColorBrightness(color, -0.3);
            lbTitle.Text = childForm.Text;
            
            //End

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = "Time: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm.instance.Show();
        }
    }
}
