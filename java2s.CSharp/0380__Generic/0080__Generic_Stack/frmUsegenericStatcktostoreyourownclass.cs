using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0080__Generic_Stack
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/UsegenericStatcktostoreyourownclass.htm
    public partial  class frmUsegenericStatcktostoreyourownclass:Form
    {
        public frmUsegenericStatcktostoreyourownclass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsegenericStatcktostoreyourownclass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsegenericStatcktostoreyourownclass";
            this.Text = "frmUsegenericStatcktostoreyourownclass";
            this.Load += new System.EventHandler(this.frmUsegenericStatcktostoreyourownclass_Load);
            this.ResumeLayout(false);

        }

        private void frmUsegenericStatcktostoreyourownclass_Load(object sender, EventArgs e)
        {

        }
    }
}
