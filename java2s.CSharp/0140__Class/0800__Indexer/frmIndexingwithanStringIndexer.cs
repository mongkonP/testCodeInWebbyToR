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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/IndexingwithanStringIndexer.htm
    public partial  class frmIndexingwithanStringIndexer:Form
    {
        public frmIndexingwithanStringIndexer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIndexingwithanStringIndexer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIndexingwithanStringIndexer";
            this.Text = "frmIndexingwithanStringIndexer";
            this.Load += new System.EventHandler(this.frmIndexingwithanStringIndexer_Load);
            this.ResumeLayout(false);

        }

        private void frmIndexingwithanStringIndexer_Load(object sender, EventArgs e)
        {

        }
    }
}
