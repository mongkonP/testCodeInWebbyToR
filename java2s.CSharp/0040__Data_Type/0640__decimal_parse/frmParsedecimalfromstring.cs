using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0640__decimal_parse
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/Parsedecimalfromstring.htm
    public partial  class frmParsedecimalfromstring:Form
    {
        public frmParsedecimalfromstring()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmParsedecimalfromstring
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmParsedecimalfromstring";
            this.Text = "frmParsedecimalfromstring";
            this.Load += new System.EventHandler(this.frmParsedecimalfromstring_Load);
            this.ResumeLayout(false);

        }

        private void frmParsedecimalfromstring_Load(object sender, EventArgs e)
        {

        }
    }
}
