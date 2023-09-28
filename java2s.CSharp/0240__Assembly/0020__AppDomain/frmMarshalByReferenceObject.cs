using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0240__Assembly.C0020__AppDomain
{
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/MarshalByReferenceObject.htm
    public partial  class frmMarshalByReferenceObject:Form
    {
        public frmMarshalByReferenceObject()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMarshalByReferenceObject
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMarshalByReferenceObject";
            this.Text = "frmMarshalByReferenceObject";
            this.Load += new System.EventHandler(this.frmMarshalByReferenceObject_Load);
            this.ResumeLayout(false);

        }

        private void frmMarshalByReferenceObject_Load(object sender, EventArgs e)
        {

        }
    }
}
