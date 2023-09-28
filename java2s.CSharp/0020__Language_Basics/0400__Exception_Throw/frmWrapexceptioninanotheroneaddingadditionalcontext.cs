using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0400__Exception_Throw
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Wrapexceptioninanotheroneaddingadditionalcontext.htm
    public partial  class frmWrapexceptioninanotheroneaddingadditionalcontext:Form
    {
        public frmWrapexceptioninanotheroneaddingadditionalcontext()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWrapexceptioninanotheroneaddingadditionalcontext
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWrapexceptioninanotheroneaddingadditionalcontext";
            this.Text = "frmWrapexceptioninanotheroneaddingadditionalcontext";
            this.Load += new System.EventHandler(this.frmWrapexceptioninanotheroneaddingadditionalcontext_Load);
            this.ResumeLayout(false);

        }

        private void frmWrapexceptioninanotheroneaddingadditionalcontext_Load(object sender, EventArgs e)
        {

        }
    }
}
