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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Buttonmousedownevent.htm
    public partial  class frmButtonmousedownevent:Form
    {
        public frmButtonmousedownevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmButtonmousedownevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmButtonmousedownevent";
            this.Text = "frmButtonmousedownevent";
            this.Load += new System.EventHandler(this.frmButtonmousedownevent_Load);
            this.ResumeLayout(false);

        }

        private void frmButtonmousedownevent_Load(object sender, EventArgs e)
        {

        }
    }
}
