using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagement.Presentation.Admin
{
    public partial class UIAdmin : Form
    {
        public UIAdmin()
        {
            InitializeComponent();
        }

        private void UIAdmin_Load(object sender, EventArgs e)
        {
            dgvPerDay.Rows.Add(new Object[] { 100, 200, 435, 652, 523, 871, 1243 });
        }
    }
}
