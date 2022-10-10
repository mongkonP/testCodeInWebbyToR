using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0400__Class_hierarchy
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Amultilevelhierarchy.htm
    public partial  class frmAmultilevelhierarchy:Form
    {
        public frmAmultilevelhierarchy()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAmultilevelhierarchy
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAmultilevelhierarchy";
            this.Text = "frmAmultilevelhierarchy";
            this.Load += new System.EventHandler(this.frmAmultilevelhierarchy_Load);
            this.ResumeLayout(false);

        }

        private void frmAmultilevelhierarchy_Load(object sender, EventArgs e)
        {

        }
    }
}
