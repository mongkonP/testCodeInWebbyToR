using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1420__Image
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CreateImagefromBitmapImage.htm
    public partial  class frmCreateImagefromBitmapImage:Form
    {
        public frmCreateImagefromBitmapImage()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateImagefromBitmapImage
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateImagefromBitmapImage";
            this.Text = "frmCreateImagefromBitmapImage";
            this.Load += new System.EventHandler(this.frmCreateImagefromBitmapImage_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateImagefromBitmapImage_Load(object sender, EventArgs e)
        {

        }
    }
}
