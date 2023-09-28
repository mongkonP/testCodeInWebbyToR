using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0540__ListBox
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/AddContextMenutoListBox.htm
    public partial  class frmAddContextMenutoListBox:Form
    {
        public frmAddContextMenutoListBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddContextMenutoListBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddContextMenutoListBox";
            this.Text = "frmAddContextMenutoListBox";
            this.Load += new System.EventHandler(this.frmAddContextMenutoListBox_Load);
            this.ResumeLayout(false);

        }

        private void frmAddContextMenutoListBox_Load(object sender, EventArgs e)
        {

        }
    }
}
