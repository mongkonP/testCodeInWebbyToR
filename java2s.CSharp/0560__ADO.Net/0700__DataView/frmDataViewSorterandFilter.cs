using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0700__DataView
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/DataViewSorterandFilter.htm
    public partial  class frmDataViewSorterandFilter:Form
    {
        public frmDataViewSorterandFilter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDataViewSorterandFilter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDataViewSorterandFilter";
            this.Text = "frmDataViewSorterandFilter";
            this.Load += new System.EventHandler(this.frmDataViewSorterandFilter_Load);
            this.ResumeLayout(false);

        }

        private void frmDataViewSorterandFilter_Load(object sender, EventArgs e)
        {

        }
    }
}
