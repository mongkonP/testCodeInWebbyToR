using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0060__Operator.C0240__is
{
    //http://www.java2s.com/Tutorial/CSharp/0060__Operator/Useistoavoidaninvalidcast.htm
    public partial  class frmUseistoavoidaninvalidcast:Form
    {
        public frmUseistoavoidaninvalidcast()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseistoavoidaninvalidcast
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseistoavoidaninvalidcast";
            this.Text = "frmUseistoavoidaninvalidcast";
            this.Load += new System.EventHandler(this.frmUseistoavoidaninvalidcast_Load);
            this.ResumeLayout(false);

        }

        private void frmUseistoavoidaninvalidcast_Load(object sender, EventArgs e)
        {

        }
    }
}
