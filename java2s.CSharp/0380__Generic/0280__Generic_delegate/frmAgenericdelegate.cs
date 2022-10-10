using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0280__Generic_delegate
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/Agenericdelegate.htm
    public partial  class frmAgenericdelegate:Form
    {
        public frmAgenericdelegate()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAgenericdelegate
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAgenericdelegate";
            this.Text = "frmAgenericdelegate";
            this.Load += new System.EventHandler(this.frmAgenericdelegate_Load);
            this.ResumeLayout(false);

        }

        private void frmAgenericdelegate_Load(object sender, EventArgs e)
        {

        }
    }
}
