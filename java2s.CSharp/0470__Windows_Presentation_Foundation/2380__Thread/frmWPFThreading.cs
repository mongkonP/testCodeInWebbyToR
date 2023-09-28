using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2380__Thread
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/WPFThreading.htm
    public partial  class frmWPFThreading:Form
    {
        public frmWPFThreading()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWPFThreading
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWPFThreading";
            this.Text = "frmWPFThreading";
            this.Load += new System.EventHandler(this.frmWPFThreading_Load);
            this.ResumeLayout(false);

        }

        private void frmWPFThreading_Load(object sender, EventArgs e)
        {

        }
    }
}
