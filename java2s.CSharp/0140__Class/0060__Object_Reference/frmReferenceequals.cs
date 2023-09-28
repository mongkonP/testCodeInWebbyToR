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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Referenceequals.htm
    public partial  class frmReferenceequals:Form
    {
        public frmReferenceequals()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReferenceequals
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReferenceequals";
            this.Text = "frmReferenceequals";
            this.Load += new System.EventHandler(this.frmReferenceequals_Load);
            this.ResumeLayout(false);

        }

        private void frmReferenceequals_Load(object sender, EventArgs e)
        {

        }
    }
}
