using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1500__File_Explore
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/AFileExploreClone.htm
    public partial  class frmAFileExploreClone:Form
    {
        public frmAFileExploreClone()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAFileExploreClone
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAFileExploreClone";
            this.Text = "frmAFileExploreClone";
            this.Load += new System.EventHandler(this.frmAFileExploreClone_Load);
            this.ResumeLayout(false);

        }

        private void frmAFileExploreClone_Load(object sender, EventArgs e)
        {

        }
    }
}
