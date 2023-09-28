using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0880__IEnumerator
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/ImplementIEnumerableandIEnumerator.htm
    public partial  class frmImplementIEnumerableandIEnumerator:Form
    {
        public frmImplementIEnumerableandIEnumerator()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmImplementIEnumerableandIEnumerator
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmImplementIEnumerableandIEnumerator";
            this.Text = "frmImplementIEnumerableandIEnumerator";
            this.Load += new System.EventHandler(this.frmImplementIEnumerableandIEnumerator_Load);
            this.ResumeLayout(false);

        }

        private void frmImplementIEnumerableandIEnumerator_Load(object sender, EventArgs e)
        {

        }
    }
}
