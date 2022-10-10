using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0020__Introduction
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/UseApplicationRuntoloadwindowapplication.htm
    public partial  class frmUseApplicationRuntoloadwindowapplication:Form
    {
        public frmUseApplicationRuntoloadwindowapplication()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseApplicationRuntoloadwindowapplication
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseApplicationRuntoloadwindowapplication";
            this.Text = "frmUseApplicationRuntoloadwindowapplication";
            this.Load += new System.EventHandler(this.frmUseApplicationRuntoloadwindowapplication_Load);
            this.ResumeLayout(false);

        }

        private void frmUseApplicationRuntoloadwindowapplication_Load(object sender, EventArgs e)
        {

        }
    }
}
