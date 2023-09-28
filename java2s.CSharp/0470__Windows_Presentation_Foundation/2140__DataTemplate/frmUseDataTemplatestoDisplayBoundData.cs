using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2140__DataTemplate
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UseDataTemplatestoDisplayBoundData.htm
    public partial  class frmUseDataTemplatestoDisplayBoundData:Form
    {
        public frmUseDataTemplatestoDisplayBoundData()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseDataTemplatestoDisplayBoundData
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseDataTemplatestoDisplayBoundData";
            this.Text = "frmUseDataTemplatestoDisplayBoundData";
            this.Load += new System.EventHandler(this.frmUseDataTemplatestoDisplayBoundData_Load);
            this.ResumeLayout(false);

        }

        private void frmUseDataTemplatestoDisplayBoundData_Load(object sender, EventArgs e)
        {

        }
    }
}
