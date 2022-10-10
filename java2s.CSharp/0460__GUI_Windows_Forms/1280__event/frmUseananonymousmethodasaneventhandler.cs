using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1280__event
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Useananonymousmethodasaneventhandler.htm
    public partial  class frmUseananonymousmethodasaneventhandler:Form
    {
        public frmUseananonymousmethodasaneventhandler()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseananonymousmethodasaneventhandler
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseananonymousmethodasaneventhandler";
            this.Text = "frmUseananonymousmethodasaneventhandler";
            this.Load += new System.EventHandler(this.frmUseananonymousmethodasaneventhandler_Load);
            this.ResumeLayout(false);

        }

        private void frmUseananonymousmethodasaneventhandler_Load(object sender, EventArgs e)
        {

        }
    }
}
