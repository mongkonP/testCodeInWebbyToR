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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ColumnDefinitionWidth.htm
    public partial  class frmColumnDefinitionWidth:Form
    {
        public frmColumnDefinitionWidth()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmColumnDefinitionWidth
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmColumnDefinitionWidth";
            this.Text = "frmColumnDefinitionWidth";
            this.Load += new System.EventHandler(this.frmColumnDefinitionWidth_Load);
            this.ResumeLayout(false);

        }

        private void frmColumnDefinitionWidth_Load(object sender, EventArgs e)
        {

        }
    }
}
