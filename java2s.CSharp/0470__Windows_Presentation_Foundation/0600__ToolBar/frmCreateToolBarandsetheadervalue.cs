using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0600__ToolBar
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CreateToolBarandsetheadervalue.htm
    public partial  class frmCreateToolBarandsetheadervalue:Form
    {
        public frmCreateToolBarandsetheadervalue()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateToolBarandsetheadervalue
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateToolBarandsetheadervalue";
            this.Text = "frmCreateToolBarandsetheadervalue";
            this.Load += new System.EventHandler(this.frmCreateToolBarandsetheadervalue_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateToolBarandsetheadervalue_Load(object sender, EventArgs e)
        {

        }
    }
}
