using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0420__ToDictionary
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/ToDictionarywithIEqualityComparer.htm
    public partial  class frmToDictionarywithIEqualityComparer:Form
    {
        public frmToDictionarywithIEqualityComparer()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmToDictionarywithIEqualityComparer
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmToDictionarywithIEqualityComparer";
            this.Text = "frmToDictionarywithIEqualityComparer";
            this.Load += new System.EventHandler(this.frmToDictionarywithIEqualityComparer_Load);
            this.ResumeLayout(false);

        }

        private void frmToDictionarywithIEqualityComparer_Load(object sender, EventArgs e)
        {

        }
    }
}
