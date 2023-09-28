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
    //http://www.java2s.com/Tutorial/CSharp/0100__String/Readingfromastring.htm
    public partial  class frmReadingfromastring:Form
    {
        public frmReadingfromastring()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadingfromastring
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadingfromastring";
            this.Text = "frmReadingfromastring";
            this.Load += new System.EventHandler(this.frmReadingfromastring_Load);
            this.ResumeLayout(false);

        }

        private void frmReadingfromastring_Load(object sender, EventArgs e)
        {

        }
    }
}
