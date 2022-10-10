using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0581__Directory_Services.C0060__Add
{
    //http://www.java2s.com/Tutorial/CSharp/0581__Directory-Services/AddProperty.htm
    public partial  class frmAddProperty:Form
    {
        public frmAddProperty()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddProperty
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddProperty";
            this.Text = "frmAddProperty";
            this.Load += new System.EventHandler(this.frmAddProperty_Load);
            this.ResumeLayout(false);

        }

        private void frmAddProperty_Load(object sender, EventArgs e)
        {

        }
    }
}
