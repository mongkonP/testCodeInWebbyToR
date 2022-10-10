using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0760__Toolbar
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/DesignedToolbar.htm
    public partial  class frmDesignedToolbar:Form
    {
        public frmDesignedToolbar()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDesignedToolbar
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDesignedToolbar";
            this.Text = "frmDesignedToolbar";
            this.Load += new System.EventHandler(this.frmDesignedToolbar_Load);
            this.ResumeLayout(false);

        }

        private void frmDesignedToolbar_Load(object sender, EventArgs e)
        {

        }
    }
}
