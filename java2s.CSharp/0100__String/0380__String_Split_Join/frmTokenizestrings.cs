using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0380__String_Split_Join
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/Tokenizestrings.htm
    public partial  class frmTokenizestrings:Form
    {
        public frmTokenizestrings()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTokenizestrings
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTokenizestrings";
            this.Text = "frmTokenizestrings";
            this.Load += new System.EventHandler(this.frmTokenizestrings_Load);
            this.ResumeLayout(false);

        }

        private void frmTokenizestrings_Load(object sender, EventArgs e)
        {

        }
    }
}
