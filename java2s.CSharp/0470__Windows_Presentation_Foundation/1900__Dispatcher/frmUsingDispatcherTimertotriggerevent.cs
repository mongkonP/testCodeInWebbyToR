using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1900__Dispatcher
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UsingDispatcherTimertotriggerevent.htm
    public partial  class frmUsingDispatcherTimertotriggerevent:Form
    {
        public frmUsingDispatcherTimertotriggerevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingDispatcherTimertotriggerevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingDispatcherTimertotriggerevent";
            this.Text = "frmUsingDispatcherTimertotriggerevent";
            this.Load += new System.EventHandler(this.frmUsingDispatcherTimertotriggerevent_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingDispatcherTimertotriggerevent_Load(object sender, EventArgs e)
        {

        }
    }
}
