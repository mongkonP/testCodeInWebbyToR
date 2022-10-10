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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ThreadSleepinButtonClickhandler.htm
    public partial  class frmThreadSleepinButtonClickhandler:Form
    {
        public frmThreadSleepinButtonClickhandler()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThreadSleepinButtonClickhandler
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThreadSleepinButtonClickhandler";
            this.Text = "frmThreadSleepinButtonClickhandler";
            this.Load += new System.EventHandler(this.frmThreadSleepinButtonClickhandler_Load);
            this.ResumeLayout(false);

        }

        private void frmThreadSleepinButtonClickhandler_Load(object sender, EventArgs e)
        {

        }
    }
}
