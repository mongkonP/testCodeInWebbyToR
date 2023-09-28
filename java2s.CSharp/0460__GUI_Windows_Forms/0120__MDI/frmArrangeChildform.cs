using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0120__MDI
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ArrangeChildform.htm
    public partial  class frmArrangeChildform:Form
    {
        public frmArrangeChildform()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmArrangeChildform
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmArrangeChildform";
            this.Text = "frmArrangeChildform";
            this.Load += new System.EventHandler(this.frmArrangeChildform_Load);
            this.ResumeLayout(false);

        }

        private void frmArrangeChildform_Load(object sender, EventArgs e)
        {

        }
    }
}
