using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0340__Escape_sequences
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/EscapeCharacters.htm
    public partial  class frmEscapeCharacters:Form
    {
        public frmEscapeCharacters()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEscapeCharacters
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEscapeCharacters";
            this.Text = "frmEscapeCharacters";
            this.Load += new System.EventHandler(this.frmEscapeCharacters_Load);
            this.ResumeLayout(false);

        }

        private void frmEscapeCharacters_Load(object sender, EventArgs e)
        {

        }
    }
}
