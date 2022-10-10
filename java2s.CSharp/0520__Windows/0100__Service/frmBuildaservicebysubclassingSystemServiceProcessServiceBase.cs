using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0100__Service
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/BuildaservicebysubclassingSystemServiceProcessServiceBase.htm
    public partial  class frmBuildaservicebysubclassingSystemServiceProcessServiceBase:Form
    {
        public frmBuildaservicebysubclassingSystemServiceProcessServiceBase()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBuildaservicebysubclassingSystemServiceProcessServiceBase
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBuildaservicebysubclassingSystemServiceProcessServiceBase";
            this.Text = "frmBuildaservicebysubclassingSystemServiceProcessServiceBase";
            this.Load += new System.EventHandler(this.frmBuildaservicebysubclassingSystemServiceProcessServiceBase_Load);
            this.ResumeLayout(false);

        }

        private void frmBuildaservicebysubclassingSystemServiceProcessServiceBase_Load(object sender, EventArgs e)
        {

        }
    }
}
