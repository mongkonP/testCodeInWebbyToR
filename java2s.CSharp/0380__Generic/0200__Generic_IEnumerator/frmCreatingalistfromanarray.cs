using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0200__Generic_IEnumerator
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/Creatingalistfromanarray.htm
    public partial  class frmCreatingalistfromanarray:Form
    {
        public frmCreatingalistfromanarray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatingalistfromanarray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatingalistfromanarray";
            this.Text = "frmCreatingalistfromanarray";
            this.Load += new System.EventHandler(this.frmCreatingalistfromanarray_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatingalistfromanarray_Load(object sender, EventArgs e)
        {

        }
    }
}
