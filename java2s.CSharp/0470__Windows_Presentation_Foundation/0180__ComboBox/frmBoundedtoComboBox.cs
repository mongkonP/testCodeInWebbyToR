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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/BoundedtoComboBox.htm
    public partial  class frmBoundedtoComboBox:Form
    {
        public frmBoundedtoComboBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBoundedtoComboBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBoundedtoComboBox";
            this.Text = "frmBoundedtoComboBox";
            this.Load += new System.EventHandler(this.frmBoundedtoComboBox_Load);
            this.ResumeLayout(false);

        }

        private void frmBoundedtoComboBox_Load(object sender, EventArgs e)
        {

        }
    }
}
