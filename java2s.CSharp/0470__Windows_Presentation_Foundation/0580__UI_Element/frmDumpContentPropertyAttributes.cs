using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0580__UI_Element
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DumpContentPropertyAttributes.htm
    public partial  class frmDumpContentPropertyAttributes:Form
    {
        public frmDumpContentPropertyAttributes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDumpContentPropertyAttributes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDumpContentPropertyAttributes";
            this.Text = "frmDumpContentPropertyAttributes";
            this.Load += new System.EventHandler(this.frmDumpContentPropertyAttributes_Load);
            this.ResumeLayout(false);

        }

        private void frmDumpContentPropertyAttributes_Load(object sender, EventArgs e)
        {

        }
    }
}
