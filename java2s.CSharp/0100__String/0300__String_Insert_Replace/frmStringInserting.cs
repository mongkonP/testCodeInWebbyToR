using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0300__String_Insert_Replace
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/StringInserting.htm
    public partial  class frmStringInserting:Form
    {
        public frmStringInserting()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStringInserting
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStringInserting";
            this.Text = "frmStringInserting";
            this.Load += new System.EventHandler(this.frmStringInserting_Load);
            this.ResumeLayout(false);

        }

        private void frmStringInserting_Load(object sender, EventArgs e)
        {

        }
    }
}
