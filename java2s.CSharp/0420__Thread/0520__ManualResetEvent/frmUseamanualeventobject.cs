using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0520__ManualResetEvent
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Useamanualeventobject.htm
    public partial  class frmUseamanualeventobject:Form
    {
        public frmUseamanualeventobject()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseamanualeventobject
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseamanualeventobject";
            this.Text = "frmUseamanualeventobject";
            this.Load += new System.EventHandler(this.frmUseamanualeventobject_Load);
            this.ResumeLayout(false);

        }

        private void frmUseamanualeventobject_Load(object sender, EventArgs e)
        {

        }
    }
}
