using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0800__Indexer
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/OverloadtheMyArrayindexer.htm
    public partial  class frmOverloadtheMyArrayindexer:Form
    {
        public frmOverloadtheMyArrayindexer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOverloadtheMyArrayindexer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOverloadtheMyArrayindexer";
            this.Text = "frmOverloadtheMyArrayindexer";
            this.Load += new System.EventHandler(this.frmOverloadtheMyArrayindexer_Load);
            this.ResumeLayout(false);

        }

        private void frmOverloadtheMyArrayindexer_Load(object sender, EventArgs e)
        {

        }
    }
}
