using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0760__Toolbar
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ToolbarwithComboBox.htm
    public partial  class frmToolbarwithComboBox:Form
    {
        public frmToolbarwithComboBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmToolbarwithComboBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmToolbarwithComboBox";
            this.Text = "frmToolbarwithComboBox";
            this.Load += new System.EventHandler(this.frmToolbarwithComboBox_Load);
            this.ResumeLayout(false);

        }

        private void frmToolbarwithComboBox_Load(object sender, EventArgs e)
        {

        }
    }
}
