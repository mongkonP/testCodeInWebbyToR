using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0220__SHA1Managed
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/Generatethehashcodeofthepassword.htm
    public partial  class frmGeneratethehashcodeofthepassword:Form
    {
        public frmGeneratethehashcodeofthepassword()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGeneratethehashcodeofthepassword
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGeneratethehashcodeofthepassword";
            this.Text = "frmGeneratethehashcodeofthepassword";
            this.Load += new System.EventHandler(this.frmGeneratethehashcodeofthepassword_Load);
            this.ResumeLayout(false);

        }

        private void frmGeneratethehashcodeofthepassword_Load(object sender, EventArgs e)
        {

        }
    }
}
