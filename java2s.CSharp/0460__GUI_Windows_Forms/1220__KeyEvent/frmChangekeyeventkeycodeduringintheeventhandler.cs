using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1220__KeyEvent
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Changekeyeventkeycodeduringintheeventhandler.htm
    public partial  class frmChangekeyeventkeycodeduringintheeventhandler:Form
    {
        public frmChangekeyeventkeycodeduringintheeventhandler()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmChangekeyeventkeycodeduringintheeventhandler
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmChangekeyeventkeycodeduringintheeventhandler";
            this.Text = "frmChangekeyeventkeycodeduringintheeventhandler";
            this.Load += new System.EventHandler(this.frmChangekeyeventkeycodeduringintheeventhandler_Load);
            this.ResumeLayout(false);

        }

        private void frmChangekeyeventkeycodeduringintheeventhandler_Load(object sender, EventArgs e)
        {

        }
    }
}
