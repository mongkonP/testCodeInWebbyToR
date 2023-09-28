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
    //http://www.java2s.com/Tutorial/CSharp/0220__Data-Structure/UsingtheActionTdelegate.htm
    public partial  class frmUsingtheActionTdelegate:Form
    {
        public frmUsingtheActionTdelegate()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingtheActionTdelegate
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingtheActionTdelegate";
            this.Text = "frmUsingtheActionTdelegate";
            this.Load += new System.EventHandler(this.frmUsingtheActionTdelegate_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingtheActionTdelegate_Load(object sender, EventArgs e)
        {

        }
    }
}
