using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0640__ElementAtOrDefault
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/UsingElementAtOrDefault.htm
    public partial  class frmUsingElementAtOrDefault:Form
    {
        public frmUsingElementAtOrDefault()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingElementAtOrDefault
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingElementAtOrDefault";
            this.Text = "frmUsingElementAtOrDefault";
            this.Load += new System.EventHandler(this.frmUsingElementAtOrDefault_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingElementAtOrDefault_Load(object sender, EventArgs e)
        {

        }
    }
}
