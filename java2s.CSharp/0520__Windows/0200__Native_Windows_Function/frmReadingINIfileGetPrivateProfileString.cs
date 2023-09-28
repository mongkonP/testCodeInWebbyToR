using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0200__Native_Windows_Function
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/ReadingINIfileGetPrivateProfileString.htm
    public partial  class frmReadingINIfileGetPrivateProfileString:Form
    {
        public frmReadingINIfileGetPrivateProfileString()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadingINIfileGetPrivateProfileString
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadingINIfileGetPrivateProfileString";
            this.Text = "frmReadingINIfileGetPrivateProfileString";
            this.Load += new System.EventHandler(this.frmReadingINIfileGetPrivateProfileString_Load);
            this.ResumeLayout(false);

        }

        private void frmReadingINIfileGetPrivateProfileString_Load(object sender, EventArgs e)
        {

        }
    }
}
