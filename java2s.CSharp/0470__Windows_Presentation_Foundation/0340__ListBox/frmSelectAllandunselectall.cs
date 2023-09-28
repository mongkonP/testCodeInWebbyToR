using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0340__ListBox
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SelectAllandunselectall.htm
    public partial  class frmSelectAllandunselectall:Form
    {
        public frmSelectAllandunselectall()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSelectAllandunselectall
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSelectAllandunselectall";
            this.Text = "frmSelectAllandunselectall";
            this.Load += new System.EventHandler(this.frmSelectAllandunselectall_Load);
            this.ResumeLayout(false);

        }

        private void frmSelectAllandunselectall_Load(object sender, EventArgs e)
        {

        }
    }
}
