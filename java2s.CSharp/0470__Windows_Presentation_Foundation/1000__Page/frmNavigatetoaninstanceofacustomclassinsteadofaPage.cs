using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1000__Page
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/NavigatetoaninstanceofacustomclassinsteadofaPage.htm
    public partial  class frmNavigatetoaninstanceofacustomclassinsteadofaPage:Form
    {
        public frmNavigatetoaninstanceofacustomclassinsteadofaPage()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNavigatetoaninstanceofacustomclassinsteadofaPage
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNavigatetoaninstanceofacustomclassinsteadofaPage";
            this.Text = "frmNavigatetoaninstanceofacustomclassinsteadofaPage";
            this.Load += new System.EventHandler(this.frmNavigatetoaninstanceofacustomclassinsteadofaPage_Load);
            this.ResumeLayout(false);

        }

        private void frmNavigatetoaninstanceofacustomclassinsteadofaPage_Load(object sender, EventArgs e)
        {

        }
    }
}
