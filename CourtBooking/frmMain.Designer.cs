namespace CourtBooking
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler4 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler5 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler6 = new DevExpress.XtraScheduler.TimeRuler();
            this.tabMain = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabCourtBooking = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabManageCourt = new System.Windows.Forms.TabControl();
            this.tabPrommotion = new System.Windows.Forms.TabPage();
            this.tabBooking = new System.Windows.Forms.TabPage();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.calendarControl1 = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.tabMember = new System.Windows.Forms.TabPage();
            this.baseListOnTap4 = new Service.Baseform.BaseListOnTap();
            this.tabPOS = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabManagePOS = new System.Windows.Forms.TabControl();
            this.tabUnit = new System.Windows.Forms.TabPage();
            this.baseListOnTap1 = new Service.Baseform.BaseListOnTap();
            this.tabStore = new System.Windows.Forms.TabPage();
            this.ListStore = new Service.Baseform.BaseListOnTap();
            this.tabSell = new System.Windows.Forms.TabPage();
            this.baseListOnTap2 = new Service.Baseform.BaseListOnTap();
            this.tabAdministrator = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabManageUser = new System.Windows.Forms.TabControl();
            this.tabPermission = new System.Windows.Forms.TabPage();
            this.baseListOnTap5 = new Service.Baseform.BaseListOnTap();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.baseListOnTap6 = new Service.Baseform.BaseListOnTap();
            this.promotionList1 = new CourtBooking.PromotionList();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabCourtBooking.SuspendLayout();
            this.tabManageCourt.SuspendLayout();
            this.tabPrommotion.SuspendLayout();
            this.tabBooking.SuspendLayout();
            this.sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).BeginInit();
            this.tabMember.SuspendLayout();
            this.tabPOS.SuspendLayout();
            this.tabManagePOS.SuspendLayout();
            this.tabUnit.SuspendLayout();
            this.tabStore.SuspendLayout();
            this.tabSell.SuspendLayout();
            this.tabAdministrator.SuspendLayout();
            this.tabManageUser.SuspendLayout();
            this.tabPermission.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tabMain.Appearance.Options.UseFont = true;
            this.tabMain.Controls.Add(this.tabCourtBooking);
            this.tabMain.Controls.Add(this.tabPOS);
            this.tabMain.Controls.Add(this.tabAdministrator);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMain.Name = "tabMain";
            this.tabMain.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabCourtBooking,
            this.tabPOS,
            this.tabAdministrator});
            this.tabMain.RegularSize = new System.Drawing.Size(1009, 550);
            this.tabMain.SelectedPage = this.tabCourtBooking;
            this.tabMain.Size = new System.Drawing.Size(1009, 550);
            this.tabMain.TabIndex = 1;
            this.tabMain.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.tabMain_SelectedPageChanged);
            // 
            // tabCourtBooking
            // 
            this.tabCourtBooking.Caption = "Court Booking";
            this.tabCourtBooking.Controls.Add(this.tabManageCourt);
            this.tabCourtBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCourtBooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabCourtBooking.Name = "tabCourtBooking";
            this.tabCourtBooking.Properties.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.tabCourtBooking.Properties.AppearanceCaption.Options.UseFont = true;
            this.tabCourtBooking.Size = new System.Drawing.Size(991, 505);
            // 
            // tabManageCourt
            // 
            this.tabManageCourt.Controls.Add(this.tabPrommotion);
            this.tabManageCourt.Controls.Add(this.tabBooking);
            this.tabManageCourt.Controls.Add(this.tabMember);
            this.tabManageCourt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabManageCourt.Location = new System.Drawing.Point(0, 0);
            this.tabManageCourt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabManageCourt.Name = "tabManageCourt";
            this.tabManageCourt.SelectedIndex = 0;
            this.tabManageCourt.Size = new System.Drawing.Size(991, 505);
            this.tabManageCourt.TabIndex = 0;
            // 
            // tabPrommotion
            // 
            this.tabPrommotion.Controls.Add(this.promotionList1);
            this.tabPrommotion.Location = new System.Drawing.Point(4, 25);
            this.tabPrommotion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPrommotion.Name = "tabPrommotion";
            this.tabPrommotion.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPrommotion.Size = new System.Drawing.Size(983, 476);
            this.tabPrommotion.TabIndex = 0;
            this.tabPrommotion.Text = "กำหนด Promotion";
            this.tabPrommotion.UseVisualStyleBackColor = true;
            // 
            // tabBooking
            // 
            this.tabBooking.Controls.Add(this.sidePanel2);
            this.tabBooking.Controls.Add(this.sidePanel1);
            this.tabBooking.Location = new System.Drawing.Point(4, 25);
            this.tabBooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabBooking.Name = "tabBooking";
            this.tabBooking.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabBooking.Size = new System.Drawing.Size(983, 476);
            this.tabBooking.TabIndex = 1;
            this.tabBooking.Text = "จองสนาม";
            this.tabBooking.UseVisualStyleBackColor = true;
            // 
            // sidePanel2
            // 
            this.sidePanel2.Controls.Add(this.schedulerControl1);
            this.sidePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel2.Location = new System.Drawing.Point(259, 5);
            this.sidePanel2.Name = "sidePanel2";
            this.sidePanel2.Size = new System.Drawing.Size(720, 466);
            this.sidePanel2.TabIndex = 3;
            this.sidePanel2.Text = "sidePanel2";
            // 
            // schedulerControl1
            // 
            this.schedulerControl1.DataStorage = this.schedulerStorage1;
            this.schedulerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerControl1.Location = new System.Drawing.Point(0, 0);
            this.schedulerControl1.Name = "schedulerControl1";
            this.schedulerControl1.Size = new System.Drawing.Size(720, 466);
            this.schedulerControl1.Start = new System.DateTime(2017, 12, 5, 0, 0, 0, 0);
            this.schedulerControl1.TabIndex = 1;
            this.schedulerControl1.Text = "schedulerControl1";
            this.schedulerControl1.Views.DayView.TimeRulers.Add(timeRuler4);
            this.schedulerControl1.Views.FullWeekView.Enabled = true;
            this.schedulerControl1.Views.FullWeekView.TimeRulers.Add(timeRuler5);
            this.schedulerControl1.Views.WeekView.Enabled = false;
            this.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(timeRuler6);
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.calendarControl1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel1.Location = new System.Drawing.Point(4, 5);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(255, 466);
            this.sidePanel1.TabIndex = 2;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // calendarControl1
            // 
            this.calendarControl1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calendarControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.calendarControl1.Location = new System.Drawing.Point(0, 0);
            this.calendarControl1.Name = "calendarControl1";
            this.calendarControl1.Size = new System.Drawing.Size(254, 227);
            this.calendarControl1.TabIndex = 0;
            // 
            // tabMember
            // 
            this.tabMember.Controls.Add(this.baseListOnTap4);
            this.tabMember.Location = new System.Drawing.Point(4, 25);
            this.tabMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMember.Name = "tabMember";
            this.tabMember.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMember.Size = new System.Drawing.Size(983, 476);
            this.tabMember.TabIndex = 2;
            this.tabMember.Text = "ข้อมูลลูกค้า";
            this.tabMember.UseVisualStyleBackColor = true;
            // 
            // baseListOnTap4
            // 
            this.baseListOnTap4.AutoSize = true;
            this.baseListOnTap4.BtnAddText = "";
            this.baseListOnTap4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseListOnTap4.Location = new System.Drawing.Point(4, 5);
            this.baseListOnTap4.Margin = new System.Windows.Forms.Padding(7);
            this.baseListOnTap4.Name = "baseListOnTap4";
            this.baseListOnTap4.Size = new System.Drawing.Size(975, 466);
            this.baseListOnTap4.TabIndex = 3;
            // 
            // tabPOS
            // 
            this.tabPOS.Caption = "POS";
            this.tabPOS.Controls.Add(this.tabManagePOS);
            this.tabPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPOS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPOS.Name = "tabPOS";
            this.tabPOS.Size = new System.Drawing.Size(991, 505);
            // 
            // tabManagePOS
            // 
            this.tabManagePOS.Controls.Add(this.tabUnit);
            this.tabManagePOS.Controls.Add(this.tabStore);
            this.tabManagePOS.Controls.Add(this.tabSell);
            this.tabManagePOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabManagePOS.Location = new System.Drawing.Point(0, 0);
            this.tabManagePOS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabManagePOS.Name = "tabManagePOS";
            this.tabManagePOS.SelectedIndex = 0;
            this.tabManagePOS.Size = new System.Drawing.Size(991, 505);
            this.tabManagePOS.TabIndex = 0;
            // 
            // tabUnit
            // 
            this.tabUnit.Controls.Add(this.baseListOnTap1);
            this.tabUnit.Location = new System.Drawing.Point(4, 25);
            this.tabUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabUnit.Name = "tabUnit";
            this.tabUnit.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabUnit.Size = new System.Drawing.Size(983, 476);
            this.tabUnit.TabIndex = 0;
            this.tabUnit.Text = "หน่วยนับ";
            this.tabUnit.UseVisualStyleBackColor = true;
            // 
            // baseListOnTap1
            // 
            this.baseListOnTap1.AutoSize = true;
            this.baseListOnTap1.BtnAddText = "";
            this.baseListOnTap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseListOnTap1.Location = new System.Drawing.Point(4, 5);
            this.baseListOnTap1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.baseListOnTap1.Name = "baseListOnTap1";
            this.baseListOnTap1.Size = new System.Drawing.Size(975, 466);
            this.baseListOnTap1.TabIndex = 2;
            // 
            // tabStore
            // 
            this.tabStore.Controls.Add(this.ListStore);
            this.tabStore.Location = new System.Drawing.Point(4, 25);
            this.tabStore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabStore.Name = "tabStore";
            this.tabStore.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabStore.Size = new System.Drawing.Size(983, 476);
            this.tabStore.TabIndex = 1;
            this.tabStore.Text = "สินค้า";
            this.tabStore.UseVisualStyleBackColor = true;
            // 
            // ListStore
            // 
            this.ListStore.AutoSize = true;
            this.ListStore.BtnAddText = "";
            this.ListStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListStore.Location = new System.Drawing.Point(4, 5);
            this.ListStore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListStore.Name = "ListStore";
            this.ListStore.Size = new System.Drawing.Size(975, 466);
            this.ListStore.TabIndex = 1;
            // 
            // tabSell
            // 
            this.tabSell.Controls.Add(this.baseListOnTap2);
            this.tabSell.Location = new System.Drawing.Point(4, 25);
            this.tabSell.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSell.Name = "tabSell";
            this.tabSell.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSell.Size = new System.Drawing.Size(983, 476);
            this.tabSell.TabIndex = 2;
            this.tabSell.Text = "การขาย";
            this.tabSell.UseVisualStyleBackColor = true;
            // 
            // baseListOnTap2
            // 
            this.baseListOnTap2.AutoSize = true;
            this.baseListOnTap2.BtnAddText = "";
            this.baseListOnTap2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseListOnTap2.Location = new System.Drawing.Point(4, 5);
            this.baseListOnTap2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.baseListOnTap2.Name = "baseListOnTap2";
            this.baseListOnTap2.Size = new System.Drawing.Size(975, 466);
            this.baseListOnTap2.TabIndex = 2;
            // 
            // tabAdministrator
            // 
            this.tabAdministrator.Caption = "Administrator";
            this.tabAdministrator.Controls.Add(this.tabManageUser);
            this.tabAdministrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAdministrator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabAdministrator.Name = "tabAdministrator";
            this.tabAdministrator.Size = new System.Drawing.Size(991, 505);
            // 
            // tabManageUser
            // 
            this.tabManageUser.Controls.Add(this.tabPermission);
            this.tabManageUser.Controls.Add(this.tabUser);
            this.tabManageUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabManageUser.Location = new System.Drawing.Point(0, 0);
            this.tabManageUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabManageUser.Name = "tabManageUser";
            this.tabManageUser.SelectedIndex = 0;
            this.tabManageUser.Size = new System.Drawing.Size(991, 505);
            this.tabManageUser.TabIndex = 0;
            // 
            // tabPermission
            // 
            this.tabPermission.Controls.Add(this.baseListOnTap5);
            this.tabPermission.Location = new System.Drawing.Point(4, 25);
            this.tabPermission.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPermission.Name = "tabPermission";
            this.tabPermission.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPermission.Size = new System.Drawing.Size(983, 476);
            this.tabPermission.TabIndex = 0;
            this.tabPermission.Text = "Premission";
            this.tabPermission.UseVisualStyleBackColor = true;
            // 
            // baseListOnTap5
            // 
            this.baseListOnTap5.AutoSize = true;
            this.baseListOnTap5.BtnAddText = "";
            this.baseListOnTap5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseListOnTap5.Location = new System.Drawing.Point(4, 5);
            this.baseListOnTap5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.baseListOnTap5.Name = "baseListOnTap5";
            this.baseListOnTap5.Size = new System.Drawing.Size(975, 466);
            this.baseListOnTap5.TabIndex = 2;
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.baseListOnTap6);
            this.tabUser.Location = new System.Drawing.Point(4, 25);
            this.tabUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabUser.Size = new System.Drawing.Size(983, 476);
            this.tabUser.TabIndex = 1;
            this.tabUser.Text = "User";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // baseListOnTap6
            // 
            this.baseListOnTap6.AutoSize = true;
            this.baseListOnTap6.BtnAddText = "";
            this.baseListOnTap6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseListOnTap6.Location = new System.Drawing.Point(4, 5);
            this.baseListOnTap6.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.baseListOnTap6.Name = "baseListOnTap6";
            this.baseListOnTap6.Size = new System.Drawing.Size(975, 466);
            this.baseListOnTap6.TabIndex = 2;
            // 
            // promotionList1
            // 
            this.promotionList1.AutoSize = true;
            this.promotionList1.BtnAddText = "";
            this.promotionList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.promotionList1.Location = new System.Drawing.Point(4, 5);
            this.promotionList1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.promotionList1.Name = "promotionList1";
            this.promotionList1.Size = new System.Drawing.Size(975, 466);
            this.promotionList1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 550);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = global::CourtBooking.Properties.Resources.Icon;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Court Booking";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabCourtBooking.ResumeLayout(false);
            this.tabManageCourt.ResumeLayout(false);
            this.tabPrommotion.ResumeLayout(false);
            this.tabPrommotion.PerformLayout();
            this.tabBooking.ResumeLayout(false);
            this.sidePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).EndInit();
            this.tabMember.ResumeLayout(false);
            this.tabMember.PerformLayout();
            this.tabPOS.ResumeLayout(false);
            this.tabManagePOS.ResumeLayout(false);
            this.tabUnit.ResumeLayout(false);
            this.tabUnit.PerformLayout();
            this.tabStore.ResumeLayout(false);
            this.tabStore.PerformLayout();
            this.tabSell.ResumeLayout(false);
            this.tabSell.PerformLayout();
            this.tabAdministrator.ResumeLayout(false);
            this.tabManageUser.ResumeLayout(false);
            this.tabPermission.ResumeLayout(false);
            this.tabPermission.PerformLayout();
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabMain;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabCourtBooking;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabPOS;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabAdministrator;
        private System.Windows.Forms.TabControl tabManageCourt;
        private System.Windows.Forms.TabPage tabPrommotion;
        private System.Windows.Forms.TabPage tabBooking;
        private System.Windows.Forms.TabPage tabMember;
        private System.Windows.Forms.TabControl tabManagePOS;
        private System.Windows.Forms.TabPage tabUnit;
        private System.Windows.Forms.TabPage tabStore;
        private System.Windows.Forms.TabControl tabManageUser;
        private System.Windows.Forms.TabPage tabPermission;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.TabPage tabSell;
        private Service.Baseform.BaseListOnTap ListStore;
        private Service.Baseform.BaseListOnTap baseListOnTap1;
        private Service.Baseform.BaseListOnTap baseListOnTap2;
        private Service.Baseform.BaseListOnTap baseListOnTap5;
        private Service.Baseform.BaseListOnTap baseListOnTap6;
        private DevExpress.XtraEditors.Controls.CalendarControl calendarControl1;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private Service.Baseform.BaseListOnTap baseListOnTap4;
        private CourtBooking.PromotionList promotionList1;
    }
}

