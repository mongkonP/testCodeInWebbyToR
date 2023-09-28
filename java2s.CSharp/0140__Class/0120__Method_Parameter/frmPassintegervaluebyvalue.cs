using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0120__Method_Parameter
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Passintegervaluebyvalue.htm
    public partial  class frmPassintegervaluebyvalue:Form
    {
        public frmPassintegervaluebyvalue()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPassintegervaluebyvalue
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPassintegervaluebyvalue";
            this.Text = "frmPassintegervaluebyvalue";
            this.Load += new System.EventHandler(this.frmPassintegervaluebyvalue_Load);
            this.ResumeLayout(false);

        }

        private void frmPassintegervaluebyvalue_Load(object sender, EventArgs e)
        {

        }
    }
}
