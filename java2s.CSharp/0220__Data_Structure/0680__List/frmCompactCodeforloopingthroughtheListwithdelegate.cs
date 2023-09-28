using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0680__List
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/CompactCodeforloopingthroughtheListwithdelegate.htm
    public partial  class frmCompactCodeforloopingthroughtheListwithdelegate:Form
    {
        public frmCompactCodeforloopingthroughtheListwithdelegate()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCompactCodeforloopingthroughtheListwithdelegate
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCompactCodeforloopingthroughtheListwithdelegate";
            this.Text = "frmCompactCodeforloopingthroughtheListwithdelegate";
            this.Load += new System.EventHandler(this.frmCompactCodeforloopingthroughtheListwithdelegate_Load);
            this.ResumeLayout(false);

        }

        private void frmCompactCodeforloopingthroughtheListwithdelegate_Load(object sender, EventArgs e)
        {

        }
    }
}
