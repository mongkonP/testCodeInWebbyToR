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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Indexerforgenerictype.htm
    public partial  class frmIndexerforgenerictype:Form
    {
        public frmIndexerforgenerictype()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIndexerforgenerictype
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIndexerforgenerictype";
            this.Text = "frmIndexerforgenerictype";
            this.Load += new System.EventHandler(this.frmIndexerforgenerictype_Load);
            this.ResumeLayout(false);

        }

        private void frmIndexerforgenerictype_Load(object sender, EventArgs e)
        {

        }
    }
}
