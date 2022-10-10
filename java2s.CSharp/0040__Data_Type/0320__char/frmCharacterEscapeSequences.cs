using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0320__char
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/CharacterEscapeSequences.htm
    public partial  class frmCharacterEscapeSequences:Form
    {
        public frmCharacterEscapeSequences()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCharacterEscapeSequences
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCharacterEscapeSequences";
            this.Text = "frmCharacterEscapeSequences";
            this.Load += new System.EventHandler(this.frmCharacterEscapeSequences_Load);
            this.ResumeLayout(false);

        }

        private void frmCharacterEscapeSequences_Load(object sender, EventArgs e)
        {

        }
    }
}
