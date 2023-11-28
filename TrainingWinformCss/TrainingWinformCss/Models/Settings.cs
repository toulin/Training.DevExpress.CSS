using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingWinformCss.Models
{
    public class Settings
    {
        public SPMode Mode { get; set; }

        public string DisplaySPMode
        {
            get { return Mode.ToString(); }
        }


        public SQLMode SQLMode { get; set; }

        public string DisplaySQLMode
        {
            get { return SQLMode.ToString(); }
        }


        public bool IsMuliti
        {
            get=> SQLMode == SQLMode.Multi;
        }
    }
}
