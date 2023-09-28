using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0581__Directory_Services.C0120__Modify
{
    //http://www.java2s.com/Tutorial/CSharp/0581__Directory-Services/ModifyProperty.htm
    public partial  class frmModifyProperty:Form
    {
        public frmModifyProperty()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmModifyProperty
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmModifyProperty";
            this.Text = "frmModifyProperty";
            this.Load += new System.EventHandler(this.frmModifyProperty_Load);
            this.ResumeLayout(false);

        }

        private void frmModifyProperty_Load(object sender, EventArgs e)
        {

        }
    }
}
