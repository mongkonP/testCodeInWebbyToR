using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0160__Interface
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/TypeIsNestedPrivateIsNestedPublic.htm
    public partial  class frmTypeIsNestedPrivateIsNestedPublic:Form
    {
        public frmTypeIsNestedPrivateIsNestedPublic()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTypeIsNestedPrivateIsNestedPublic
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTypeIsNestedPrivateIsNestedPublic";
            this.Text = "frmTypeIsNestedPrivateIsNestedPublic";
            this.Load += new System.EventHandler(this.frmTypeIsNestedPrivateIsNestedPublic_Load);
            this.ResumeLayout(false);

        }

        private void frmTypeIsNestedPrivateIsNestedPublic_Load(object sender, EventArgs e)
        {

        }
    }
}
