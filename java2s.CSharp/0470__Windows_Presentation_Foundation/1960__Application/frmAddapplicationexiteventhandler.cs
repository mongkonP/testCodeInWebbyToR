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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Addapplicationexiteventhandler.htm
    public partial  class frmAddapplicationexiteventhandler:Form
    {
        public frmAddapplicationexiteventhandler()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddapplicationexiteventhandler
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddapplicationexiteventhandler";
            this.Text = "frmAddapplicationexiteventhandler";
            this.Load += new System.EventHandler(this.frmAddapplicationexiteventhandler_Load);
            this.ResumeLayout(false);

        }

        private void frmAddapplicationexiteventhandler_Load(object sender, EventArgs e)
        {

        }
    }
}
