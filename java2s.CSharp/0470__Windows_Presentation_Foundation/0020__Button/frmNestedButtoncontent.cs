using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0020__Button
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/NestedButtoncontent.htm
    public partial  class frmNestedButtoncontent:Form
    {
        public frmNestedButtoncontent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNestedButtoncontent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNestedButtoncontent";
            this.Text = "frmNestedButtoncontent";
            this.Load += new System.EventHandler(this.frmNestedButtoncontent_Load);
            this.ResumeLayout(false);

        }

        private void frmNestedButtoncontent_Load(object sender, EventArgs e)
        {

        }
    }
}
