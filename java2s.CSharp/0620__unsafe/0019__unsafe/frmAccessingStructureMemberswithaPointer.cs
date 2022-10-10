using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0620__unsafe.C0019__unsafe
{
    //http://www.java2s.com/Tutorial/CSharp/0620__unsafe/AccessingStructureMemberswithaPointer.htm
    public partial  class frmAccessingStructureMemberswithaPointer:Form
    {
        public frmAccessingStructureMemberswithaPointer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAccessingStructureMemberswithaPointer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAccessingStructureMemberswithaPointer";
            this.Text = "frmAccessingStructureMemberswithaPointer";
            this.Load += new System.EventHandler(this.frmAccessingStructureMemberswithaPointer_Load);
            this.ResumeLayout(false);

        }

        private void frmAccessingStructureMemberswithaPointer_Load(object sender, EventArgs e)
        {

        }
    }
}
