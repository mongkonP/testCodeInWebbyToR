using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C1122__IEnumerator
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/ImplementsIEnumerator.htm
    public partial  class frmImplementsIEnumerator:Form
    {
        public frmImplementsIEnumerator()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmImplementsIEnumerator
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmImplementsIEnumerator";
            this.Text = "frmImplementsIEnumerator";
            this.Load += new System.EventHandler(this.frmImplementsIEnumerator_Load);
            this.ResumeLayout(false);

        }

        private void frmImplementsIEnumerator_Load(object sender, EventArgs e)
        {

        }
    }
}
