using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0220__DLL
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/CallDLLAPItomovefile.htm
    public partial  class frmCallDLLAPItomovefile:Form
    {
        public frmCallDLLAPItomovefile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCallDLLAPItomovefile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCallDLLAPItomovefile";
            this.Text = "frmCallDLLAPItomovefile";
            this.Load += new System.EventHandler(this.frmCallDLLAPItomovefile_Load);
            this.ResumeLayout(false);

        }

        private void frmCallDLLAPItomovefile_Load(object sender, EventArgs e)
        {

        }
    }
}
