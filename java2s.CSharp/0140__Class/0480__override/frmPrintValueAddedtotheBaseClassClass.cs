using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0480__override
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/PrintValueAddedtotheBaseClassClass.htm
    public partial  class frmPrintValueAddedtotheBaseClassClass:Form
    {
        public frmPrintValueAddedtotheBaseClassClass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPrintValueAddedtotheBaseClassClass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPrintValueAddedtotheBaseClassClass";
            this.Text = "frmPrintValueAddedtotheBaseClassClass";
            this.Load += new System.EventHandler(this.frmPrintValueAddedtotheBaseClassClass_Load);
            this.ResumeLayout(false);

        }

        private void frmPrintValueAddedtotheBaseClassClass_Load(object sender, EventArgs e)
        {

        }
    }
}
