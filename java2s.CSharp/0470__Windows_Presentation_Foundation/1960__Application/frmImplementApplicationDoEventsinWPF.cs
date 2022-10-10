using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1960__Application
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ImplementApplicationDoEventsinWPF.htm
    public partial  class frmImplementApplicationDoEventsinWPF:Form
    {
        public frmImplementApplicationDoEventsinWPF()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmImplementApplicationDoEventsinWPF
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmImplementApplicationDoEventsinWPF";
            this.Text = "frmImplementApplicationDoEventsinWPF";
            this.Load += new System.EventHandler(this.frmImplementApplicationDoEventsinWPF_Load);
            this.ResumeLayout(false);

        }

        private void frmImplementApplicationDoEventsinWPF_Load(object sender, EventArgs e)
        {

        }
    }
}
