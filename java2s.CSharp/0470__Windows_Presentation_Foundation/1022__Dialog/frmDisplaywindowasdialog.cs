using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1022__Dialog
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Displaywindowasdialog.htm
    public partial  class frmDisplaywindowasdialog:Form
    {
        public frmDisplaywindowasdialog()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplaywindowasdialog
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplaywindowasdialog";
            this.Text = "frmDisplaywindowasdialog";
            this.Load += new System.EventHandler(this.frmDisplaywindowasdialog_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplaywindowasdialog_Load(object sender, EventArgs e)
        {

        }
    }
}
