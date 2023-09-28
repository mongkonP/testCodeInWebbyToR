using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1240__select
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Selectsumvalue.htm
    public partial  class frmSelectsumvalue:Form
    {
        public frmSelectsumvalue()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSelectsumvalue
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSelectsumvalue";
            this.Text = "frmSelectsumvalue";
            this.Load += new System.EventHandler(this.frmSelectsumvalue_Load);
            this.ResumeLayout(false);

        }

        private void frmSelectsumvalue_Load(object sender, EventArgs e)
        {

        }
    }
}
