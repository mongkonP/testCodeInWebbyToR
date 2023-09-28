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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Createabuttonwhenthepageloads.htm
    public partial  class frmCreateabuttonwhenthepageloads:Form
    {
        public frmCreateabuttonwhenthepageloads()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateabuttonwhenthepageloads
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateabuttonwhenthepageloads";
            this.Text = "frmCreateabuttonwhenthepageloads";
            this.Load += new System.EventHandler(this.frmCreateabuttonwhenthepageloads_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateabuttonwhenthepageloads_Load(object sender, EventArgs e)
        {

        }
    }
}
