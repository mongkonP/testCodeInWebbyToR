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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Selectarrayitembytype.htm
    public partial  class frmSelectarrayitembytype:Form
    {
        public frmSelectarrayitembytype()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSelectarrayitembytype
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSelectarrayitembytype";
            this.Text = "frmSelectarrayitembytype";
            this.Load += new System.EventHandler(this.frmSelectarrayitembytype_Load);
            this.ResumeLayout(false);

        }

        private void frmSelectarrayitembytype_Load(object sender, EventArgs e)
        {

        }
    }
}
