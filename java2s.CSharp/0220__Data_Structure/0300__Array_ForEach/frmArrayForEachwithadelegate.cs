using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0220__Data_Structure.C0300__Array_ForEach
{
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/ArrayForEachwithadelegate.htm
    public partial  class frmArrayForEachwithadelegate:Form
    {
        public frmArrayForEachwithadelegate()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmArrayForEachwithadelegate
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmArrayForEachwithadelegate";
            this.Text = "frmArrayForEachwithadelegate";
            this.Load += new System.EventHandler(this.frmArrayForEachwithadelegate_Load);
            this.ResumeLayout(false);

        }

        private void frmArrayForEachwithadelegate_Load(object sender, EventArgs e)
        {

        }
    }
}
