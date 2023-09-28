using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1021__Window_Event
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/WindowOnMousemoveevent.htm
    public partial  class frmWindowOnMousemoveevent:Form
    {
        public frmWindowOnMousemoveevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWindowOnMousemoveevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWindowOnMousemoveevent";
            this.Text = "frmWindowOnMousemoveevent";
            this.Load += new System.EventHandler(this.frmWindowOnMousemoveevent_Load);
            this.ResumeLayout(false);

        }

        private void frmWindowOnMousemoveevent_Load(object sender, EventArgs e)
        {

        }
    }
}
