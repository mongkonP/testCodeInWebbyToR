using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0280__Office
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/CreateOfficeApplications.htm
    public partial  class frmCreateOfficeApplications:Form
    {
        public frmCreateOfficeApplications()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateOfficeApplications
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateOfficeApplications";
            this.Text = "frmCreateOfficeApplications";
            this.Load += new System.EventHandler(this.frmCreateOfficeApplications_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateOfficeApplications_Load(object sender, EventArgs e)
        {

        }
    }
}
