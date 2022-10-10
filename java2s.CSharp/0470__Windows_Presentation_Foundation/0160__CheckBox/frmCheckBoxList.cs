using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0160__CheckBox
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CheckBoxList.htm
    public partial  class frmCheckBoxList:Form
    {
        public frmCheckBoxList()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCheckBoxList
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCheckBoxList";
            this.Text = "frmCheckBoxList";
            this.Load += new System.EventHandler(this.frmCheckBoxList_Load);
            this.ResumeLayout(false);

        }

        private void frmCheckBoxList_Load(object sender, EventArgs e)
        {

        }
    }
}
