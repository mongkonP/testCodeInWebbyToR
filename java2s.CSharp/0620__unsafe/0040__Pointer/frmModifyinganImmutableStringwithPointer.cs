using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0620__unsafe.C0040__Pointer
{
    //http://www.java2s.com/Tutorial/CSharp/0620__unsafe/ModifyinganImmutableStringwithPointer.htm
    public partial  class frmModifyinganImmutableStringwithPointer:Form
    {
        public frmModifyinganImmutableStringwithPointer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmModifyinganImmutableStringwithPointer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmModifyinganImmutableStringwithPointer";
            this.Text = "frmModifyinganImmutableStringwithPointer";
            this.Load += new System.EventHandler(this.frmModifyinganImmutableStringwithPointer_Load);
            this.ResumeLayout(false);

        }

        private void frmModifyinganImmutableStringwithPointer_Load(object sender, EventArgs e)
        {

        }
    }
}
