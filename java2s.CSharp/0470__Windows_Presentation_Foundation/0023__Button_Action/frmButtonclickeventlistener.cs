using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0023__Button_Action
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Buttonclickeventlistener.htm
    public partial  class frmButtonclickeventlistener:Form
    {
        public frmButtonclickeventlistener()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmButtonclickeventlistener
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmButtonclickeventlistener";
            this.Text = "frmButtonclickeventlistener";
            this.Load += new System.EventHandler(this.frmButtonclickeventlistener_Load);
            this.ResumeLayout(false);

        }

        private void frmButtonclickeventlistener_Load(object sender, EventArgs e)
        {

        }
    }
}
