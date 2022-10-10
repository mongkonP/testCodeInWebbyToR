using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0580__UI_Element
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Findinnervisualelement.htm
    public partial  class frmFindinnervisualelement:Form
    {
        public frmFindinnervisualelement()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFindinnervisualelement
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFindinnervisualelement";
            this.Text = "frmFindinnervisualelement";
            this.Load += new System.EventHandler(this.frmFindinnervisualelement_Load);
            this.ResumeLayout(false);

        }

        private void frmFindinnervisualelement_Load(object sender, EventArgs e)
        {

        }
    }
}
