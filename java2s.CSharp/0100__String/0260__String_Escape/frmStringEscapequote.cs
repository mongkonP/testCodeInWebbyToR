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
    //http://www.java2s.com/Tutorial/CSharp/0100__String/StringEscapequote.htm
    public partial  class frmStringEscapequote:Form
    {
        public frmStringEscapequote()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStringEscapequote
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStringEscapequote";
            this.Text = "frmStringEscapequote";
            this.Load += new System.EventHandler(this.frmStringEscapequote_Load);
            this.ResumeLayout(false);

        }

        private void frmStringEscapequote_Load(object sender, EventArgs e)
        {

        }
    }
}
