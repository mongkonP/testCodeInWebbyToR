using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1840__EventTrigger
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Playingasoundwithatrigger.htm
    public partial  class frmPlayingasoundwithatrigger:Form
    {
        public frmPlayingasoundwithatrigger()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPlayingasoundwithatrigger
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPlayingasoundwithatrigger";
            this.Text = "frmPlayingasoundwithatrigger";
            this.Load += new System.EventHandler(this.frmPlayingasoundwithatrigger_Load);
            this.ResumeLayout(false);

        }

        private void frmPlayingasoundwithatrigger_Load(object sender, EventArgs e)
        {

        }
    }
}
