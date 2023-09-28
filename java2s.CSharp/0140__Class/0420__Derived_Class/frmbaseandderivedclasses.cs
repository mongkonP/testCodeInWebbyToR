using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0420__Derived_Class
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/baseandderivedclasses.htm
    public partial  class frmbaseandderivedclasses:Form
    {
        public frmbaseandderivedclasses()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmbaseandderivedclasses
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmbaseandderivedclasses";
            this.Text = "frmbaseandderivedclasses";
            this.Load += new System.EventHandler(this.frmbaseandderivedclasses_Load);
            this.ResumeLayout(false);

        }

        private void frmbaseandderivedclasses_Load(object sender, EventArgs e)
        {

        }
    }
}
