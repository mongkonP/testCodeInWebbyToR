using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0380__FileStream
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Openafilewithexceptionhandling.htm
    public partial  class frmOpenafilewithexceptionhandling:Form
    {
        public frmOpenafilewithexceptionhandling()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOpenafilewithexceptionhandling
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOpenafilewithexceptionhandling";
            this.Text = "frmOpenafilewithexceptionhandling";
            this.Load += new System.EventHandler(this.frmOpenafilewithexceptionhandling_Load);
            this.ResumeLayout(false);

        }

        private void frmOpenafilewithexceptionhandling_Load(object sender, EventArgs e)
        {

        }
    }
}
