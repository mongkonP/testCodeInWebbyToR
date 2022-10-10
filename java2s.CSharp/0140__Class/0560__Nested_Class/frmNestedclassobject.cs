using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0560__Nested_Class
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Nestedclassobject.htm
    public partial  class frmNestedclassobject:Form
    {
        public frmNestedclassobject()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNestedclassobject
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNestedclassobject";
            this.Text = "frmNestedclassobject";
            this.Load += new System.EventHandler(this.frmNestedclassobject_Load);
            this.ResumeLayout(false);

        }

        private void frmNestedclassobject_Load(object sender, EventArgs e)
        {

        }
    }
}
