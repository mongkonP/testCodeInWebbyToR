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
    //http://www.java2s.com/Tutorial/CSharp/0620__unsafe/DeclaringaPointer.htm
    public partial  class frmDeclaringaPointer:Form
    {
        public frmDeclaringaPointer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDeclaringaPointer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDeclaringaPointer";
            this.Text = "frmDeclaringaPointer";
            this.Load += new System.EventHandler(this.frmDeclaringaPointer_Load);
            this.ResumeLayout(false);

        }

        private void frmDeclaringaPointer_Load(object sender, EventArgs e)
        {

        }
    }
}
