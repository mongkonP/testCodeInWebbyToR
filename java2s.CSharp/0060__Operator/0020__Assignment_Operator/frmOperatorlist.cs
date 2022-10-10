using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0060__Operator.C0020__Assignment_Operator
{
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/Operatorlist.htm
    public partial  class frmOperatorlist:Form
    {
        public frmOperatorlist()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOperatorlist
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOperatorlist";
            this.Text = "frmOperatorlist";
            this.Load += new System.EventHandler(this.frmOperatorlist_Load);
            this.ResumeLayout(false);

        }

        private void frmOperatorlist_Load(object sender, EventArgs e)
        {

        }
    }
}
