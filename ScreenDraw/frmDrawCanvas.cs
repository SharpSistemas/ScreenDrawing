using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenDraw
{
    public partial class frmDrawCanvas : Form
    {
        Drawable current = null;
        List<Drawable> lstDrawables;
        bool changed = false;
        public frmDrawCanvas()
        {
            InitializeComponent();

            TransparencyKey = 
                BackColor = Color.Red;

            lstDrawables = new List<Drawable>();
        }

        private void frmDrawCanvas_Load(object sender, EventArgs e)
        {
            Icon = Icones.Icone;

            //WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            Capture = true;
            tmrUpdate.Enabled = true;
        }

        private void frmDrawCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            current = frmMain.Instance.GetNewTool(e.Location);
            if (current == null) return;
            lastPoint = DateTime.Now;
            lstDrawables.Add(current);
        }

        public void RemoveLastDrawable()
        {
            current = null;
            if (lstDrawables.Count > 0) lstDrawables.RemoveAt(lstDrawables.Count - 1);
            Invalidate();
        }

        private void frmDrawCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            current = null;
        }
        DateTime lastPoint;
        private void frmDrawCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (current == null) return;

            // 60 fps
            if ((DateTime.Now - lastPoint).TotalMilliseconds < 16) return;

            current.AddPoint(e.Location);
            lastPoint = DateTime.Now;
            changed = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // enquanto o fundo for vermelho, o AA manchará de vermelho
            //e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            foreach (var v in lstDrawables.ToArray()) v.Draw(e.Graphics);
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            if (!changed) return;
            changed = false;
            Invalidate();
        }

        private void frmDrawCanvas_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            frmMain.Instance.processHotKey(e.KeyCode);
        }
    }
}
