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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/AllDockStylesillustration.htm
    public partial  class frmAllDockStylesillustration:Form
    {
        public frmAllDockStylesillustration()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAllDockStylesillustration
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAllDockStylesillustration";
            this.Text = "frmAllDockStylesillustration";
            this.Load += new System.EventHandler(this.frmAllDockStylesillustration_Load);
            this.ResumeLayout(false);

        }

        private void frmAllDockStylesillustration_Load(object sender, EventArgs e)
        {

        }
    }
}
