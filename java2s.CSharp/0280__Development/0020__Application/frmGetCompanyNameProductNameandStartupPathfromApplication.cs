using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0020__Application
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/GetCompanyNameProductNameandStartupPathfromApplication.htm
    public partial  class frmGetCompanyNameProductNameandStartupPathfromApplication:Form
    {
        public frmGetCompanyNameProductNameandStartupPathfromApplication()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetCompanyNameProductNameandStartupPathfromApplication
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetCompanyNameProductNameandStartupPathfromApplication";
            this.Text = "frmGetCompanyNameProductNameandStartupPathfromApplication";
            this.Load += new System.EventHandler(this.frmGetCompanyNameProductNameandStartupPathfromApplication_Load);
            this.ResumeLayout(false);

        }

        private void frmGetCompanyNameProductNameandStartupPathfromApplication_Load(object sender, EventArgs e)
        {

        }
    }
}
