using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.Presentation.Admin
{
    public partial class UIAECategory : Form
    {
        public UIAECategory()
        {
            InitializeComponent();
            if (UICategories.instance.typeForm == 0)
            {
                btnTitle.Text = "Details";
                btnSave.Hide();
                btnCancel.Hide();
            }
            if (UICategories.instance.typeForm == 1)
            {
                btnTitle.Text = "Add";
                btnClose.Hide();
            }
            if (UICategories.instance.typeForm == 2)
            {
                btnTitle.Text = "Edit";
                btnClose.Hide();
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if(UICategories.instance.typeForm == 1 || UICategories.instance.typeForm == 2)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "PNG files | *.png*";
                dialog.Multiselect = false;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    String path = dialog.FileName;
                    btnUpload.Image = new Bitmap(path);
                    Console.WriteLine(path);
                }
            }
        }

        private void btnUpload_MouseEnter(object sender, EventArgs e)
        {
            if(UICategories.instance.typeForm == 1 || UICategories.instance.typeForm == 2)
            {
                btnUpload.BackColor = Color.FromArgb(143, 217, 168);
            }
            
        }

        private void btnUpload_MouseLeave(object sender, EventArgs e)
        {
            if (UICategories.instance.typeForm == 1 || UICategories.instance.typeForm == 2)
            {
                btnUpload.BackColor = Color.FromArgb(71, 100, 150);
            }
        }
    }
}
