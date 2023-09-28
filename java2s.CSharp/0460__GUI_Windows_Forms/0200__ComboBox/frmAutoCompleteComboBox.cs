using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0200__ComboBox
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/AutoCompleteComboBox.htm
    public partial  class frmAutoCompleteComboBox:Form
    {
        public frmAutoCompleteComboBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAutoCompleteComboBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAutoCompleteComboBox";
            this.Text = "frmAutoCompleteComboBox";
            this.Load += new System.EventHandler(this.frmAutoCompleteComboBox_Load);
            this.ResumeLayout(false);

        }

        private void frmAutoCompleteComboBox_Load(object sender, EventArgs e)
        {

        }
    }
}
