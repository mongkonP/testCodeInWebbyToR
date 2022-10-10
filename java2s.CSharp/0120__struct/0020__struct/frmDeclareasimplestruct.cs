using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0120__struct.C0020__struct
{
    //http://www.java2s.com/Tutorial/CSharp/0120__struct/Declareasimplestruct.htm
    public partial  class frmDeclareasimplestruct:Form
    {
        public frmDeclareasimplestruct()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDeclareasimplestruct
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDeclareasimplestruct";
            this.Text = "frmDeclareasimplestruct";
            this.Load += new System.EventHandler(this.frmDeclareasimplestruct_Load);
            this.ResumeLayout(false);

        }

        private void frmDeclareasimplestruct_Load(object sender, EventArgs e)
        {

        }
    }
}
