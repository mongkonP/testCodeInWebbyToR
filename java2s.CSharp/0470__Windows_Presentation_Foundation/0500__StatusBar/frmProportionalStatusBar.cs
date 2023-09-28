using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0500__StatusBar
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ProportionalStatusBar.htm
    public partial  class frmProportionalStatusBar:Form
    {
        public frmProportionalStatusBar()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmProportionalStatusBar
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmProportionalStatusBar";
            this.Text = "frmProportionalStatusBar";
            this.Load += new System.EventHandler(this.frmProportionalStatusBar_Load);
            this.ResumeLayout(false);

        }

        private void frmProportionalStatusBar_Load(object sender, EventArgs e)
        {

        }
    }
}
