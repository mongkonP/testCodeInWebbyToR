using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1280__event
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/EventsCustomAddandRemovewithGlobaldelegatecache.htm
    public partial  class frmEventsCustomAddandRemovewithGlobaldelegatecache:Form
    {
        public frmEventsCustomAddandRemovewithGlobaldelegatecache()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEventsCustomAddandRemovewithGlobaldelegatecache
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEventsCustomAddandRemovewithGlobaldelegatecache";
            this.Text = "frmEventsCustomAddandRemovewithGlobaldelegatecache";
            this.Load += new System.EventHandler(this.frmEventsCustomAddandRemovewithGlobaldelegatecache_Load);
            this.ResumeLayout(false);

        }

        private void frmEventsCustomAddandRemovewithGlobaldelegatecache_Load(object sender, EventArgs e)
        {

        }
    }
}
