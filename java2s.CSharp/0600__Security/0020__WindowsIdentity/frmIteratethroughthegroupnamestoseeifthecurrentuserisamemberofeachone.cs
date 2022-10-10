using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0020__WindowsIdentity
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/Iteratethroughthegroupnamestoseeifthecurrentuserisamemberofeachone.htm
    public partial  class frmIteratethroughthegroupnamestoseeifthecurrentuserisamemberofeachone:Form
    {
        public frmIteratethroughthegroupnamestoseeifthecurrentuserisamemberofeachone()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIteratethroughthegroupnamestoseeifthecurrentuserisamemberofeachone
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIteratethroughthegroupnamestoseeifthecurrentuserisamemberofeachone";
            this.Text = "frmIteratethroughthegroupnamestoseeifthecurrentuserisamemberofeachone";
            this.Load += new System.EventHandler(this.frmIteratethroughthegroupnamestoseeifthecurrentuserisamemberofeachone_Load);
            this.ResumeLayout(false);

        }

        private void frmIteratethroughthegroupnamestoseeifthecurrentuserisamemberofeachone_Load(object sender, EventArgs e)
        {

        }
    }
}
