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
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/UseJoinon.htm
    public partial  class frmUseJoinon:Form
    {
        public frmUseJoinon()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseJoinon
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseJoinon";
            this.Text = "frmUseJoinon";
            this.Load += new System.EventHandler(this.frmUseJoinon_Load);
            this.ResumeLayout(false);

        }

        private void frmUseJoinon_Load(object sender, EventArgs e)
        {

        }
    }
}
