using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0720__Panel
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ShowIndexofControls.htm
    public partial  class frmShowIndexofControls:Form
    {
        public frmShowIndexofControls()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmShowIndexofControls
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmShowIndexofControls";
            this.Text = "frmShowIndexofControls";
            this.Load += new System.EventHandler(this.frmShowIndexofControls_Load);
            this.ResumeLayout(false);

        }

        private void frmShowIndexofControls_Load(object sender, EventArgs e)
        {

        }
    }
}
