using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1120__Popup
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/RotatingPopup.htm
    public partial  class frmRotatingPopup:Form
    {
        public frmRotatingPopup()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRotatingPopup
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRotatingPopup";
            this.Text = "frmRotatingPopup";
            this.Load += new System.EventHandler(this.frmRotatingPopup_Load);
            this.ResumeLayout(false);

        }

        private void frmRotatingPopup_Load(object sender, EventArgs e)
        {

        }
    }
}
