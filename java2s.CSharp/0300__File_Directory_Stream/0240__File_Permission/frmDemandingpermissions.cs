using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0240__File_Permission
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Demandingpermissions.htm
    public partial  class frmDemandingpermissions:Form
    {
        public frmDemandingpermissions()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDemandingpermissions
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDemandingpermissions";
            this.Text = "frmDemandingpermissions";
            this.Load += new System.EventHandler(this.frmDemandingpermissions_Load);
            this.ResumeLayout(false);

        }

        private void frmDemandingpermissions_Load(object sender, EventArgs e)
        {

        }
    }
}
