using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0140__Join
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/SimpleJoin.htm
    public partial  class frmSimpleJoin:Form
    {
        public frmSimpleJoin()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleJoin
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleJoin";
            this.Text = "frmSimpleJoin";
            this.Load += new System.EventHandler(this.frmSimpleJoin_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleJoin_Load(object sender, EventArgs e)
        {

        }
    }
}
