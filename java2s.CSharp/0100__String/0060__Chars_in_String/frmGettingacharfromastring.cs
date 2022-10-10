using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0060__Chars_in_String
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/Gettingacharfromastring.htm
    public partial  class frmGettingacharfromastring:Form
    {
        public frmGettingacharfromastring()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGettingacharfromastring
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGettingacharfromastring";
            this.Text = "frmGettingacharfromastring";
            this.Load += new System.EventHandler(this.frmGettingacharfromastring_Load);
            this.ResumeLayout(false);

        }

        private void frmGettingacharfromastring_Load(object sender, EventArgs e)
        {

        }
    }
}
