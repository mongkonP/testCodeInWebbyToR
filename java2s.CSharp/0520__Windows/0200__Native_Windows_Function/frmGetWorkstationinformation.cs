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
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/GetWorkstationinformation.htm
    public partial  class frmGetWorkstationinformation:Form
    {
        public frmGetWorkstationinformation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetWorkstationinformation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetWorkstationinformation";
            this.Text = "frmGetWorkstationinformation";
            this.Load += new System.EventHandler(this.frmGetWorkstationinformation_Load);
            this.ResumeLayout(false);

        }

        private void frmGetWorkstationinformation_Load(object sender, EventArgs e)
        {

        }
    }
}
