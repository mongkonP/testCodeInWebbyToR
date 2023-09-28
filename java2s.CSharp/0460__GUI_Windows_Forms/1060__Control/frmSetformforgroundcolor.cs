using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1060__Control
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Setformforgroundcolor.htm
    public partial  class frmSetformforgroundcolor:Form
    {
        public frmSetformforgroundcolor()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetformforgroundcolor
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetformforgroundcolor";
            this.Text = "frmSetformforgroundcolor";
            this.Load += new System.EventHandler(this.frmSetformforgroundcolor_Load);
            this.ResumeLayout(false);

        }

        private void frmSetformforgroundcolor_Load(object sender, EventArgs e)
        {

        }
    }
}
