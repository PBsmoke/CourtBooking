﻿using System;
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
    public partial class ConfirmBookingList : BaseListOnTap
    {
        public ConfirmBookingList()
        {
            InitializeComponent();
        }

        protected override void DoNew()
        {
            ConfirmBookingInfo frmForm = new ConfirmBookingInfo();
            frmForm.ShowDialog();
            btnStatus(true);
        }
    }
}
