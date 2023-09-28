using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0200__Native_Windows_Function
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/GetMonitorInformation.htm
    public partial  class frmGetMonitorInformation:Form
    {
        public frmGetMonitorInformation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetMonitorInformation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetMonitorInformation";
            this.Text = "frmGetMonitorInformation";
            this.Load += new System.EventHandler(this.frmGetMonitorInformation_Load);
            this.ResumeLayout(false);

        }

        private void frmGetMonitorInformation_Load(object sender, EventArgs e)
        {

        }
    }
}
