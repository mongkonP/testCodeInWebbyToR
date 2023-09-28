using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0720__enum_format
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/Formatanenumeration.htm
    public partial  class frmFormatanenumeration:Form
    {
        public frmFormatanenumeration()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFormatanenumeration
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFormatanenumeration";
            this.Text = "frmFormatanenumeration";
            this.Load += new System.EventHandler(this.frmFormatanenumeration_Load);
            this.ResumeLayout(false);

        }

        private void frmFormatanenumeration_Load(object sender, EventArgs e)
        {

        }
    }
}
