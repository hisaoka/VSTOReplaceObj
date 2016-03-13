namespace ReplaceText
{
    partial class UtilRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// デザイナー変数が必要です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public UtilRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナーのサポートに必要なメソッドです。
        /// このメソッドの内容をコード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.groupUtil = this.Factory.CreateRibbonGroup();
            this.buttonAsReplaceObj = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.groupUtil.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.groupUtil);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // groupUtil
            // 
            this.groupUtil.Items.Add(this.buttonAsReplaceObj);
            this.groupUtil.Label = "ユーティリティ";
            this.groupUtil.Name = "groupUtil";
            // 
            // buttonAsReplaceObj
            // 
            this.buttonAsReplaceObj.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonAsReplaceObj.Label = "オブジェクト置換";
            this.buttonAsReplaceObj.Name = "buttonAsReplaceObj";
            this.buttonAsReplaceObj.ShowImage = true;
            this.buttonAsReplaceObj.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonAsReplaceObj_Click);
            // 
            // UtilRibbon
            // 
            this.Name = "UtilRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.UtilRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.groupUtil.ResumeLayout(false);
            this.groupUtil.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupUtil;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonAsReplaceObj;
    }

    partial class ThisRibbonCollection
    {
        internal UtilRibbon UtilRibbon
        {
            get { return this.GetRibbon<UtilRibbon>(); }
        }
    }
}
