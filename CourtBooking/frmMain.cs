using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;

namespace CourtBooking
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tabMain.SelectedPageIndex = 1;
        }

        private void tabMain_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            switch (tabMain.SelectedPageIndex)  {
                case 0 :
                    tabManageCourt.SelectedIndex = 2;
                    break;
                case 1:
                    tabManagePOS.SelectedIndex = 4;
                    break;
                case  2:
                    tabManageSetup.SelectedIndex = 1;
                    break;
            }
                   
        }
    }
}
