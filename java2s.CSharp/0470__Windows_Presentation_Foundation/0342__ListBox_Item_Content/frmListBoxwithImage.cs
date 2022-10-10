using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0342__ListBox_Item_Content
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ListBoxwithImage.htm
    public partial  class frmListBoxwithImage:Form
    {
        public frmListBoxwithImage()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListBoxwithImage
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListBoxwithImage";
            this.Text = "frmListBoxwithImage";
            this.Load += new System.EventHandler(this.frmListBoxwithImage_Load);
            this.ResumeLayout(false);

        }

        private void frmListBoxwithImage_Load(object sender, EventArgs e)
        {

        }
    }
}
