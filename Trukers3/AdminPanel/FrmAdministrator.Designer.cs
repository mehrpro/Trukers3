namespace Trukers3
{
    partial class FrmAdministrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdministrator));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnExistenceBase = new DevExpress.XtraBars.BarButtonItem();
            this.btnExistenceGroups = new DevExpress.XtraBars.BarButtonItem();
            this.btnGroupProperty = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnExistenceBase,
            this.btnExistenceGroups,
            this.btnGroupProperty});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(650, 141);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "اطلاعات اولیه";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnExistenceBase);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnExistenceGroups);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGroupProperty);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "موجودیت های نرم افزار";
            // 
            // btnExistenceBase
            // 
            this.btnExistenceBase.Caption = "موجودیت ها";
            this.btnExistenceBase.Glyph = ((System.Drawing.Image)(resources.GetObject("btnExistenceBase.Glyph")));
            this.btnExistenceBase.Id = 1;
            this.btnExistenceBase.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnExistenceBase.LargeGlyph")));
            this.btnExistenceBase.Name = "btnExistenceBase";
            // 
            // btnExistenceGroups
            // 
            this.btnExistenceGroups.Caption = "گروه ها";
            this.btnExistenceGroups.Glyph = ((System.Drawing.Image)(resources.GetObject("btnExistenceGroups.Glyph")));
            this.btnExistenceGroups.Id = 2;
            this.btnExistenceGroups.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnExistenceGroups.LargeGlyph")));
            this.btnExistenceGroups.Name = "btnExistenceGroups";
            // 
            // btnGroupProperty
            // 
            this.btnGroupProperty.Caption = "ویژگی های گروه";
            this.btnGroupProperty.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGroupProperty.Glyph")));
            this.btnGroupProperty.Id = 3;
            this.btnGroupProperty.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnGroupProperty.LargeGlyph")));
            this.btnGroupProperty.Name = "btnGroupProperty";
            // 
            // FrmAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 447);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "FrmAdministrator";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مدیریت نرم افزار";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnExistenceBase;
        private DevExpress.XtraBars.BarButtonItem btnExistenceGroups;
        private DevExpress.XtraBars.BarButtonItem btnGroupProperty;
    }
}