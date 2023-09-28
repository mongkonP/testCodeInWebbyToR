using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0860__FirstOrDefault
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/FirstOrDefaultwithaNotFoundElement.htm
    public partial  class frmFirstOrDefaultwithaNotFoundElement:Form
    {
        public frmFirstOrDefaultwithaNotFoundElement()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFirstOrDefaultwithaNotFoundElement
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFirstOrDefaultwithaNotFoundElement";
            this.Text = "frmFirstOrDefaultwithaNotFoundElement";
            this.Load += new System.EventHandler(this.frmFirstOrDefaultwithaNotFoundElement_Load);
            this.ResumeLayout(false);

        }

        private void frmFirstOrDefaultwithaNotFoundElement_Load(object sender, EventArgs e)
        {

        }
    }
}
