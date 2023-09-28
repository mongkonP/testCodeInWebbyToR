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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Readonlyandconst.htm
    public partial  class frmReadonlyandconst:Form
    {
        public frmReadonlyandconst()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadonlyandconst
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadonlyandconst";
            this.Text = "frmReadonlyandconst";
            this.Load += new System.EventHandler(this.frmReadonlyandconst_Load);
            this.ResumeLayout(false);

        }

        private void frmReadonlyandconst_Load(object sender, EventArgs e)
        {

        }
    }
}
