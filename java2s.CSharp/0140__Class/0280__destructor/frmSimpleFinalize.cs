using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0280__destructor
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/SimpleFinalize.htm
    public partial  class frmSimpleFinalize:Form
    {
        public frmSimpleFinalize()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSimpleFinalize
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSimpleFinalize";
            this.Text = "frmSimpleFinalize";
            this.Load += new System.EventHandler(this.frmSimpleFinalize_Load);
            this.ResumeLayout(false);

        }

        private void frmSimpleFinalize_Load(object sender, EventArgs e)
        {

        }
    }
}
