using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1960__Application
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ApplicationNavigationFailedevent.htm
    public partial  class frmApplicationNavigationFailedevent:Form
    {
        public frmApplicationNavigationFailedevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmApplicationNavigationFailedevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmApplicationNavigationFailedevent";
            this.Text = "frmApplicationNavigationFailedevent";
            this.Load += new System.EventHandler(this.frmApplicationNavigationFailedevent_Load);
            this.ResumeLayout(false);

        }

        private void frmApplicationNavigationFailedevent_Load(object sender, EventArgs e)
        {

        }
    }
}
