using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0180__ComboBox
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ComboBoxItemContent.htm
    public partial  class frmComboBoxItemContent:Form
    {
        public frmComboBoxItemContent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmComboBoxItemContent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmComboBoxItemContent";
            this.Text = "frmComboBoxItemContent";
            this.Load += new System.EventHandler(this.frmComboBoxItemContent_Load);
            this.ResumeLayout(false);

        }

        private void frmComboBoxItemContent_Load(object sender, EventArgs e)
        {

        }
    }
}
