using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0581__Directory_Services.C0040__Read
{
    //http://www.java2s.com/Tutorial/CSharp/0581__Directory-Services/ReadingKnownDirectoryObjects.htm
    public partial  class frmReadingKnownDirectoryObjects:Form
    {
        public frmReadingKnownDirectoryObjects()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadingKnownDirectoryObjects
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadingKnownDirectoryObjects";
            this.Text = "frmReadingKnownDirectoryObjects";
            this.Load += new System.EventHandler(this.frmReadingKnownDirectoryObjects_Load);
            this.ResumeLayout(false);

        }

        private void frmReadingKnownDirectoryObjects_Load(object sender, EventArgs e)
        {

        }
    }
}
