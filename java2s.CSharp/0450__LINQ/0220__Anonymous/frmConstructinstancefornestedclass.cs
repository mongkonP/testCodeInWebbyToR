using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0220__Anonymous
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Constructinstancefornestedclass.htm
    public partial  class frmConstructinstancefornestedclass:Form
    {
        public frmConstructinstancefornestedclass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmConstructinstancefornestedclass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmConstructinstancefornestedclass";
            this.Text = "frmConstructinstancefornestedclass";
            this.Load += new System.EventHandler(this.frmConstructinstancefornestedclass_Load);
            this.ResumeLayout(false);

        }

        private void frmConstructinstancefornestedclass_Load(object sender, EventArgs e)
        {

        }
    }
}
