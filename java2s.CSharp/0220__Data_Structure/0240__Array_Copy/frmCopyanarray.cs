using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0240__Array_Copy
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/Copyanarray.htm
    public partial  class frmCopyanarray:Form
    {
        public frmCopyanarray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCopyanarray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCopyanarray";
            this.Text = "frmCopyanarray";
            this.Load += new System.EventHandler(this.frmCopyanarray_Load);
            this.ResumeLayout(false);

        }

        private void frmCopyanarray_Load(object sender, EventArgs e)
        {

        }
    }
}
