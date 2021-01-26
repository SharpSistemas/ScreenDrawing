
namespace ScreenDraw
{
    partial class frmDrawCanvas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Interval = 32;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // frmDrawCanvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 399);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KeyPreview = true;
            this.Name = "frmDrawCanvas";
            this.Opacity = 0.99D;
            this.Load += new System.EventHandler(this.frmDrawCanvas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDrawCanvas_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmDrawCanvas_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmDrawCanvas_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmDrawCanvas_MouseUp);

        }

        #endregion

        private System.Windows.Forms.Timer tmrUpdate;
    }
}