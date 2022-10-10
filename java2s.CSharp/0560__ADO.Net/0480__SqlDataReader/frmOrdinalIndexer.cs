using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0480__SqlDataReader
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/OrdinalIndexer.htm
    public partial  class frmOrdinalIndexer:Form
    {
        public frmOrdinalIndexer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOrdinalIndexer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOrdinalIndexer";
            this.Text = "frmOrdinalIndexer";
            this.Load += new System.EventHandler(this.frmOrdinalIndexer_Load);
            this.ResumeLayout(false);

        }

        private void frmOrdinalIndexer_Load(object sender, EventArgs e)
        {

        }
    }
}
