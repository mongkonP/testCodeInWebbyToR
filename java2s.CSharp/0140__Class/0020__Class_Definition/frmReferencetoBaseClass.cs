using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0020__Class_Definition
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/ReferencetoBaseClass.htm
    public partial  class frmReferencetoBaseClass:Form
    {
        public frmReferencetoBaseClass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReferencetoBaseClass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReferencetoBaseClass";
            this.Text = "frmReferencetoBaseClass";
            this.Load += new System.EventHandler(this.frmReferencetoBaseClass_Load);
            this.ResumeLayout(false);

        }

        private void frmReferencetoBaseClass_Load(object sender, EventArgs e)
        {

        }
    }
}
