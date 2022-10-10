using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0540__XML.C0420__Xml_transformation
{
    //http://www.java2s.com/Tutorial/CSharp/0540__XML/TransformExtension.htm
    public partial  class frmTransformExtension:Form
    {
        public frmTransformExtension()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTransformExtension
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTransformExtension";
            this.Text = "frmTransformExtension";
            this.Load += new System.EventHandler(this.frmTransformExtension_Load);
            this.ResumeLayout(false);

        }

        private void frmTransformExtension_Load(object sender, EventArgs e)
        {

        }
    }
}
