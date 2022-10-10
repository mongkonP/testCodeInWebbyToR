using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2580__SoundPlayerAction
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Playaudiothrougheventtrigger.htm
    public partial  class frmPlayaudiothrougheventtrigger:Form
    {
        public frmPlayaudiothrougheventtrigger()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPlayaudiothrougheventtrigger
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPlayaudiothrougheventtrigger";
            this.Text = "frmPlayaudiothrougheventtrigger";
            this.Load += new System.EventHandler(this.frmPlayaudiothrougheventtrigger_Load);
            this.ResumeLayout(false);

        }

        private void frmPlayaudiothrougheventtrigger_Load(object sender, EventArgs e)
        {

        }
    }
}
