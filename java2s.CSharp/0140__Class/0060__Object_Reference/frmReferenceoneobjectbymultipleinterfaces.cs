using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0060__Object_Reference
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Referenceoneobjectbymultipleinterfaces.htm
    public partial  class frmReferenceoneobjectbymultipleinterfaces:Form
    {
        public frmReferenceoneobjectbymultipleinterfaces()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReferenceoneobjectbymultipleinterfaces
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReferenceoneobjectbymultipleinterfaces";
            this.Text = "frmReferenceoneobjectbymultipleinterfaces";
            this.Load += new System.EventHandler(this.frmReferenceoneobjectbymultipleinterfaces_Load);
            this.ResumeLayout(false);

        }

        private void frmReferenceoneobjectbymultipleinterfaces_Load(object sender, EventArgs e)
        {

        }
    }
}
