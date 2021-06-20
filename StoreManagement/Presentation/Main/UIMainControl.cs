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

namespace StoreManagement.Presentation.Main
{
    public partial class UIMainControl : Form
    {
        private Guna2Button currentButton;
        private Form currentChildForm;
        public UIMainControl()
        {
            InitializeComponent();
            timer1.Start();
            lbDate.Text = "Date: " + DateTime.Now.ToString("dd-MM-yyyy");
            lbTime.Text = "Time: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            LoginForm.instance.Close();
            //this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = "Time: " + DateTime.Now.ToString("HH:mm:ss");
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(110, 117, 130);
            public static Color color5 = Color.FromArgb(60, 141, 173);
            public static Color color6 = Color.FromArgb(173, 108, 128);
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
                currentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                //Left border button

                //Current Child Form Icon

            }
        }
        private void DisableButton()
        {
            foreach (Guna2Button previousBtn in pnButton.Controls)
            {
                if (previousBtn.GetType() == typeof(Guna2Button))
                {
                    previousBtn.FillColor = Color.FromArgb(243, 145, 137);
                    previousBtn.ForeColor = Color.White;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender, Color color)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            ActivateButton(btnSender, color);
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.BackColor = ChangeColorBrightness(color, 0);
            this.pnView.Controls.Add(childForm);
            this.pnView.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            panel1.BackColor = ChangeColorBrightness(color, -0.3);

            //End

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                DisableButton();
                panel1.BackColor = ChangeColorBrightness(Color.FromArgb(243, 145, 137), 0);
                pnView.BackColor = ChangeColorBrightness(Color.FromArgb(238, 153, 160), 0);
            }
        }

        private void btnUITable_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UITableControl(), sender, RGBColors.color6);
        }

        private void btnUIOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UIOrderControl(), sender, RGBColors.color4);
        }

        private void btnUIHistory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UIHistoryControl(), sender, RGBColors.color5);
        }
    }
}
