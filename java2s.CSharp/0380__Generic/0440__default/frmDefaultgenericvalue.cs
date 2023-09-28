using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0440__default
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/Defaultgenericvalue.htm
    public partial  class frmDefaultgenericvalue:Form
    {
        public frmDefaultgenericvalue()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDefaultgenericvalue
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDefaultgenericvalue";
            this.Text = "frmDefaultgenericvalue";
            this.Load += new System.EventHandler(this.frmDefaultgenericvalue_Load);
            this.ResumeLayout(false);

        }

        private void frmDefaultgenericvalue_Load(object sender, EventArgs e)
        {

        }
    }
}
