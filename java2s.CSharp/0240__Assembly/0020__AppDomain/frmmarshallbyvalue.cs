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
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/marshallbyvalue.htm
    public partial  class frmmarshallbyvalue:Form
    {
        public frmmarshallbyvalue()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmmarshallbyvalue
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmmarshallbyvalue";
            this.Text = "frmmarshallbyvalue";
            this.Load += new System.EventHandler(this.frmmarshallbyvalue_Load);
            this.ResumeLayout(false);

        }

        private void frmmarshallbyvalue_Load(object sender, EventArgs e)
        {

        }
    }
}
