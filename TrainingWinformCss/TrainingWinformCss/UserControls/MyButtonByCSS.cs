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
using DevExpress.XtraEditors.ImageEditor;
using TrainingWinformCss.Models;

namespace TrainingWinformCss.UserControls
{
    public partial class MyButtonByCSS : DevExpress.XtraEditors.XtraUserControl
    {
        /// <summary>
        /// 目前設定值
        /// </summary>
        private Settings MySettings;

        public MyButtonByCSS(Settings settings)
        {
            InitializeComponent();
            MySettings = settings;
            htmlContentControl1.DataContext = settings;
        }

        private DxHtmlElement lastChooseButton;

        void OnSQLModeButtonClick(object sender, DxHtmlElementMouseEventArgs args)
        {
            if(lastChooseButton!= null)
            {
                lastChooseButton.ClassName = "button gray";
            }
            switch(args.ElementId)
            {
                case "menuIdSingle":
                    MySettings.SQLMode = SQLMode.Single;
                    break;
                case "menuIdMulti":
                    MySettings.SQLMode = SQLMode.Multi;
                    break;
                case "menuIdMerge":
                    MySettings.SQLMode = SQLMode.Merge;
                    break;
            }
            args.Element.ClassName = "button Choose";
            lastChooseButton= args.Element;


            htmlContentControl1.Refresh();
            Debug.WriteLine($"OnSQLModeButtonClick- SQLMODE={MySettings.SQLMode}");
        }

        private void htmlContentControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
