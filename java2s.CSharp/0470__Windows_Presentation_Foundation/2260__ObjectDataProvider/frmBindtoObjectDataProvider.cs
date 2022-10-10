using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2260__ObjectDataProvider
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/BindtoObjectDataProvider.htm
    public partial  class frmBindtoObjectDataProvider:Form
    {
        public frmBindtoObjectDataProvider()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBindtoObjectDataProvider
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBindtoObjectDataProvider";
            this.Text = "frmBindtoObjectDataProvider";
            this.Load += new System.EventHandler(this.frmBindtoObjectDataProvider_Load);
            this.ResumeLayout(false);

        }

        private void frmBindtoObjectDataProvider_Load(object sender, EventArgs e)
        {

        }
    }
}
