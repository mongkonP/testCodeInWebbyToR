using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0521__Grid_Row_Column
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ColumnDefinitionWidthAuto.htm
    public partial  class frmColumnDefinitionWidthAuto:Form
    {
        public frmColumnDefinitionWidthAuto()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmColumnDefinitionWidthAuto
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmColumnDefinitionWidthAuto";
            this.Text = "frmColumnDefinitionWidthAuto";
            this.Load += new System.EventHandler(this.frmColumnDefinitionWidthAuto_Load);
            this.ResumeLayout(false);

        }

        private void frmColumnDefinitionWidthAuto_Load(object sender, EventArgs e)
        {

        }
    }
}
