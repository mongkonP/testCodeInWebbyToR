using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0620__ToolTip
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SetborderforToolTipbyusingControlTemplate.htm
    public partial  class frmSetborderforToolTipbyusingControlTemplate:Form
    {
        public frmSetborderforToolTipbyusingControlTemplate()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetborderforToolTipbyusingControlTemplate
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetborderforToolTipbyusingControlTemplate";
            this.Text = "frmSetborderforToolTipbyusingControlTemplate";
            this.Load += new System.EventHandler(this.frmSetborderforToolTipbyusingControlTemplate_Load);
            this.ResumeLayout(false);

        }

        private void frmSetborderforToolTipbyusingControlTemplate_Load(object sender, EventArgs e)
        {

        }
    }
}
