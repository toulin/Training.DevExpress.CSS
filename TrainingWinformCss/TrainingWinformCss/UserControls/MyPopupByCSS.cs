using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Html;
using DevExpress.XtraEditors;
using TrainingWinformCss.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TrainingWinformCss.UserControls
{
    public partial class MyPopupByCSS : DevExpress.XtraEditors.XtraUserControl
    {
        private Settings MySettings;

        public MyPopupByCSS(Settings settings)
        {

            InitializeComponent();
            MySettings = settings;
            SPModeHtmlContent.DataContext = settings;
            SPModeHtmlContent.Dock = DockStyle.Fill;

            menuPopup.ContainerControl = this;
            menuPopup.HideOnElementClick = DevExpress.Utils.DefaultBoolean.True;
            menuPopup.ElementMouseClick += MenuPopup_ElementMouseClick;
        }

        private void MenuPopup_ElementMouseClick(object sender, DxHtmlElementMouseEventArgs e)
        {
            Debug.WriteLine("MenuPopup_ElementMouseClick");
            if (e.Element.Id == "menuIdSingle")
            {
                MySettings.Mode = SPMode.AllSamle;
            }
            else if (e.Element.Id == "menuIdMulti")
            {
                MySettings.Mode = SPMode.GroupSamle;
            }
            else if (e.Element.Id == "menuIdMerge")
            {
                MySettings.Mode = SPMode.FixedSample;
            }
            SPModeHtmlContent.Refresh();
        }

        void OnFileClick(object sender, DxHtmlElementMouseEventArgs args)
        {
            var popupSize = ScaleDPI.ScaleSize(new Size(140, 180));
            int shadowOffsetLeft = ScaleDPI.ScaleHorizontal(8);
            var popupLocation = new Point(
                args.Element.Location.X - shadowOffsetLeft,
                args.Element.ViewInfo.Bounds.Bottom);
            menuPopup.Show(SPModeHtmlContent, SPModeHtmlContent.RectangleToScreen(new Rectangle(popupLocation, popupSize)));
        }

        private void SPModeHtmlContent_Click(object sender, EventArgs e)
        {

        }
    }
}
