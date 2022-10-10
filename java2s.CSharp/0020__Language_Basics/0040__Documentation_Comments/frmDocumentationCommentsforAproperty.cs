using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0040__Documentation_Comments
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/DocumentationCommentsforAproperty.htm
    public partial  class frmDocumentationCommentsforAproperty:Form
    {
        public frmDocumentationCommentsforAproperty()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDocumentationCommentsforAproperty
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDocumentationCommentsforAproperty";
            this.Text = "frmDocumentationCommentsforAproperty";
            this.Load += new System.EventHandler(this.frmDocumentationCommentsforAproperty_Load);
            this.ResumeLayout(false);

        }

        private void frmDocumentationCommentsforAproperty_Load(object sender, EventArgs e)
        {

        }
    }
}
