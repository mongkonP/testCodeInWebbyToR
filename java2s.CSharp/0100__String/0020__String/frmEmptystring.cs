using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0020__String
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/Emptystring.htm
    public partial  class frmEmptystring:Form
    {
        public frmEmptystring()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEmptystring
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEmptystring";
            this.Text = "frmEmptystring";
            this.Load += new System.EventHandler(this.frmEmptystring_Load);
            this.ResumeLayout(false);

        }

        private void frmEmptystring_Load(object sender, EventArgs e)
        {

        }
    }
}
