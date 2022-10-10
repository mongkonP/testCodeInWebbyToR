using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1020__Window
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SetWPFwindowwidthandheight.htm
    public partial  class frmSetWPFwindowwidthandheight:Form
    {
        public frmSetWPFwindowwidthandheight()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetWPFwindowwidthandheight
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetWPFwindowwidthandheight";
            this.Text = "frmSetWPFwindowwidthandheight";
            this.Load += new System.EventHandler(this.frmSetWPFwindowwidthandheight_Load);
            this.ResumeLayout(false);

        }

        private void frmSetWPFwindowwidthandheight_Load(object sender, EventArgs e)
        {

        }
    }
}
