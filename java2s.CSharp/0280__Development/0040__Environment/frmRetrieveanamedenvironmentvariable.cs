using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0040__Environment
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Retrieveanamedenvironmentvariable.htm
    public partial  class frmRetrieveanamedenvironmentvariable:Form
    {
        public frmRetrieveanamedenvironmentvariable()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRetrieveanamedenvironmentvariable
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRetrieveanamedenvironmentvariable";
            this.Text = "frmRetrieveanamedenvironmentvariable";
            this.Load += new System.EventHandler(this.frmRetrieveanamedenvironmentvariable_Load);
            this.ResumeLayout(false);

        }

        private void frmRetrieveanamedenvironmentvariable_Load(object sender, EventArgs e)
        {

        }
    }
}
