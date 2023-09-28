using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0240__String_Copy
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/Copyastring.htm
    public partial  class frmCopyastring:Form
    {
        public frmCopyastring()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCopyastring
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCopyastring";
            this.Text = "frmCopyastring";
            this.Load += new System.EventHandler(this.frmCopyastring_Load);
            this.ResumeLayout(false);

        }

        private void frmCopyastring_Load(object sender, EventArgs e)
        {

        }
    }
}
