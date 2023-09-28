using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0220__Hotkey
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/DrawStringsHotkey.htm
    public partial  class frmDrawStringsHotkey:Form
    {
        public frmDrawStringsHotkey()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDrawStringsHotkey
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDrawStringsHotkey";
            this.Text = "frmDrawStringsHotkey";
            this.Load += new System.EventHandler(this.frmDrawStringsHotkey_Load);
            this.ResumeLayout(false);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            StringFormat fmt = new StringFormat();
            fmt.Alignment = StringAlignment.Center;
            fmt.HotkeyPrefix = HotkeyPrefix.Show;

            Brush b = new SolidBrush(ForeColor);
            g.DrawString("&Do It!", Font, b, ClientSize.Width / 2, 50, fmt);
        }

        private void frmDrawStringsHotkey_Load(object sender, EventArgs e)
        {

        }
    }
}
