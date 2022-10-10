using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0160__String_Concat
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/AppendstringsusingConcat.htm
    public partial  class frmAppendstringsusingConcat:Form
    {
        public frmAppendstringsusingConcat()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAppendstringsusingConcat
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAppendstringsusingConcat";
            this.Text = "frmAppendstringsusingConcat";
            this.Load += new System.EventHandler(this.frmAppendstringsusingConcat_Load);
            this.ResumeLayout(false);

        }

        private void frmAppendstringsusingConcat_Load(object sender, EventArgs e)
        {

        }
    }
}
