using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0260__String_Escape
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/DisplayingaSingleQuoteUsinganEscapeSequence.htm
    public partial  class frmDisplayingaSingleQuoteUsinganEscapeSequence:Form
    {
        public frmDisplayingaSingleQuoteUsinganEscapeSequence()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplayingaSingleQuoteUsinganEscapeSequence
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplayingaSingleQuoteUsinganEscapeSequence";
            this.Text = "frmDisplayingaSingleQuoteUsinganEscapeSequence";
            this.Load += new System.EventHandler(this.frmDisplayingaSingleQuoteUsinganEscapeSequence_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplayingaSingleQuoteUsinganEscapeSequence_Load(object sender, EventArgs e)
        {

        }
    }
}
