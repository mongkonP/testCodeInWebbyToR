using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C1300__Single
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Singlewithobjectlist.htm
    public partial  class frmSinglewithobjectlist:Form
    {
        public frmSinglewithobjectlist()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSinglewithobjectlist
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSinglewithobjectlist";
            this.Text = "frmSinglewithobjectlist";
            this.Load += new System.EventHandler(this.frmSinglewithobjectlist_Load);
            this.ResumeLayout(false);

        }

        private void frmSinglewithobjectlist_Load(object sender, EventArgs e)
        {

        }
    }
}
