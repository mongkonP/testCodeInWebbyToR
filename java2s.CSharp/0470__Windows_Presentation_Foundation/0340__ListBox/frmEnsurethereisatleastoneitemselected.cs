using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0340__ListBox
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Ensurethereisatleastoneitemselected.htm
    public partial  class frmEnsurethereisatleastoneitemselected:Form
    {
        public frmEnsurethereisatleastoneitemselected()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEnsurethereisatleastoneitemselected
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEnsurethereisatleastoneitemselected";
            this.Text = "frmEnsurethereisatleastoneitemselected";
            this.Load += new System.EventHandler(this.frmEnsurethereisatleastoneitemselected_Load);
            this.ResumeLayout(false);

        }

        private void frmEnsurethereisatleastoneitemselected_Load(object sender, EventArgs e)
        {

        }
    }
}
