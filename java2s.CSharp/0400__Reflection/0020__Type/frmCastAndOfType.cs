using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0020__Type
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/CastAndOfType.htm
    public partial  class frmCastAndOfType:Form
    {
        public frmCastAndOfType()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCastAndOfType
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCastAndOfType";
            this.Text = "frmCastAndOfType";
            this.Load += new System.EventHandler(this.frmCastAndOfType_Load);
            this.ResumeLayout(false);

        }

        private void frmCastAndOfType_Load(object sender, EventArgs e)
        {

        }
    }
}
