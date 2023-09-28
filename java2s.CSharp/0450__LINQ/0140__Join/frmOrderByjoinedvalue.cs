using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0140__Join
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/OrderByjoinedvalue.htm
    public partial  class frmOrderByjoinedvalue:Form
    {
        public frmOrderByjoinedvalue()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOrderByjoinedvalue
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOrderByjoinedvalue";
            this.Text = "frmOrderByjoinedvalue";
            this.Load += new System.EventHandler(this.frmOrderByjoinedvalue_Load);
            this.ResumeLayout(false);

        }

        private void frmOrderByjoinedvalue_Load(object sender, EventArgs e)
        {

        }
    }
}
