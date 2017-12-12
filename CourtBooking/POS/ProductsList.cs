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
    public partial class ProductsList : BaseListOnTap
    {
        public ProductsList()
        {
            InitializeComponent();
        }

        protected override void DoNew()
        {
            ProductsInfo frmForm = new ProductsInfo();
            frmForm.ShowDialog();
            btnStatus(true);
        }
    }
}
