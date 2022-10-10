using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0360__String_Search
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/Searchasubstringinastring.htm
    public partial  class frmSearchasubstringinastring:Form
    {
        public frmSearchasubstringinastring()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSearchasubstringinastring
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSearchasubstringinastring";
            this.Text = "frmSearchasubstringinastring";
            this.Load += new System.EventHandler(this.frmSearchasubstringinastring_Load);
            this.ResumeLayout(false);

        }

        private void frmSearchasubstringinastring_Load(object sender, EventArgs e)
        {

        }
    }
}
