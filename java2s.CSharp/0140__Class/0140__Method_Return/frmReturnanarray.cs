using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0140__Method_Return
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Returnanarray.htm
    public partial  class frmReturnanarray:Form
    {
        public frmReturnanarray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReturnanarray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReturnanarray";
            this.Text = "frmReturnanarray";
            this.Load += new System.EventHandler(this.frmReturnanarray_Load);
            this.ResumeLayout(false);

        }

        private void frmReturnanarray_Load(object sender, EventArgs e)
        {

        }
    }
}
