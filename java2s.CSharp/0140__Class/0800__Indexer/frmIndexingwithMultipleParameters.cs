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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/IndexingwithMultipleParameters.htm
    public partial  class frmIndexingwithMultipleParameters:Form
    {
        public frmIndexingwithMultipleParameters()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIndexingwithMultipleParameters
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIndexingwithMultipleParameters";
            this.Text = "frmIndexingwithMultipleParameters";
            this.Load += new System.EventHandler(this.frmIndexingwithMultipleParameters_Load);
            this.ResumeLayout(false);

        }

        private void frmIndexingwithMultipleParameters_Load(object sender, EventArgs e)
        {

        }
    }
}
