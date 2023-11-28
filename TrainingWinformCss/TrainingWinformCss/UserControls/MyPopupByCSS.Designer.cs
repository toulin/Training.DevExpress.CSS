namespace TrainingWinformCss.UserControls
{
    partial class MyPopupByCSS
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPopupByCSS));
            this.menuPopup = new DevExpress.XtraEditors.HtmlContentPopup(this.components);
            this.SPModeHtmlContent = new DevExpress.XtraEditors.HtmlContentControl();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.menuPopup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPModeHtmlContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPopup
            // 
            this.menuPopup.HtmlTemplate.Styles = resources.GetString("menuPopup.HtmlTemplate.Styles");
            this.menuPopup.HtmlTemplate.Template = resources.GetString("menuPopup.HtmlTemplate.Template");
            // 
            // SPModeHtmlContent
            // 
            this.SPModeHtmlContent.Cursor = System.Windows.Forms.Cursors.Default;
            this.SPModeHtmlContent.HtmlImages = this.svgImageCollection1;
            this.SPModeHtmlContent.HtmlTemplate.Styles = resources.GetString("SPModeHtmlContent.HtmlTemplate.Styles");
            this.SPModeHtmlContent.HtmlTemplate.Template = "<div class=\"menuBar center\">\r\n\t\r\n\t    <div id=\"miFile\" class=\"mainBarItem\" onclic" +
    "k=\"OnFileClick\" >${DisplaySPMode}\r\n\t    <img src=\"ArrowDown\"></div>\r\n    \r\n</div" +
    ">";
            this.SPModeHtmlContent.Location = new System.Drawing.Point(9, 15);
            this.SPModeHtmlContent.Margin = new System.Windows.Forms.Padding(2);
            this.SPModeHtmlContent.Name = "SPModeHtmlContent";
            this.SPModeHtmlContent.Size = new System.Drawing.Size(99, 47);
            this.SPModeHtmlContent.TabIndex = 0;
            this.SPModeHtmlContent.Click += new System.EventHandler(this.SPModeHtmlContent_Click);
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("actions_arrow3down", "image://svgimages/icon builder/actions_arrow3down.svg");
            this.svgImageCollection1.Add("ArrowDown", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.ArrowDown"))));
            // 
            // MyPopupByCSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SPModeHtmlContent);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MyPopupByCSS";
            this.Size = new System.Drawing.Size(244, 262);
            ((System.ComponentModel.ISupportInitialize)(this.menuPopup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SPModeHtmlContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.HtmlContentPopup menuPopup;
        private DevExpress.XtraEditors.HtmlContentControl SPModeHtmlContent;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
    }
}
