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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/IndexingwithanIntegerIndexer.htm
    public partial  class frmIndexingwithanIntegerIndexer:Form
    {
        public frmIndexingwithanIntegerIndexer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIndexingwithanIntegerIndexer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIndexingwithanIntegerIndexer";
            this.Text = "frmIndexingwithanIntegerIndexer";
            this.Load += new System.EventHandler(this.frmIndexingwithanIntegerIndexer_Load);
            this.ResumeLayout(false);

        }

        private void frmIndexingwithanIntegerIndexer_Load(object sender, EventArgs e)
        {

        }
    }
}
