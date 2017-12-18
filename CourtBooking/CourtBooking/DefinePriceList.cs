using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;
using Service.Baseform;

namespace CourtBooking.CourtBooking
{
    public partial class DefinePriceList : BaseListOnTap
    {
        public DefinePriceList()
        {
            InitializeComponent();
        }

        protected override void DoNew()
        {
            DefinePriceInfo frmForm = new DefinePriceInfo();
            frmForm.ShowDialog();
            btnStatus(true);
        }
    }
}
