using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0860__IEnumerable
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/ImplementIEnumerablewithyield.htm
    public partial  class frmImplementIEnumerablewithyield:Form
    {
        public frmImplementIEnumerablewithyield()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmImplementIEnumerablewithyield
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmImplementIEnumerablewithyield";
            this.Text = "frmImplementIEnumerablewithyield";
            this.Load += new System.EventHandler(this.frmImplementIEnumerablewithyield_Load);
            this.ResumeLayout(false);

        }

        private void frmImplementIEnumerablewithyield_Load(object sender, EventArgs e)
        {

        }
    }
}
