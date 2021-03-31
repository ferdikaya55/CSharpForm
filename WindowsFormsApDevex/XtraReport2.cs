using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace WindowsFormsApDevex.DataAccess
{
    public partial class XtraReport2 : DevExpress.XtraReports.UI.XtraReport
    {
        FrmSiparisler frmSiparis = new FrmSiparisler();
        public XtraReport2()
        {
            InitializeComponent();
            int siparisId = frmSiparis.SiparisID;
        }

    }
}
