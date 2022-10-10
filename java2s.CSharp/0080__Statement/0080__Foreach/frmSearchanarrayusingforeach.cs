using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0080__Statement.C0080__Foreach
{
    //http://www.java2s.com/Tutorial/CSharp/0080__Statement/Searchanarrayusingforeach.htm
    public partial  class frmSearchanarrayusingforeach:Form
    {
        public frmSearchanarrayusingforeach()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSearchanarrayusingforeach
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSearchanarrayusingforeach";
            this.Text = "frmSearchanarrayusingforeach";
            this.Load += new System.EventHandler(this.frmSearchanarrayusingforeach_Load);
            this.ResumeLayout(false);

        }

        private void frmSearchanarrayusingforeach_Load(object sender, EventArgs e)
        {

        }
    }
}
