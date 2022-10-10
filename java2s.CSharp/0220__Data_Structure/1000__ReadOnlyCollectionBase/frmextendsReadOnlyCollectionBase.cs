using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C1000__ReadOnlyCollectionBase
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/extendsReadOnlyCollectionBase.htm
    public partial  class frmextendsReadOnlyCollectionBase:Form
    {
        public frmextendsReadOnlyCollectionBase()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmextendsReadOnlyCollectionBase
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmextendsReadOnlyCollectionBase";
            this.Text = "frmextendsReadOnlyCollectionBase";
            this.Load += new System.EventHandler(this.frmextendsReadOnlyCollectionBase_Load);
            this.ResumeLayout(false);

        }

        private void frmextendsReadOnlyCollectionBase_Load(object sender, EventArgs e)
        {

        }
    }
}
