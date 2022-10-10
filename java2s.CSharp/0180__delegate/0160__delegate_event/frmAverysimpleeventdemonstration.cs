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
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/Averysimpleeventdemonstration.htm
    public partial  class frmAverysimpleeventdemonstration:Form
    {
        public frmAverysimpleeventdemonstration()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAverysimpleeventdemonstration
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAverysimpleeventdemonstration";
            this.Text = "frmAverysimpleeventdemonstration";
            this.Load += new System.EventHandler(this.frmAverysimpleeventdemonstration_Load);
            this.ResumeLayout(false);

        }

        private void frmAverysimpleeventdemonstration_Load(object sender, EventArgs e)
        {

        }
    }
}
