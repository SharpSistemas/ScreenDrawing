using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ScreenDraw
{
    public partial class frmMain : Form
    {
        public static frmMain Instance = null;

        public Color CurrentColor
        {
            get
            {
                if (rdoCorFundo1.Checked) return picCorFundo1.BackColor;
                return picCorFundo2.BackColor;
            }
        }
        public DrawableTool CurrentTool = DrawableTool.Line;

        public frmMain()
        {
            Instance = this;
            InitializeComponent();
        }
        frmDrawCanvas frm;

        private void frmMain_Load(object sender, EventArgs e)
        {
            Icon = Icones.Icone;
            Location = new Point();
        }
        private void frmMain_Shown(object sender, EventArgs e)
        {
            loadConfig();

            TopMost = true;
            updatePenPreview();
            rdoTool_CheckedChanged(null, EventArgs.Empty);
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveConfig();
        }

        private void loadConfig()
        {
            var cfg = Configuration.LoadConfig();
            picCorFundo1.BackColor = cfg.Color1;
            picCorFundo2.BackColor = cfg.Color2;
            numPenWidth.Value = cfg.TraceWidth;
        }
        private void saveConfig()
        {
            var cfg = new Configuration()
            {
                Color1 = picCorFundo1.BackColor,
                Color2 = picCorFundo2.BackColor,
                TraceWidth = (int)numPenWidth.Value,
            };
            cfg.SaveConfig();
        }

        public Drawable GetNewTool(Point Point)
        {
            if (CurrentTool == DrawableTool.Arrow)
            {
                return new Drawables.Arrow()
                {
                    Pen =  getPen(), //new Pen(CurrentColor, 3),
                    StartPoint = Point,
                    P2 = Point,
                };
            }
            if (CurrentTool == DrawableTool.Line)
            {
                return new Drawables.Line()
                {
                    Pen = getPen(),
                    StartPoint = Point,
                    P2 = Point,
                };
            }
            if (CurrentTool == DrawableTool.Rectangle)
            {
                return new Drawables.Box()
                {
                    Pen = getPen(),
                    StartPoint = Point,
                    P2 = Point,
                };
            }
            if (CurrentTool == DrawableTool.Elipse)
            {
                return new Drawables.Elipse()
                {
                    Pen = getPen(),
                    StartPoint = Point,
                    P2 = Point,
                };
            }
            if (CurrentTool == DrawableTool.Curve)
            {
                return new Drawables.Curve()
                {
                    Pen = getPen(),
                    StartPoint = Point,
                };
            }

            return null;
        }

        private Pen getPen()
        {
            return new Pen(CurrentColor, (int)numPenWidth.Value);
        }

        private void chkModoDesenho_CheckedChanged(object sender, EventArgs e)
        {
            if (chkModoDesenho.Checked)
            {
                var currScreen = Screen.FromControl(this);
                
                frm = new frmDrawCanvas();                
                frm.Show();
                frm.Location = currScreen.Bounds.Location;
                frm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                frm.Close();
            }
        }

        private void rdoCorFundo_CheckedChanged(object sender, EventArgs e)
        {
            updatePenPreview();
        }
        private void picCorFundo_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = picCorFundo1.BackColor;

            if (dlg.ShowDialog() == DialogResult.Cancel) return;
            if (dlg.Color == Color.Red)
                dlg.Color = Color.FromArgb(250, 0, 0);

            picCorFundo1.BackColor = dlg.Color;
            updatePenPreview();
        }
        private void picCorFundo2_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = picCorFundo2.BackColor;

            if (dlg.ShowDialog() == DialogResult.Cancel) return;
            if (dlg.Color == Color.Red)
                dlg.Color = Color.FromArgb(250, 0, 0);

            picCorFundo2.BackColor = dlg.Color;
            updatePenPreview();
        }
        private void numPenWidth_ValueChanged(object sender, EventArgs e)
        {
            updatePenPreview();
        }

        void updatePenPreview()
        {
            picPenWidth.Image = null;
            var bmp = new Bitmap(picPenWidth.Width, picPenWidth.Height);

            Color bkg = Color.White;
            if (Math.Abs(Color.DarkBlue.GetBrightness() - CurrentColor.GetBrightness()) >= 0.5) bkg = Color.DarkBlue;

            using (var g = Graphics.FromImage(bmp))
            {
                g.Clear(bkg);
                g.DrawLine(getPen(), 0, picPenWidth.Height / 2, picPenWidth.Width, picPenWidth.Height / 2);
            }
            picPenWidth.Image = bmp;
        }

        private void rdoTool_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var r in pnlTools.Controls.OfType<RadioButton>())
            {
                if (r.Checked)
                    r.BackColor = Color.Gray;
                else
                    r.BackColor = Color.White;
            }

            if (rdoLinha.Checked) CurrentTool = DrawableTool.Line;
            if (rdoArrow.Checked) CurrentTool = DrawableTool.Arrow;
            if (rdoCurve.Checked) CurrentTool = DrawableTool.Curve;
            if (rdoRect.Checked) CurrentTool = DrawableTool.Rectangle;
            if (rdoElipse.Checked) CurrentTool = DrawableTool.Elipse;
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            processHotKey(e.KeyCode);
        }

        public void processHotKey(Keys keyCode)
        {
            if (keyCode == Keys.Escape)
            {
                if (chkModoDesenho.Checked) chkModoDesenho.Checked = false;
            }
            if (keyCode == Keys.F1) rdoCorFundo1.Checked = true;
            if (keyCode == Keys.F2) rdoCorFundo2.Checked = true;
            if (keyCode == Keys.Z)
            {
                if (ModifierKeys == Keys.Control)
                {
                    frm?.RemoveLastDrawable();
                }
            }
        }

    }
}