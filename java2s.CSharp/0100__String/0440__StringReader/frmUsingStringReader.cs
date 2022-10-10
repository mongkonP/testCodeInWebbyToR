using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0440__StringReader
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/UsingStringReader.htm
    public partial  class frmUsingStringReader:Form
    {
        public frmUsingStringReader()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingStringReader
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingStringReader";
            this.Text = "frmUsingStringReader";
            this.Load += new System.EventHandler(this.frmUsingStringReader_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingStringReader_Load(object sender, EventArgs e)
        {

        }
    }
}
