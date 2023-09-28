using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0920__static_Properties
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/StaticProperties.htm
    public partial  class frmStaticProperties:Form
    {
        public frmStaticProperties()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStaticProperties
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStaticProperties";
            this.Text = "frmStaticProperties";
            this.Load += new System.EventHandler(this.frmStaticProperties_Load);
            this.ResumeLayout(false);

        }

        private void frmStaticProperties_Load(object sender, EventArgs e)
        {

        }
    }
}
