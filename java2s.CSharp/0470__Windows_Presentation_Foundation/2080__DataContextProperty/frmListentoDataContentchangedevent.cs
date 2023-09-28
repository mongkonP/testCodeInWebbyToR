using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2080__DataContextProperty
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ListentoDataContentchangedevent.htm
    public partial  class frmListentoDataContentchangedevent:Form
    {
        public frmListentoDataContentchangedevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListentoDataContentchangedevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListentoDataContentchangedevent";
            this.Text = "frmListentoDataContentchangedevent";
            this.Load += new System.EventHandler(this.frmListentoDataContentchangedevent_Load);
            this.ResumeLayout(false);

        }

        private void frmListentoDataContentchangedevent_Load(object sender, EventArgs e)
        {

        }
    }
}
