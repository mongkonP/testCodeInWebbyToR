using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0120__struct.C0040__struct_definition
{
    //http://www.java2s.com/Tutorial/CSharp/0120__struct/Declareastruct.htm
    public partial  class frmDeclareastruct:Form
    {
        public frmDeclareastruct()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDeclareastruct
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDeclareastruct";
            this.Text = "frmDeclareastruct";
            this.Load += new System.EventHandler(this.frmDeclareastruct_Load);
            this.ResumeLayout(false);

        }

        private void frmDeclareastruct_Load(object sender, EventArgs e)
        {

        }
    }
}
