using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0021__Attributes
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/UsingReflectiontogetCustomAttributes.htm
    public partial  class frmUsingReflectiontogetCustomAttributes:Form
    {
        public frmUsingReflectiontogetCustomAttributes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingReflectiontogetCustomAttributes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingReflectiontogetCustomAttributes";
            this.Text = "frmUsingReflectiontogetCustomAttributes";
            this.Load += new System.EventHandler(this.frmUsingReflectiontogetCustomAttributes_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingReflectiontogetCustomAttributes_Load(object sender, EventArgs e)
        {

        }
    }
}
