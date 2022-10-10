using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0200__Attribute.C0100__Attributes_Reflection
{
    //http://www.java2s.com/Tutorial/CSharp/0200__Attribute/ReflectingonAttributes.htm
    public partial  class frmReflectingonAttributes:Form
    {
        public frmReflectingonAttributes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReflectingonAttributes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReflectingonAttributes";
            this.Text = "frmReflectingonAttributes";
            this.Load += new System.EventHandler(this.frmReflectingonAttributes_Load);
            this.ResumeLayout(false);

        }

        private void frmReflectingonAttributes_Load(object sender, EventArgs e)
        {

        }
    }
}
