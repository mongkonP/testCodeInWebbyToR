using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1160__Dock
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/DockTopandBottom.htm
    public partial  class frmDockTopandBottom:Form
    {
        public frmDockTopandBottom()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDockTopandBottom
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDockTopandBottom";
            this.Text = "frmDockTopandBottom";
            this.Load += new System.EventHandler(this.frmDockTopandBottom_Load);
            this.ResumeLayout(false);

        }

        private void frmDockTopandBottom_Load(object sender, EventArgs e)
        {

        }
    }
}
