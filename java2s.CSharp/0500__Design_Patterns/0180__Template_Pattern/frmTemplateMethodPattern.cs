using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0500__Design_Patterns.C0180__Template_Pattern
{
    //http://www.java2s.com/Tutorial/CSharp/0500__Design-Patterns/TemplateMethodPattern.htm
    public partial  class frmTemplateMethodPattern:Form
    {
        public frmTemplateMethodPattern()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTemplateMethodPattern
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTemplateMethodPattern";
            this.Text = "frmTemplateMethodPattern";
            this.Load += new System.EventHandler(this.frmTemplateMethodPattern_Load);
            this.ResumeLayout(false);

        }

        private void frmTemplateMethodPattern_Load(object sender, EventArgs e)
        {

        }
    }
}
