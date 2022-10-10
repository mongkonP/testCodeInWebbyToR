using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0380__Generic.C0460__where
{
    //http://www.java2s.com/Tutorial/CSharp/0380__Generic/whereTstruct.htm
    public partial  class frmwhereTstruct:Form
    {
        public frmwhereTstruct()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmwhereTstruct
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmwhereTstruct";
            this.Text = "frmwhereTstruct";
            this.Load += new System.EventHandler(this.frmwhereTstruct_Load);
            this.ResumeLayout(false);

        }

        private void frmwhereTstruct_Load(object sender, EventArgs e)
        {

        }
    }
}
