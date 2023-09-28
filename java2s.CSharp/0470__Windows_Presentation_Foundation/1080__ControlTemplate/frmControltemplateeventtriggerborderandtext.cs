using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1080__ControlTemplate
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Controltemplateeventtriggerborderandtext.htm
    public partial  class frmControltemplateeventtriggerborderandtext:Form
    {
        public frmControltemplateeventtriggerborderandtext()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmControltemplateeventtriggerborderandtext
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmControltemplateeventtriggerborderandtext";
            this.Text = "frmControltemplateeventtriggerborderandtext";
            this.Load += new System.EventHandler(this.frmControltemplateeventtriggerborderandtext_Load);
            this.ResumeLayout(false);

        }

        private void frmControltemplateeventtriggerborderandtext_Load(object sender, EventArgs e)
        {

        }
    }
}
