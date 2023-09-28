using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0260__String_Escape
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/Stringescape.htm
    public partial  class frmStringescape:Form
    {
        public frmStringescape()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStringescape
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStringescape";
            this.Text = "frmStringescape";
            this.Load += new System.EventHandler(this.frmStringescape_Load);
            this.ResumeLayout(false);

        }

        private void frmStringescape_Load(object sender, EventArgs e)
        {

        }
    }
}
