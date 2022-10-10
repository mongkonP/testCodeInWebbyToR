using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0760__Properties
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/PropertyGetterandSetter.htm
    public partial  class frmPropertyGetterandSetter:Form
    {
        public frmPropertyGetterandSetter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPropertyGetterandSetter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPropertyGetterandSetter";
            this.Text = "frmPropertyGetterandSetter";
            this.Load += new System.EventHandler(this.frmPropertyGetterandSetter_Load);
            this.ResumeLayout(false);

        }

        private void frmPropertyGetterandSetter_Load(object sender, EventArgs e)
        {

        }
    }
}
