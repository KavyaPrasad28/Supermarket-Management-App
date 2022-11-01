using System;
using System.Windows.Forms;

namespace SuperMarketApp2.PresentationLayers
{
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
            InitializeComponent();
        }

        #region Events
        private void AdminHomePage_Load(object sender, EventArgs e)
        {
            panelAdminHome.Controls.Add(new Home());
        }

        private void btnViewPurchaseInfo_Click_1(object sender, EventArgs e)
        {
            panelAdminHome.Controls.Clear();
            panelAdminHome.Controls.Add(new PurchaseInfo());
        }

        private void btnSalesInfo_Click(object sender, EventArgs e)
        {
            panelAdminHome.Controls.Clear();
            panelAdminHome.Controls.Add(new SalesInfo());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelAdminHome.Controls.Clear();
            panelAdminHome.Controls.Add(new Home());
        }
        
        private void AdminHomePage_Activated(object sender, EventArgs e)
        {
            if(PurchaseForm.closeFlag == 1 || SalesPage.closeFlag == 1)
            {
                panelAdminHome.Controls.Clear();
                panelAdminHome.Controls.Add(new Home());
                PurchaseForm.closeFlag = 0;
                SalesPage.closeFlag = 0;
            }
        }
        #endregion
    }
}
