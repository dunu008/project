using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_App
{
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlIndicator.Height = btnDashboard.Height;
            pnlIndicator.Top = btnDashboard.Top;
            pnlDashboard.Visible = true;
            pnlPOS.Visible = false;
            pnlSuppliers.Visible = false;
            pnlLoyalty.Visible = false;
            pnlStocks.Visible = false;
            pnlFinancial.Visible = false;
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            pnlIndicator.Height = btnPOS.Height;
            pnlIndicator.Top = btnPOS.Top;
            pnlPOS.Visible = true;
            pnlDashboard.Visible = false;
            pnlSuppliers.Visible = false;
            pnlLoyalty.Visible = false;
            pnlStocks.Visible = false;
            pnlFinancial.Visible = false;
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            pnlIndicator.Height = btnSuppliers.Height;
            pnlIndicator.Top = btnSuppliers.Top;
            pnlSuppliers.Visible = true;
            pnlPOS.Visible = false;
            pnlDashboard.Visible = false;
            pnlLoyalty.Visible = false;
            pnlStocks.Visible = false;
            pnlFinancial.Visible = false;
        }

        private void btnLoyalty_Click(object sender, EventArgs e)
        {
            pnlIndicator.Height = btnLoyalty.Height;
            pnlIndicator.Top = btnLoyalty.Top;
            pnlLoyalty.Visible = true;
            pnlSuppliers.Visible = false;
            pnlPOS.Visible = false;
            pnlDashboard.Visible = false;
            pnlStocks.Visible = false;
            pnlFinancial.Visible = false;
        }
        private void btnStocs_Click(object sender, EventArgs e)
        {
            pnlIndicator.Height = btnStocs.Height;
            pnlIndicator.Top = btnStocs.Top;
            pnlStocks.Visible = true;
            pnlLoyalty.Visible = false;
            pnlSuppliers.Visible = false;
            pnlPOS.Visible = false;
            pnlDashboard.Visible = false;
            pnlFinancial.Visible = false;
        }
        private void btnFinancial_Click(object sender, EventArgs e)
        {
            pnlIndicator.Height = btnFinancial.Height;
            pnlIndicator.Top = btnFinancial.Top;
            pnlFinancial.Visible = true;
            pnlStocks.Visible = false;
            pnlLoyalty.Visible = false;
            pnlSuppliers.Visible = false;
            pnlPOS.Visible = false;
            pnlDashboard.Visible = false;
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmClose closedialog = new frmClose();
            closedialog.ShowDialog();
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            frmRegistration regForm = new frmRegistration();
            regForm.ShowDialog();
        }
    }
}
