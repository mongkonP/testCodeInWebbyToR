using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C1140__nullable
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/UsingtheNullableModifier.htm
    public partial  class frmUsingtheNullableModifier:Form
    {
        public frmUsingtheNullableModifier()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingtheNullableModifier
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingtheNullableModifier";
            this.Text = "frmUsingtheNullableModifier";
            this.Load += new System.EventHandler(this.frmUsingtheNullableModifier_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingtheNullableModifier_Load(object sender, EventArgs e)
        {

        }
    }
}
