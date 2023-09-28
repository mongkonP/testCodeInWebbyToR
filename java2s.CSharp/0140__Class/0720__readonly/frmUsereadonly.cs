using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0720__readonly
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Usereadonly.htm
    public partial  class frmUsereadonly:Form
    {
        public frmUsereadonly()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsereadonly
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsereadonly";
            this.Text = "frmUsereadonly";
            this.Load += new System.EventHandler(this.frmUsereadonly_Load);
            this.ResumeLayout(false);

        }

        private void frmUsereadonly_Load(object sender, EventArgs e)
        {

        }
    }
}
