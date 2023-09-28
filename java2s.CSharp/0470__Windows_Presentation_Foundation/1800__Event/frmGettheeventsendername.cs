using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1800__Event
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Gettheeventsendername.htm
    public partial  class frmGettheeventsendername:Form
    {
        public frmGettheeventsendername()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGettheeventsendername
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGettheeventsendername";
            this.Text = "frmGettheeventsendername";
            this.Load += new System.EventHandler(this.frmGettheeventsendername_Load);
            this.ResumeLayout(false);

        }

        private void frmGettheeventsendername_Load(object sender, EventArgs e)
        {

        }
    }
}
