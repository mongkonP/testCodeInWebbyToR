using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0380__String_Split_Join
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/Joiningstrings.htm
    public partial  class frmJoiningstrings:Form
    {
        public frmJoiningstrings()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmJoiningstrings
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmJoiningstrings";
            this.Text = "frmJoiningstrings";
            this.Load += new System.EventHandler(this.frmJoiningstrings_Load);
            this.ResumeLayout(false);

        }

        private void frmJoiningstrings_Load(object sender, EventArgs e)
        {

        }
    }
}
