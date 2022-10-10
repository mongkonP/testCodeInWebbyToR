using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2120__Resource
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ResourceLookup.htm
    public partial  class frmResourceLookup:Form
    {
        public frmResourceLookup()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmResourceLookup
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmResourceLookup";
            this.Text = "frmResourceLookup";
            this.Load += new System.EventHandler(this.frmResourceLookup_Load);
            this.ResumeLayout(false);

        }

        private void frmResourceLookup_Load(object sender, EventArgs e)
        {

        }
    }
}
