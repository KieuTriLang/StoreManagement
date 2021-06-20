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

namespace StoreManagement.Presentation.Main.UISubOrder
{
    public partial class QuantityForm : Form
    {
        private int quantity_;

        public int Quantity
        {
            get
            {
                return quantity_;
            }
        }
        public QuantityForm(int quantity = 0)
        {
            InitializeComponent();
            if(quantity != 0)
            {
                tbQuantity.Text = quantity.ToString();
                quantity_ = quantity;
            }
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(Int32.TryParse(tbQuantity.Text.Trim(), out int quan))
            {
                quantity_ = Int32.Parse(tbQuantity.Text.Trim());
                this.Close();
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Quantity_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
