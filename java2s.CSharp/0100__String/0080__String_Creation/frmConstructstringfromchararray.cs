using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0080__String_Creation
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/Constructstringfromchararray.htm
    public partial  class frmConstructstringfromchararray:Form
    {
        public frmConstructstringfromchararray()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmConstructstringfromchararray
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmConstructstringfromchararray";
            this.Text = "frmConstructstringfromchararray";
            this.Load += new System.EventHandler(this.frmConstructstringfromchararray_Load);
            this.ResumeLayout(false);

        }

        private void frmConstructstringfromchararray_Load(object sender, EventArgs e)
        {

        }
    }
}
