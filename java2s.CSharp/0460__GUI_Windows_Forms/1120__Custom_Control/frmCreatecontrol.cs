using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1120__Custom_Control
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Createcontrol.htm
    public partial  class frmCreatecontrol:Form
    {
        public frmCreatecontrol()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatecontrol
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatecontrol";
            this.Text = "frmCreatecontrol";
            this.Load += new System.EventHandler(this.frmCreatecontrol_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatecontrol_Load(object sender, EventArgs e)
        {

        }
    }
}
