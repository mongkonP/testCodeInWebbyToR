using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0820__Bitwise_AND
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/bitwiseAND.htm
    public partial  class frmbitwiseAND:Form
    {
        public frmbitwiseAND()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmbitwiseAND
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmbitwiseAND";
            this.Text = "frmbitwiseAND";
            this.Load += new System.EventHandler(this.frmbitwiseAND_Load);
            this.ResumeLayout(false);

        }

        private void frmbitwiseAND_Load(object sender, EventArgs e)
        {

        }
    }
}
