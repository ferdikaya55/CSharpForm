using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApDevex.DataAccess;

namespace WindowsFormsApDevex
{
    public partial class FrmUrunHizmetList : Form
    {
        UrunHizmetDal urunhizmetDal = new UrunHizmetDal();
        public int SecilenUrunHizmetId { get; set; }
        public FrmUrunHizmetList()
        {
            InitializeComponent();
        }

        private void FrmUrunHizmetList_Load(object sender, EventArgs e)
        {
            gridControlUrunHizmetList.DataSource = urunhizmetDal.DataTableUrunHizmet();
        }

        private void gridControlUrunHizmetList_DoubleClick(object sender, EventArgs e)
        {
            int id = 0;
            DataRow row = gridViewUrunHizmetList.GetDataRow(gridViewUrunHizmetList.FocusedRowHandle);
            if (row != null)
            {
                int.TryParse(row["UrunHizmetId"].ToString(), out id);
            }
            SecilenUrunHizmetId = id;
            this.Close();
        }
    }
}
