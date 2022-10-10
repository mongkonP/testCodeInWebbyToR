using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2360__BackgroundWorker
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CreateaBackgroundWorkerThreadinXAML.htm
    public partial  class frmCreateaBackgroundWorkerThreadinXAML:Form
    {
        public frmCreateaBackgroundWorkerThreadinXAML()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateaBackgroundWorkerThreadinXAML
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateaBackgroundWorkerThreadinXAML";
            this.Text = "frmCreateaBackgroundWorkerThreadinXAML";
            this.Load += new System.EventHandler(this.frmCreateaBackgroundWorkerThreadinXAML_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateaBackgroundWorkerThreadinXAML_Load(object sender, EventArgs e)
        {

        }
    }
}
