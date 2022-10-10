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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Jointhreeobjectlist.htm
    public partial  class frmJointhreeobjectlist:Form
    {
        public frmJointhreeobjectlist()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmJointhreeobjectlist
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmJointhreeobjectlist";
            this.Text = "frmJointhreeobjectlist";
            this.Load += new System.EventHandler(this.frmJointhreeobjectlist_Load);
            this.ResumeLayout(false);

        }

        private void frmJointhreeobjectlist_Load(object sender, EventArgs e)
        {

        }
    }
}
