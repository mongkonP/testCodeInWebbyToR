using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0940__ColorDialog
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Setdefaultcolor.htm
    public partial  class frmSetdefaultcolor:Form
    {
        public frmSetdefaultcolor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetdefaultcolor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetdefaultcolor";
            this.Text = "frmSetdefaultcolor";
            this.Load += new System.EventHandler(this.frmSetdefaultcolor_Load);
            this.ResumeLayout(false);

        }

        private void frmSetdefaultcolor_Load(object sender, EventArgs e)
        {

        }
    }
}
