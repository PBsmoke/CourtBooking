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
            this.promotionList = new CourtBooking.PromotionList();
            this.tabMember = new System.Windows.Forms.TabPage();
            this.customerList1 = new CourtBooking.CustomerList();
            this.tabBooking = new System.Windows.Forms.TabPage();
            this.sidePanel2 = new DevExpress.XtraEditors.SidePanel();
            this.schedulerControl1 = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.calendarControl1 = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.tabConfirmBooking = new System.Windows.Forms.TabPage();
            this.confirmBookingList1 = new CourtBooking.ConfirmBookingList();
            this.tabPOS = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabManagePOS = new System.Windows.Forms.TabControl();
            this.tabUnit = new System.Windows.Forms.TabPage();
            this.unitList1 = new POS.UnitList();
            this.tabProductType = new System.Windows.Forms.TabPage();
            this.productTypeList1 = new POS.ProductTypeList();
            this.tabGetProducts = new System.Windows.Forms.TabPage();
            this.getProductsList1 = new POS.GetProductsList();
            this.tabStore = new System.Windows.Forms.TabPage();
            this.productsList1 = new POS.ProductsList();
            this.tabSell = new System.Windows.Forms.TabPage();
            this.sellList1 = new POS.SellList();
            this.tabSetup = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabManageSetup = new System.Windows.Forms.TabControl();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.userList1 = new Administrator.UserList();
            this.btnBooking = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfirmBooking = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabCourtBooking.SuspendLayout();
            this.tabManageCourt.SuspendLayout();
            this.tabPrommotion.SuspendLayout();
            this.tabMember.SuspendLayout();
            this.tabBooking.SuspendLayout();
            this.sidePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).BeginInit();
            this.tabConfirmBooking.SuspendLayout();
            this.tabPOS.SuspendLayout();
            this.tabManagePOS.SuspendLayout();
            this.tabUnit.SuspendLayout();
            this.tabProductType.SuspendLayout();
            this.tabGetProducts.SuspendLayout();
            this.tabStore.SuspendLayout();
            this.tabSell.SuspendLayout();
            this.tabSetup.SuspendLayout();
            this.tabManageSetup.SuspendLayout();
            this.tabUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.tabMain.Appearance.Options.UseFont = true;
            this.tabMain.Controls.Add(this.tabCourtBooking);
            this.tabMain.Controls.Add(this.tabPOS);
            this.tabMain.Controls.Add(this.tabSetup);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMain.Name = "tabMain";
            this.tabMain.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabCourtBooking,
            this.tabPOS,
            this.tabSetup});
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
            this.tabManageCourt.Controls.Add(this.tabMember);
            this.tabManageCourt.Controls.Add(this.tabBooking);
            this.tabManageCourt.Controls.Add(this.tabConfirmBooking);
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
            this.tabPrommotion.Controls.Add(this.promotionList);
            this.tabPrommotion.Location = new System.Drawing.Point(4, 25);
            this.tabPrommotion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPrommotion.Name = "tabPrommotion";
            this.tabPrommotion.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPrommotion.Size = new System.Drawing.Size(983, 476);
            this.tabPrommotion.TabIndex = 0;
            this.tabPrommotion.Text = "กำหนด Promotion";
            this.tabPrommotion.UseVisualStyleBackColor = true;
            // 
            // promotionList
            // 
            this.promotionList.AutoSize = true;
            this.promotionList.BtnAddText = "";
            this.promotionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.promotionList.Location = new System.Drawing.Point(4, 5);
            this.promotionList.Margin = new System.Windows.Forms.Padding(4);
            this.promotionList.Name = "promotionList";
            this.promotionList.Size = new System.Drawing.Size(975, 466);
            this.promotionList.TabIndex = 0;
            // 
            // tabMember
            // 
            this.tabMember.Controls.Add(this.customerList1);
            this.tabMember.Location = new System.Drawing.Point(4, 25);
            this.tabMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMember.Name = "tabMember";
            this.tabMember.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabMember.Size = new System.Drawing.Size(983, 476);
            this.tabMember.TabIndex = 2;
            this.tabMember.Text = "ข้อมูลลูกค้า";
            this.tabMember.UseVisualStyleBackColor = true;
            // 
            // customerList1
            // 
            this.customerList1.AutoSize = true;
            this.customerList1.BtnAddText = "";
            this.customerList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerList1.Location = new System.Drawing.Point(4, 5);
            this.customerList1.Margin = new System.Windows.Forms.Padding(4);
            this.customerList1.Name = "customerList1";
            this.customerList1.Size = new System.Drawing.Size(975, 466);
            this.customerList1.TabIndex = 0;
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
            this.sidePanel1.Controls.Add(this.btnConfirmBooking);
            this.sidePanel1.Controls.Add(this.btnBooking);
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
            // tabConfirmBooking
            // 
            this.tabConfirmBooking.Controls.Add(this.confirmBookingList1);
            this.tabConfirmBooking.Location = new System.Drawing.Point(4, 25);
            this.tabConfirmBooking.Name = "tabConfirmBooking";
            this.tabConfirmBooking.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfirmBooking.Size = new System.Drawing.Size(983, 476);
            this.tabConfirmBooking.TabIndex = 3;
            this.tabConfirmBooking.Text = "ยืนยันการจองสนาม";
            this.tabConfirmBooking.UseVisualStyleBackColor = true;
            // 
            // confirmBookingList1
            // 
            this.confirmBookingList1.AutoSize = true;
            this.confirmBookingList1.BtnAddText = "";
            this.confirmBookingList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmBookingList1.Location = new System.Drawing.Point(3, 3);
            this.confirmBookingList1.Margin = new System.Windows.Forms.Padding(4);
            this.confirmBookingList1.Name = "confirmBookingList1";
            this.confirmBookingList1.Size = new System.Drawing.Size(977, 470);
            this.confirmBookingList1.TabIndex = 0;
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
            this.tabManagePOS.Controls.Add(this.tabProductType);
            this.tabManagePOS.Controls.Add(this.tabGetProducts);
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
            this.tabUnit.Controls.Add(this.unitList1);
            this.tabUnit.Location = new System.Drawing.Point(4, 25);
            this.tabUnit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabUnit.Name = "tabUnit";
            this.tabUnit.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabUnit.Size = new System.Drawing.Size(983, 476);
            this.tabUnit.TabIndex = 0;
            this.tabUnit.Text = "หน่วยนับ";
            this.tabUnit.UseVisualStyleBackColor = true;
            // 
            // unitList1
            // 
            this.unitList1.AutoSize = true;
            this.unitList1.BtnAddText = "";
            this.unitList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.unitList1.Location = new System.Drawing.Point(4, 5);
            this.unitList1.Margin = new System.Windows.Forms.Padding(4);
            this.unitList1.Name = "unitList1";
            this.unitList1.Size = new System.Drawing.Size(975, 466);
            this.unitList1.TabIndex = 0;
            // 
            // tabProductType
            // 
            this.tabProductType.Controls.Add(this.productTypeList1);
            this.tabProductType.Location = new System.Drawing.Point(4, 25);
            this.tabProductType.Name = "tabProductType";
            this.tabProductType.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductType.Size = new System.Drawing.Size(983, 476);
            this.tabProductType.TabIndex = 3;
            this.tabProductType.Text = "ประเภทสินค้า";
            this.tabProductType.UseVisualStyleBackColor = true;
            // 
            // productTypeList1
            // 
            this.productTypeList1.AutoSize = true;
            this.productTypeList1.BtnAddText = "";
            this.productTypeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productTypeList1.Location = new System.Drawing.Point(3, 3);
            this.productTypeList1.Margin = new System.Windows.Forms.Padding(4);
            this.productTypeList1.Name = "productTypeList1";
            this.productTypeList1.Size = new System.Drawing.Size(977, 470);
            this.productTypeList1.TabIndex = 0;
            // 
            // tabGetProducts
            // 
            this.tabGetProducts.Controls.Add(this.getProductsList1);
            this.tabGetProducts.Location = new System.Drawing.Point(4, 25);
            this.tabGetProducts.Name = "tabGetProducts";
            this.tabGetProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabGetProducts.Size = new System.Drawing.Size(983, 476);
            this.tabGetProducts.TabIndex = 4;
            this.tabGetProducts.Text = "รับสินค้า";
            this.tabGetProducts.UseVisualStyleBackColor = true;
            // 
            // getProductsList1
            // 
            this.getProductsList1.AutoSize = true;
            this.getProductsList1.BtnAddText = "";
            this.getProductsList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.getProductsList1.Location = new System.Drawing.Point(3, 3);
            this.getProductsList1.Margin = new System.Windows.Forms.Padding(4);
            this.getProductsList1.Name = "getProductsList1";
            this.getProductsList1.Size = new System.Drawing.Size(977, 470);
            this.getProductsList1.TabIndex = 0;
            // 
            // tabStore
            // 
            this.tabStore.Controls.Add(this.productsList1);
            this.tabStore.Location = new System.Drawing.Point(4, 25);
            this.tabStore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabStore.Name = "tabStore";
            this.tabStore.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabStore.Size = new System.Drawing.Size(983, 476);
            this.tabStore.TabIndex = 1;
            this.tabStore.Text = "สินค้า";
            this.tabStore.UseVisualStyleBackColor = true;
            // 
            // productsList1
            // 
            this.productsList1.AutoSize = true;
            this.productsList1.BtnAddText = "";
            this.productsList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsList1.Location = new System.Drawing.Point(4, 5);
            this.productsList1.Margin = new System.Windows.Forms.Padding(4);
            this.productsList1.Name = "productsList1";
            this.productsList1.Size = new System.Drawing.Size(975, 466);
            this.productsList1.TabIndex = 0;
            // 
            // tabSell
            // 
            this.tabSell.Controls.Add(this.sellList1);
            this.tabSell.Location = new System.Drawing.Point(4, 25);
            this.tabSell.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSell.Name = "tabSell";
            this.tabSell.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSell.Size = new System.Drawing.Size(983, 476);
            this.tabSell.TabIndex = 2;
            this.tabSell.Text = "การขาย";
            this.tabSell.UseVisualStyleBackColor = true;
            // 
            // sellList1
            // 
            this.sellList1.AutoSize = true;
            this.sellList1.BtnAddText = "";
            this.sellList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sellList1.Location = new System.Drawing.Point(4, 5);
            this.sellList1.Margin = new System.Windows.Forms.Padding(4);
            this.sellList1.Name = "sellList1";
            this.sellList1.Size = new System.Drawing.Size(975, 466);
            this.sellList1.TabIndex = 0;
            // 
            // tabSetup
            // 
            this.tabSetup.Caption = "Setup";
            this.tabSetup.Controls.Add(this.tabManageSetup);
            this.tabSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSetup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabSetup.Name = "tabSetup";
            this.tabSetup.Size = new System.Drawing.Size(991, 505);
            // 
            // tabManageSetup
            // 
            this.tabManageSetup.Controls.Add(this.tabUser);
            this.tabManageSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabManageSetup.Location = new System.Drawing.Point(0, 0);
            this.tabManageSetup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabManageSetup.Name = "tabManageSetup";
            this.tabManageSetup.SelectedIndex = 0;
            this.tabManageSetup.Size = new System.Drawing.Size(991, 505);
            this.tabManageSetup.TabIndex = 0;
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.userList1);
            this.tabUser.Location = new System.Drawing.Point(4, 25);
            this.tabUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabUser.Size = new System.Drawing.Size(983, 476);
            this.tabUser.TabIndex = 1;
            this.tabUser.Text = "User";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // userList1
            // 
            this.userList1.AutoSize = true;
            this.userList1.BtnAddText = "";
            this.userList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userList1.Location = new System.Drawing.Point(4, 5);
            this.userList1.Margin = new System.Windows.Forms.Padding(4);
            this.userList1.Name = "userList1";
            this.userList1.Size = new System.Drawing.Size(975, 466);
            this.userList1.TabIndex = 0;
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(-1, 233);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(256, 23);
            this.btnBooking.TabIndex = 1;
            this.btnBooking.Text = "จองสนาม";
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnConfirmBooking
            // 
            this.btnConfirmBooking.Location = new System.Drawing.Point(-1, 262);
            this.btnConfirmBooking.Name = "btnConfirmBooking";
            this.btnConfirmBooking.Size = new System.Drawing.Size(256, 23);
            this.btnConfirmBooking.TabIndex = 2;
            this.btnConfirmBooking.Text = "ยืนยันการจองสนาม";
            this.btnConfirmBooking.Click += new System.EventHandler(this.btnConfirmBooking_Click);
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
            this.tabMember.ResumeLayout(false);
            this.tabMember.PerformLayout();
            this.tabBooking.ResumeLayout(false);
            this.sidePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarControl1.CalendarTimeProperties)).EndInit();
            this.tabConfirmBooking.ResumeLayout(false);
            this.tabConfirmBooking.PerformLayout();
            this.tabPOS.ResumeLayout(false);
            this.tabManagePOS.ResumeLayout(false);
            this.tabUnit.ResumeLayout(false);
            this.tabUnit.PerformLayout();
            this.tabProductType.ResumeLayout(false);
            this.tabProductType.PerformLayout();
            this.tabGetProducts.ResumeLayout(false);
            this.tabGetProducts.PerformLayout();
            this.tabStore.ResumeLayout(false);
            this.tabStore.PerformLayout();
            this.tabSell.ResumeLayout(false);
            this.tabSell.PerformLayout();
            this.tabSetup.ResumeLayout(false);
            this.tabManageSetup.ResumeLayout(false);
            this.tabUser.ResumeLayout(false);
            this.tabUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabMain;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabCourtBooking;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabPOS;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabSetup;
        private System.Windows.Forms.TabControl tabManageCourt;
        private System.Windows.Forms.TabPage tabPrommotion;
        private System.Windows.Forms.TabPage tabBooking;
        private System.Windows.Forms.TabPage tabMember;
        private System.Windows.Forms.TabControl tabManagePOS;
        private System.Windows.Forms.TabPage tabUnit;
        private System.Windows.Forms.TabPage tabStore;
        private System.Windows.Forms.TabControl tabManageSetup;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.TabPage tabSell;
        private DevExpress.XtraEditors.Controls.CalendarControl calendarControl1;
        private DevExpress.XtraScheduler.SchedulerControl schedulerControl1;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private DevExpress.XtraEditors.SidePanel sidePanel2;
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private CourtBooking.PromotionList promotionList;
        private CourtBooking.CustomerList customerList1;
        private POS.UnitList unitList1;
        private POS.ProductsList productsList1;
        private POS.SellList sellList1;
        private Administrator.UserList userList1;
        private System.Windows.Forms.TabPage tabProductType;
        private POS.ProductTypeList productTypeList1;
        private System.Windows.Forms.TabPage tabGetProducts;
        private POS.GetProductsList getProductsList1;
        private System.Windows.Forms.TabPage tabConfirmBooking;
        private CourtBooking.ConfirmBookingList confirmBookingList1;
        private DevExpress.XtraEditors.SimpleButton btnConfirmBooking;
        private DevExpress.XtraEditors.SimpleButton btnBooking;
    }
}

