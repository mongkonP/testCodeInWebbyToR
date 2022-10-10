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
    //http://www.java2s.com/Tutorial/CSharp/0100__String/Stringjoins.htm
    public partial  class frmStringjoins:Form
    {
        public frmStringjoins()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStringjoins
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStringjoins";
            this.Text = "frmStringjoins";
            this.Load += new System.EventHandler(this.frmStringjoins_Load);
            this.ResumeLayout(false);

        }

        private void frmStringjoins_Load(object sender, EventArgs e)
        {

        }
    }
}
