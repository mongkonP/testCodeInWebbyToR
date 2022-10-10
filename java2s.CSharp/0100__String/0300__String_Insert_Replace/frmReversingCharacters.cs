using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0300__String_Insert_Replace
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/ReversingCharacters.htm
    public partial  class frmReversingCharacters:Form
    {
        public frmReversingCharacters()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReversingCharacters
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReversingCharacters";
            this.Text = "frmReversingCharacters";
            this.Load += new System.EventHandler(this.frmReversingCharacters_Load);
            this.ResumeLayout(false);

        }

        private void frmReversingCharacters_Load(object sender, EventArgs e)
        {

        }
    }
}
