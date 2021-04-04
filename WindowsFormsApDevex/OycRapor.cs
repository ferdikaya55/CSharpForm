using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace WindowsFormsApDevex
{
    public partial class OycRapor : DevExpress.XtraReports.UI.XtraReport
    {
        public OycRapor(int siparisId)
        {
            InitializeComponent();
            this.SiparisId.Value = siparisId;
        }

    }
}
