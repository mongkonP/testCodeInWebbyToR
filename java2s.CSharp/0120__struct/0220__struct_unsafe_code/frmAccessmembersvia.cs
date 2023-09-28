using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0120__struct.C0220__struct_unsafe_code
{
    //http://www.java2s.com/Tutorial/CSharp/0120__struct/Accessmembersvia.htm
    public partial  class frmAccessmembersvia:Form
    {
        public frmAccessmembersvia()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAccessmembersvia
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAccessmembersvia";
            this.Text = "frmAccessmembersvia";
            this.Load += new System.EventHandler(this.frmAccessmembersvia_Load);
            this.ResumeLayout(false);

        }

        private void frmAccessmembersvia_Load(object sender, EventArgs e)
        {

        }
    }
}
