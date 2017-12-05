﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service.ClassService;

namespace Service.Baseform
{
    public partial class BaseListOnTap : UserControl
    {
        public BaseListOnTap()
        {
            InitializeComponent();
        }
        #region Member
        string btnAddText = string.Empty;
        #endregion Member

        #region Properties
        public string BtnAddText
        {
            get { return btnAddText; }
            set { btnAddText = value; }
        }
        #endregion Properties

        protected virtual void DoNew()
        { }

        protected virtual void DoEdit()
        { }

        protected virtual void DoDelete()
        { }

        protected virtual void DoReset()
        { }

        protected virtual void DoLoadForm()
        { }

        protected virtual void DoCloseForm()
        {
        
        }

        protected virtual void btnStatus(bool xStatus)//สถานะปุ่ม
        {

            if (xStatus == true)
            {
                //tsSave.Enabled = true;
                tsEdit.Enabled = false;
                tsDelete.Enabled = false;
            }
            else if (xStatus == false)
            {
                //tsSave.Enabled = false;
                tsEdit.Enabled = true;
                tsDelete.Enabled = true;
            }
        }

        protected virtual void DoVisibleSave(bool VisibleStatus)
        {
            tsSave.Visible = VisibleStatus;
            toolStripSeparator2.Visible = VisibleStatus;
        }

        protected virtual void DoVisibleEdit(bool VisibleStatus)
        {
            tsEdit.Visible = VisibleStatus;
            toolStripSeparator1.Visible = VisibleStatus;
        }

        protected virtual void DoVisibleDeleted(bool VisibleStatus)
        {
            tsDelete.Visible = VisibleStatus;
            toolStripSeparator3.Visible = VisibleStatus;
        }

        private void BaseListUserControl_Load(object sender, EventArgs e)
        {
            dbConString.Chk_ConnectionState();
            btnStatus(true);
            DoLoadForm();
        }

        private void tsSave_Click(object sender, EventArgs e)
        {
            DoNew();
        }

        private void tsEdit_Click(object sender, EventArgs e)
        {
            DoEdit();
        }

        private void tsDelete_Click(object sender, EventArgs e)
        {
            DoDelete();
        }

        private void tsClear_Click(object sender, EventArgs e)
        {
            Utilities.ResetAllControls(this);
            btnStatus(true);
            DoReset();
        }
    }
}
