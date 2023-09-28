using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0900__static_method
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Usestatic.htm
    public partial  class frmUsestatic:Form
    {
        public frmUsestatic()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsestatic
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsestatic";
            this.Text = "frmUsestatic";
            this.Load += new System.EventHandler(this.frmUsestatic_Load);
            this.ResumeLayout(false);

        }

        private void frmUsestatic_Load(object sender, EventArgs e)
        {

        }
    }
}
