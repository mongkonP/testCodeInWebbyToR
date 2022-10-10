using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1640__ActiveX
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/UseActiveXcontrol.htm
    public partial  class frmUseActiveXcontrol:Form
    {
        public frmUseActiveXcontrol()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseActiveXcontrol
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseActiveXcontrol";
            this.Text = "frmUseActiveXcontrol";
            this.Load += new System.EventHandler(this.frmUseActiveXcontrol_Load);
            this.ResumeLayout(false);

        }

        private void frmUseActiveXcontrol_Load(object sender, EventArgs e)
        {

        }
    }
}
