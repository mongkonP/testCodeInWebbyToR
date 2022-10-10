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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CreateaProgressBar.htm
    public partial  class frmCreateaProgressBar:Form
    {
        public frmCreateaProgressBar()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateaProgressBar
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateaProgressBar";
            this.Text = "frmCreateaProgressBar";
            this.Load += new System.EventHandler(this.frmCreateaProgressBar_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateaProgressBar_Load(object sender, EventArgs e)
        {

        }
    }
}
