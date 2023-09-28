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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Masterdetailview.htm
    public partial  class frmMasterdetailview:Form
    {
        public frmMasterdetailview()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMasterdetailview
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMasterdetailview";
            this.Text = "frmMasterdetailview";
            this.Load += new System.EventHandler(this.frmMasterdetailview_Load);
            this.ResumeLayout(false);

        }

        private void frmMasterdetailview_Load(object sender, EventArgs e)
        {

        }
    }
}
