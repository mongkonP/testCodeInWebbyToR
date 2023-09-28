using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0100__Member_Variable
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/fields.htm
    public partial  class frmfields:Form
    {
        public frmfields()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmfields
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmfields";
            this.Text = "frmfields";
            this.Load += new System.EventHandler(this.frmfields_Load);
            this.ResumeLayout(false);

        }

        private void frmfields_Load(object sender, EventArgs e)
        {

        }
    }
}
