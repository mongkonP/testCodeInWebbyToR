using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0344__ListBox_Style
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DifferentFontFamilyandSizeforeachListBoxItem.htm
    public partial  class frmDifferentFontFamilyandSizeforeachListBoxItem:Form
    {
        public frmDifferentFontFamilyandSizeforeachListBoxItem()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDifferentFontFamilyandSizeforeachListBoxItem
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDifferentFontFamilyandSizeforeachListBoxItem";
            this.Text = "frmDifferentFontFamilyandSizeforeachListBoxItem";
            this.Load += new System.EventHandler(this.frmDifferentFontFamilyandSizeforeachListBoxItem_Load);
            this.ResumeLayout(false);

        }

        private void frmDifferentFontFamilyandSizeforeachListBoxItem_Load(object sender, EventArgs e)
        {

        }
    }
}
