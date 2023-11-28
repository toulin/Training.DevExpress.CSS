using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrainingWinformCss.UserControls;

namespace TrainingWinformCss
{
    public partial class Form1 : Form
    {
        MyPopupByCSS MyPopupCSS;
        MyButtonByCSS MyButtonCSS;

        public Form1()
        {
            InitializeComponent();
            Models.Settings settings = new Models.Settings() { };
            settings.Mode = Models.SPMode.AllSamle;
            settings.SQLMode= Models.SQLMode.Single;

            MyPopupCSS =new MyPopupByCSS(settings);
            PopupSampleBox.Controls.Add(MyPopupCSS);
            MyPopupCSS.Visible = true;            
            MyPopupCSS.Dock = DockStyle.Fill;

            MyButtonCSS=new MyButtonByCSS(settings);
            OptionButtonBox.Controls.Add(MyButtonCSS);
            MyButtonCSS.Visible = true;
            MyButtonCSS.Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
