using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0060__Field
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/GetallfieldsfromaType.htm
    public partial  class frmGetallfieldsfromaType:Form
    {
        public frmGetallfieldsfromaType()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetallfieldsfromaType
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetallfieldsfromaType";
            this.Text = "frmGetallfieldsfromaType";
            this.Load += new System.EventHandler(this.frmGetallfieldsfromaType_Load);
            this.ResumeLayout(false);

        }

        private void frmGetallfieldsfromaType_Load(object sender, EventArgs e)
        {

        }
    }
}
