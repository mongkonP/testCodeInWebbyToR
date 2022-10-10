using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0440__I18N_Internationalization.C0020__CultureInfo
{
    //http://www.java2s.com/Tutorial/CSharp/0440__I18N-Internationalization/GetcurrentCulture.htm
    public partial  class frmGetcurrentCulture:Form
    {
        public frmGetcurrentCulture()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetcurrentCulture
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetcurrentCulture";
            this.Text = "frmGetcurrentCulture";
            this.Load += new System.EventHandler(this.frmGetcurrentCulture_Load);
            this.ResumeLayout(false);

        }

        private void frmGetcurrentCulture_Load(object sender, EventArgs e)
        {

        }
    }
}
