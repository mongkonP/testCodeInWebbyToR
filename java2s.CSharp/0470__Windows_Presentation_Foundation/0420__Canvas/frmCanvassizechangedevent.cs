using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0420__Canvas
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Canvassizechangedevent.htm
    public partial  class frmCanvassizechangedevent:Form
    {
        public frmCanvassizechangedevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCanvassizechangedevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCanvassizechangedevent";
            this.Text = "frmCanvassizechangedevent";
            this.Load += new System.EventHandler(this.frmCanvassizechangedevent_Load);
            this.ResumeLayout(false);

        }

        private void frmCanvassizechangedevent_Load(object sender, EventArgs e)
        {

        }
    }
}
