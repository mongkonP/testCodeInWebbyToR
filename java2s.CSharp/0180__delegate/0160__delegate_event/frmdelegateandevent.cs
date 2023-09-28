using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0180__delegate.C0160__delegate_event
{
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/delegateandevent.htm
    public partial  class frmdelegateandevent:Form
    {
        public frmdelegateandevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmdelegateandevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmdelegateandevent";
            this.Text = "frmdelegateandevent";
            this.Load += new System.EventHandler(this.frmdelegateandevent_Load);
            this.ResumeLayout(false);

        }

        private void frmdelegateandevent_Load(object sender, EventArgs e)
        {

        }
    }
}
