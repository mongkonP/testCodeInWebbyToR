using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0541__XML_LINQ.C0060__XAttribute
{
    //http://www.java2s.com/Tutorial/CSharp/0541__XML-LINQ/DisplaysalltheattributesfromanXmltag.htm
    public partial  class frmDisplaysalltheattributesfromanXmltag:Form
    {
        public frmDisplaysalltheattributesfromanXmltag()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplaysalltheattributesfromanXmltag
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplaysalltheattributesfromanXmltag";
            this.Text = "frmDisplaysalltheattributesfromanXmltag";
            this.Load += new System.EventHandler(this.frmDisplaysalltheattributesfromanXmltag_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplaysalltheattributesfromanXmltag_Load(object sender, EventArgs e)
        {

        }
    }
}
