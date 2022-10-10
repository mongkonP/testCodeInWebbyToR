using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0360__Regular_Expression.C0120__Regex_Match
{
    //http://www.java2s.com/Tutorial/CSharp/0360__Regular-Expression/NextMatch.htm
    public partial  class frmNextMatch:Form
    {
        public frmNextMatch()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNextMatch
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNextMatch";
            this.Text = "frmNextMatch";
            this.Load += new System.EventHandler(this.frmNextMatch_Load);
            this.ResumeLayout(false);

        }

        private void frmNextMatch_Load(object sender, EventArgs e)
        {

        }
    }
}
