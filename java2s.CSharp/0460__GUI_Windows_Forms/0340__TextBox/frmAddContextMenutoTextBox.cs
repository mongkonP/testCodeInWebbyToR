using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0340__TextBox
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/AddContextMenutoTextBox.htm
    public partial  class frmAddContextMenutoTextBox:Form
    {
        public frmAddContextMenutoTextBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddContextMenutoTextBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddContextMenutoTextBox";
            this.Text = "frmAddContextMenutoTextBox";
            this.Load += new System.EventHandler(this.frmAddContextMenutoTextBox_Load);
            this.ResumeLayout(false);

        }

        private void frmAddContextMenutoTextBox_Load(object sender, EventArgs e)
        {

        }
    }
}
