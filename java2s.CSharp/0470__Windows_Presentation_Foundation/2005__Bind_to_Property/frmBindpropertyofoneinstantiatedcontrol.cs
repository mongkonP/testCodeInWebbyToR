using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2005__Bind_to_Property
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Bindpropertyofoneinstantiatedcontrol.htm
    public partial  class frmBindpropertyofoneinstantiatedcontrol:Form
    {
        public frmBindpropertyofoneinstantiatedcontrol()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBindpropertyofoneinstantiatedcontrol
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBindpropertyofoneinstantiatedcontrol";
            this.Text = "frmBindpropertyofoneinstantiatedcontrol";
            this.Load += new System.EventHandler(this.frmBindpropertyofoneinstantiatedcontrol_Load);
            this.ResumeLayout(false);

        }

        private void frmBindpropertyofoneinstantiatedcontrol_Load(object sender, EventArgs e)
        {

        }
    }
}
