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
    //http://www.java2s.com/Tutorial/CSharp/0100__String/StringSplit.htm
    public partial  class frmStringSplit:Form
    {
        public frmStringSplit()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStringSplit
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStringSplit";
            this.Text = "frmStringSplit";
            this.Load += new System.EventHandler(this.frmStringSplit_Load);
            this.ResumeLayout(false);

        }

        private void frmStringSplit_Load(object sender, EventArgs e)
        {

        }
    }
}
