using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0120__struct.C0060__Constructor
{
    //http://www.java2s.com/Tutorial/CSharp/0120__struct/Usemethodtoinitstructmembervariables.htm
    public partial  class frmUsemethodtoinitstructmembervariables:Form
    {
        public frmUsemethodtoinitstructmembervariables()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsemethodtoinitstructmembervariables
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsemethodtoinitstructmembervariables";
            this.Text = "frmUsemethodtoinitstructmembervariables";
            this.Load += new System.EventHandler(this.frmUsemethodtoinitstructmembervariables_Load);
            this.ResumeLayout(false);

        }

        private void frmUsemethodtoinitstructmembervariables_Load(object sender, EventArgs e)
        {

        }
    }
}
