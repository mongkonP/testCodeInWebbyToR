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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/AddItemstoComboBox.htm
    public partial  class frmAddItemstoComboBox:Form
    {
        public frmAddItemstoComboBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddItemstoComboBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddItemstoComboBox";
            this.Text = "frmAddItemstoComboBox";
            this.Load += new System.EventHandler(this.frmAddItemstoComboBox_Load);
            this.ResumeLayout(false);

        }

        private void frmAddItemstoComboBox_Load(object sender, EventArgs e)
        {

        }
    }
}
