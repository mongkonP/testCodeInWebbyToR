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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Asimplepropertyexample.htm
    public partial  class frmAsimplepropertyexample:Form
    {
        public frmAsimplepropertyexample()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAsimplepropertyexample
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAsimplepropertyexample";
            this.Text = "frmAsimplepropertyexample";
            this.Load += new System.EventHandler(this.frmAsimplepropertyexample_Load);
            this.ResumeLayout(false);

        }

        private void frmAsimplepropertyexample_Load(object sender, EventArgs e)
        {

        }
    }
}
