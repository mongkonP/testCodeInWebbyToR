using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0220__Thread_State
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/UseIsAlivetowaitforthreadstoend.htm
    public partial  class frmUseIsAlivetowaitforthreadstoend:Form
    {
        public frmUseIsAlivetowaitforthreadstoend()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseIsAlivetowaitforthreadstoend
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseIsAlivetowaitforthreadstoend";
            this.Text = "frmUseIsAlivetowaitforthreadstoend";
            this.Load += new System.EventHandler(this.frmUseIsAlivetowaitforthreadstoend_Load);
            this.ResumeLayout(false);

        }

        private void frmUseIsAlivetowaitforthreadstoend_Load(object sender, EventArgs e)
        {

        }
    }
}
