using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1400__Take
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Takemethod.htm
    public partial  class frmTakemethod:Form
    {
        public frmTakemethod()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTakemethod
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTakemethod";
            this.Text = "frmTakemethod";
            this.Load += new System.EventHandler(this.frmTakemethod_Load);
            this.ResumeLayout(false);

        }

        private void frmTakemethod_Load(object sender, EventArgs e)
        {

        }
    }
}
