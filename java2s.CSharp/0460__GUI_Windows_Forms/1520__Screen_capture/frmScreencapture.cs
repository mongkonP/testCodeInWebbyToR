using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1520__Screen_capture
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Screencapture.htm
    public partial  class frmScreencapture:Form
    {
        public frmScreencapture()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmScreencapture
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmScreencapture";
            this.Text = "frmScreencapture";
            this.Load += new System.EventHandler(this.frmScreencapture_Load);
            this.ResumeLayout(false);

        }

        private void frmScreencapture_Load(object sender, EventArgs e)
        {

        }
    }
}
