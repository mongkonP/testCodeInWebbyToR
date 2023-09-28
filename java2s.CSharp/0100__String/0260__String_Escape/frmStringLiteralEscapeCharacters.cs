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
    //http://www.java2s.com/Tutorial/CSharp/0100__String/StringLiteralEscapeCharacters.htm
    public partial  class frmStringLiteralEscapeCharacters:Form
    {
        public frmStringLiteralEscapeCharacters()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStringLiteralEscapeCharacters
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStringLiteralEscapeCharacters";
            this.Text = "frmStringLiteralEscapeCharacters";
            this.Load += new System.EventHandler(this.frmStringLiteralEscapeCharacters_Load);
            this.ResumeLayout(false);

        }

        private void frmStringLiteralEscapeCharacters_Load(object sender, EventArgs e)
        {

        }
    }
}
