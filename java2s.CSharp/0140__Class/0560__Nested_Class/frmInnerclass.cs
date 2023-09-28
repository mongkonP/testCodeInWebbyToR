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
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Innerclass.htm
    public partial  class frmInnerclass:Form
    {
        public frmInnerclass()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInnerclass
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInnerclass";
            this.Text = "frmInnerclass";
            this.Load += new System.EventHandler(this.frmInnerclass_Load);
            this.ResumeLayout(false);

        }

        private void frmInnerclass_Load(object sender, EventArgs e)
        {

        }
    }
}
