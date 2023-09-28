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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/GetItemsinaComboBox.htm
    public partial  class frmGetItemsinaComboBox:Form
    {
        public frmGetItemsinaComboBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetItemsinaComboBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetItemsinaComboBox";
            this.Text = "frmGetItemsinaComboBox";
            this.Load += new System.EventHandler(this.frmGetItemsinaComboBox_Load);
            this.ResumeLayout(false);

        }

        private void frmGetItemsinaComboBox_Load(object sender, EventArgs e)
        {

        }
    }
}
