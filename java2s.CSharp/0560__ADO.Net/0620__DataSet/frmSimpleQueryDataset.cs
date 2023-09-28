using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0620__DataSet
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/SimpleQueryDataset.htm
    public partial  class frmSimpleQueryDataset:Form
    {
        public frmSimpleQueryDataset()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleQueryDataset
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleQueryDataset";
            this.Text = "frmSimpleQueryDataset";
            this.Load += new System.EventHandler(this.frmSimpleQueryDataset_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleQueryDataset_Load(object sender, EventArgs e)
        {

        }
    }
}
