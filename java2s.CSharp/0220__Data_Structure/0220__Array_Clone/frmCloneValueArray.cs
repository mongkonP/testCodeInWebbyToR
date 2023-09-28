using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0220__Array_Clone
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/CloneValueArray.htm
    public partial  class frmCloneValueArray:Form
    {
        public frmCloneValueArray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCloneValueArray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCloneValueArray";
            this.Text = "frmCloneValueArray";
            this.Load += new System.EventHandler(this.frmCloneValueArray_Load);
            this.ResumeLayout(false);

        }

        private void frmCloneValueArray_Load(object sender, EventArgs e)
        {

        }
    }
}
