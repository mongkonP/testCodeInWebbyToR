using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0580__DataRow
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/DataViewandDataRowView.htm
    public partial  class frmDataViewandDataRowView:Form
    {
        public frmDataViewandDataRowView()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDataViewandDataRowView
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDataViewandDataRowView";
            this.Text = "frmDataViewandDataRowView";
            this.Load += new System.EventHandler(this.frmDataViewandDataRowView_Load);
            this.ResumeLayout(false);

        }

        private void frmDataViewandDataRowView_Load(object sender, EventArgs e)
        {

        }
    }
}
