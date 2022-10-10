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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/BindYourObjectstoUIControlwithProperty.htm
    public partial  class frmBindYourObjectstoUIControlwithProperty:Form
    {
        public frmBindYourObjectstoUIControlwithProperty()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBindYourObjectstoUIControlwithProperty
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBindYourObjectstoUIControlwithProperty";
            this.Text = "frmBindYourObjectstoUIControlwithProperty";
            this.Load += new System.EventHandler(this.frmBindYourObjectstoUIControlwithProperty_Load);
            this.ResumeLayout(false);

        }

        private void frmBindYourObjectstoUIControlwithProperty_Load(object sender, EventArgs e)
        {

        }
    }
}
