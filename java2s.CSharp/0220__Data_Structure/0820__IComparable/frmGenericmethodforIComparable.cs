using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0820__IComparable
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/GenericmethodforIComparable.htm
    public partial  class frmGenericmethodforIComparable:Form
    {
        public frmGenericmethodforIComparable()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGenericmethodforIComparable
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGenericmethodforIComparable";
            this.Text = "frmGenericmethodforIComparable";
            this.Load += new System.EventHandler(this.frmGenericmethodforIComparable_Load);
            this.ResumeLayout(false);

        }

        private void frmGenericmethodforIComparable_Load(object sender, EventArgs e)
        {

        }
    }
}
