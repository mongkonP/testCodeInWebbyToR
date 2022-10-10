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
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/DocumentationCommentsforclass.htm
    public partial  class frmDocumentationCommentsforclass:Form
    {
        public frmDocumentationCommentsforclass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDocumentationCommentsforclass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDocumentationCommentsforclass";
            this.Text = "frmDocumentationCommentsforclass";
            this.Load += new System.EventHandler(this.frmDocumentationCommentsforclass_Load);
            this.ResumeLayout(false);

        }

        private void frmDocumentationCommentsforclass_Load(object sender, EventArgs e)
        {

        }
    }
}
