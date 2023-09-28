using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1600__DataBinding_ListBox
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/BindArrayListtoListBox.htm
    public partial  class frmBindArrayListtoListBox:Form
    {
        public frmBindArrayListtoListBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBindArrayListtoListBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBindArrayListtoListBox";
            this.Text = "frmBindArrayListtoListBox";
            this.Load += new System.EventHandler(this.frmBindArrayListtoListBox_Load);
            this.ResumeLayout(false);

        }

        private void frmBindArrayListtoListBox_Load(object sender, EventArgs e)
        {

        }
    }
}
