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
    public partial class ProductTypeList : BaseListOnTap
    {
        public ProductTypeList()
        {
            InitializeComponent();
        }

        protected override void DoNew()
        {
            ProductTypeInfo frmForm = new ProductTypeInfo();
            frmForm.ShowDialog();
            btnStatus(true);
        }
    }
}
