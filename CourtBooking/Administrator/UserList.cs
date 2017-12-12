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

namespace CourtBooking.Administrator
{
    public partial class UserList : BaseListOnTap
    {
        public UserList()
        {
            InitializeComponent();
        }
        protected override void DoNew()
        {
            UserInfo frmForm = new UserInfo();
            frmForm.ShowDialog();
            btnStatus(true);
        }
    }
}
