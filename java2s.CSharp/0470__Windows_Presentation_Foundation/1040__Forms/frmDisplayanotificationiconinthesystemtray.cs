using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1040__Forms
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Displayanotificationiconinthesystemtray.htm
    public partial  class frmDisplayanotificationiconinthesystemtray:Form
    {
        public frmDisplayanotificationiconinthesystemtray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplayanotificationiconinthesystemtray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplayanotificationiconinthesystemtray";
            this.Text = "frmDisplayanotificationiconinthesystemtray";
            this.Load += new System.EventHandler(this.frmDisplayanotificationiconinthesystemtray_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplayanotificationiconinthesystemtray_Load(object sender, EventArgs e)
        {

        }
    }
}
