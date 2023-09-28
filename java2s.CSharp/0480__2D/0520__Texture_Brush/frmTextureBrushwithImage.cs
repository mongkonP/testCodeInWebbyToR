using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0520__Texture_Brush
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/TextureBrushwithImage.htm
    public partial  class frmTextureBrushwithImage:Form
    {
        MenuItem miChecked;
        TextureBrush tbrush;
        public frmTextureBrushwithImage()
        {
            InitializeComponent();
            ResizeRedraw = true;

            Image image = Image.FromFile("your.jpg");

            tbrush = new TextureBrush(image, new Rectangle(95, 0, 50, 55));

            Menu = new MainMenu();
            Menu.MenuItems.Add("&Wrap-Mode");

            foreach (WrapMode wm in Enum.GetValues(typeof(WrapMode)))
            {
                MenuItem mi = new MenuItem();
                mi.Text = wm.ToString();
                mi.Click += new EventHandler(MenuWrapModeOnClick);
                Menu.MenuItems[0].MenuItems.Add(mi);
            }
            miChecked = Menu.MenuItems[0].MenuItems[0];
            miChecked.Checked = true;
        }
        void MenuWrapModeOnClick(object obj, EventArgs ea)
        {
            miChecked.Checked = false;
            miChecked = (MenuItem)obj;
            miChecked.Checked = true;

            tbrush.WrapMode = (WrapMode)miChecked.Index;
            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs pea)
        {
            DoPage(pea.Graphics, ForeColor, ClientSize.Width, ClientSize.Height);
        }
        protected void DoPage(Graphics grfx, Color clr, int cx, int cy)
        {
            grfx.FillEllipse(tbrush, 0, 0, 2 * cx / 3, 2 * cy / 3);
            grfx.FillEllipse(tbrush, cx / 3, cy / 3, 2 * cx / 3, 2 * cy / 3);
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTextureBrushwithImage
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTextureBrushwithImage";
            this.Text = "frmTextureBrushwithImage";
            this.Load += new System.EventHandler(this.frmTextureBrushwithImage_Load);
            this.ResumeLayout(false);

        }

        private void frmTextureBrushwithImage_Load(object sender, EventArgs e)
        {

        }
    }
}
