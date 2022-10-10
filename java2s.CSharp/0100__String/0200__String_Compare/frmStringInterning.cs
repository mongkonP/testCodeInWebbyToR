using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0200__String_Compare
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/StringInterning.htm
    public partial  class frmStringInterning:Form
    {
        public frmStringInterning()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStringInterning
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStringInterning";
            this.Text = "frmStringInterning";
            this.Load += new System.EventHandler(this.frmStringInterning_Load);
            this.ResumeLayout(false);

        }

        private void frmStringInterning_Load(object sender, EventArgs e)
        {

        }
    }
}
