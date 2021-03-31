using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace WindowsFormsApDevex
{
    public partial class XtraReport3 : DevExpress.XtraReports.UI.XtraReport
    {
      
        public XtraReport3(int siparisId)
        {
            InitializeComponent();
            this.SiparisId.Value = siparisId;
        }
 
    }
}
