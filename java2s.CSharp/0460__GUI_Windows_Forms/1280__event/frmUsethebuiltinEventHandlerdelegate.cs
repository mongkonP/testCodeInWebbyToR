using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1280__event
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/UsethebuiltinEventHandlerdelegate.htm
    public partial  class frmUsethebuiltinEventHandlerdelegate:Form
    {
        public frmUsethebuiltinEventHandlerdelegate()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsethebuiltinEventHandlerdelegate
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsethebuiltinEventHandlerdelegate";
            this.Text = "frmUsethebuiltinEventHandlerdelegate";
            this.Load += new System.EventHandler(this.frmUsethebuiltinEventHandlerdelegate_Load);
            this.ResumeLayout(false);

        }

        private void frmUsethebuiltinEventHandlerdelegate_Load(object sender, EventArgs e)
        {

        }
    }
}
