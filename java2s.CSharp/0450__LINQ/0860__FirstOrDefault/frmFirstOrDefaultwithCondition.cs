using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0860__FirstOrDefault
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/FirstOrDefaultwithCondition.htm
    public partial  class frmFirstOrDefaultwithCondition:Form
    {
        public frmFirstOrDefaultwithCondition()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFirstOrDefaultwithCondition
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFirstOrDefaultwithCondition";
            this.Text = "frmFirstOrDefaultwithCondition";
            this.Load += new System.EventHandler(this.frmFirstOrDefaultwithCondition_Load);
            this.ResumeLayout(false);

        }

        private void frmFirstOrDefaultwithCondition_Load(object sender, EventArgs e)
        {

        }
    }
}
