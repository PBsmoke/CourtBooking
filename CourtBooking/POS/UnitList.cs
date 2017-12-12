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

namespace CourtBooking.POS
{
    public partial class UnitList : BaseListOnTap
    {
        public UnitList()
        {
            InitializeComponent();
        }

        protected override void DoNew()
        {
            UnitInfo frmForm = new UnitInfo();
            frmForm.ShowDialog();
            btnStatus(true);
        }
    }
}
