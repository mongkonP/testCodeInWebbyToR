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
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/UsingUnicodeEncodingtoDisplayaSmileyFace.htm
    public partial  class frmUsingUnicodeEncodingtoDisplayaSmileyFace:Form
    {
        public frmUsingUnicodeEncodingtoDisplayaSmileyFace()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingUnicodeEncodingtoDisplayaSmileyFace
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingUnicodeEncodingtoDisplayaSmileyFace";
            this.Text = "frmUsingUnicodeEncodingtoDisplayaSmileyFace";
            this.Load += new System.EventHandler(this.frmUsingUnicodeEncodingtoDisplayaSmileyFace_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingUnicodeEncodingtoDisplayaSmileyFace_Load(object sender, EventArgs e)
        {

        }
    }
}
