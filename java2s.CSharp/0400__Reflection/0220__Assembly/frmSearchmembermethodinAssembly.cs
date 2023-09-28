using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0220__Assembly
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/SearchmembermethodinAssembly.htm
    public partial  class frmSearchmembermethodinAssembly:Form
    {
        public frmSearchmembermethodinAssembly()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSearchmembermethodinAssembly
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSearchmembermethodinAssembly";
            this.Text = "frmSearchmembermethodinAssembly";
            this.Load += new System.EventHandler(this.frmSearchmembermethodinAssembly_Load);
            this.ResumeLayout(false);

        }

        private void frmSearchmembermethodinAssembly_Load(object sender, EventArgs e)
        {

        }
    }
}
