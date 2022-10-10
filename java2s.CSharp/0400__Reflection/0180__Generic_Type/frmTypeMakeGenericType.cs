using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0180__Generic_Type
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/TypeMakeGenericType.htm
    public partial  class frmTypeMakeGenericType:Form
    {
        public frmTypeMakeGenericType()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTypeMakeGenericType
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTypeMakeGenericType";
            this.Text = "frmTypeMakeGenericType";
            this.Load += new System.EventHandler(this.frmTypeMakeGenericType_Load);
            this.ResumeLayout(false);

        }

        private void frmTypeMakeGenericType_Load(object sender, EventArgs e)
        {

        }
    }
}
