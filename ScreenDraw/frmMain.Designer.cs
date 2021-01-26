
namespace ScreenDraw
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkModoDesenho = new System.Windows.Forms.CheckBox();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.rdoElipse = new System.Windows.Forms.RadioButton();
            this.rdoRect = new System.Windows.Forms.RadioButton();
            this.rdoCurve = new System.Windows.Forms.RadioButton();
            this.rdoArrow = new System.Windows.Forms.RadioButton();
            this.rdoLinha = new System.Windows.Forms.RadioButton();
            this.rdoCorFundo1 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoCorFundo2 = new System.Windows.Forms.RadioButton();
            this.picCorFundo2 = new System.Windows.Forms.PictureBox();
            this.picCorFundo1 = new System.Windows.Forms.PictureBox();
            this.numPenWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.picPenWidth = new System.Windows.Forms.PictureBox();
            this.pnlTools.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCorFundo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCorFundo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPenWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPenWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // chkModoDesenho
            // 
            this.chkModoDesenho.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkModoDesenho.Location = new System.Drawing.Point(2, 3);
            this.chkModoDesenho.Name = "chkModoDesenho";
            this.chkModoDesenho.Size = new System.Drawing.Size(58, 38);
            this.chkModoDesenho.TabIndex = 0;
            this.chkModoDesenho.Text = "Modo Desenho";
            this.chkModoDesenho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkModoDesenho.UseVisualStyleBackColor = true;
            this.chkModoDesenho.CheckedChanged += new System.EventHandler(this.chkModoDesenho_CheckedChanged);
            // 
            // pnlTools
            // 
            this.pnlTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlTools.Controls.Add(this.rdoElipse);
            this.pnlTools.Controls.Add(this.rdoRect);
            this.pnlTools.Controls.Add(this.rdoCurve);
            this.pnlTools.Controls.Add(this.rdoArrow);
            this.pnlTools.Controls.Add(this.rdoLinha);
            this.pnlTools.Location = new System.Drawing.Point(193, 2);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(189, 40);
            this.pnlTools.TabIndex = 1;
            // 
            // rdoElipse
            // 
            this.rdoElipse.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoElipse.BackColor = System.Drawing.Color.White;
            this.rdoElipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoElipse.Image = global::ScreenDraw.Icones.Elipse;
            this.rdoElipse.Location = new System.Drawing.Point(150, 2);
            this.rdoElipse.Name = "rdoElipse";
            this.rdoElipse.Size = new System.Drawing.Size(36, 36);
            this.rdoElipse.TabIndex = 6;
            this.rdoElipse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoElipse.UseVisualStyleBackColor = false;
            this.rdoElipse.CheckedChanged += new System.EventHandler(this.rdoTool_CheckedChanged);
            // 
            // rdoRect
            // 
            this.rdoRect.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoRect.BackColor = System.Drawing.Color.White;
            this.rdoRect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoRect.Image = global::ScreenDraw.Icones.Rec;
            this.rdoRect.Location = new System.Drawing.Point(113, 2);
            this.rdoRect.Name = "rdoRect";
            this.rdoRect.Size = new System.Drawing.Size(36, 36);
            this.rdoRect.TabIndex = 5;
            this.rdoRect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoRect.UseVisualStyleBackColor = false;
            this.rdoRect.CheckedChanged += new System.EventHandler(this.rdoTool_CheckedChanged);
            // 
            // rdoCurve
            // 
            this.rdoCurve.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoCurve.BackColor = System.Drawing.Color.White;
            this.rdoCurve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoCurve.Image = global::ScreenDraw.Icones.Curva;
            this.rdoCurve.Location = new System.Drawing.Point(2, 2);
            this.rdoCurve.Name = "rdoCurve";
            this.rdoCurve.Size = new System.Drawing.Size(36, 36);
            this.rdoCurve.TabIndex = 4;
            this.rdoCurve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoCurve.UseVisualStyleBackColor = false;
            this.rdoCurve.CheckedChanged += new System.EventHandler(this.rdoTool_CheckedChanged);
            // 
            // rdoArrow
            // 
            this.rdoArrow.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoArrow.BackColor = System.Drawing.Color.White;
            this.rdoArrow.Checked = true;
            this.rdoArrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoArrow.Image = global::ScreenDraw.Icones.Seta;
            this.rdoArrow.Location = new System.Drawing.Point(76, 2);
            this.rdoArrow.Name = "rdoArrow";
            this.rdoArrow.Size = new System.Drawing.Size(36, 36);
            this.rdoArrow.TabIndex = 3;
            this.rdoArrow.TabStop = true;
            this.rdoArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoArrow.UseVisualStyleBackColor = false;
            this.rdoArrow.CheckedChanged += new System.EventHandler(this.rdoTool_CheckedChanged);
            // 
            // rdoLinha
            // 
            this.rdoLinha.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdoLinha.BackColor = System.Drawing.Color.White;
            this.rdoLinha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdoLinha.Image = global::ScreenDraw.Icones.Linha;
            this.rdoLinha.Location = new System.Drawing.Point(39, 2);
            this.rdoLinha.Name = "rdoLinha";
            this.rdoLinha.Size = new System.Drawing.Size(36, 36);
            this.rdoLinha.TabIndex = 2;
            this.rdoLinha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdoLinha.UseVisualStyleBackColor = false;
            this.rdoLinha.CheckedChanged += new System.EventHandler(this.rdoTool_CheckedChanged);
            // 
            // rdoCorFundo1
            // 
            this.rdoCorFundo1.AutoSize = true;
            this.rdoCorFundo1.Checked = true;
            this.rdoCorFundo1.Location = new System.Drawing.Point(3, 3);
            this.rdoCorFundo1.Name = "rdoCorFundo1";
            this.rdoCorFundo1.Size = new System.Drawing.Size(37, 17);
            this.rdoCorFundo1.TabIndex = 3;
            this.rdoCorFundo1.TabStop = true;
            this.rdoCorFundo1.Text = "F1";
            this.rdoCorFundo1.UseVisualStyleBackColor = true;
            this.rdoCorFundo1.CheckedChanged += new System.EventHandler(this.rdoCorFundo_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdoCorFundo2);
            this.panel2.Controls.Add(this.picCorFundo2);
            this.panel2.Controls.Add(this.rdoCorFundo1);
            this.panel2.Controls.Add(this.picCorFundo1);
            this.panel2.Location = new System.Drawing.Point(61, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(68, 40);
            this.panel2.TabIndex = 3;
            // 
            // rdoCorFundo2
            // 
            this.rdoCorFundo2.AutoSize = true;
            this.rdoCorFundo2.Location = new System.Drawing.Point(3, 20);
            this.rdoCorFundo2.Name = "rdoCorFundo2";
            this.rdoCorFundo2.Size = new System.Drawing.Size(37, 17);
            this.rdoCorFundo2.TabIndex = 5;
            this.rdoCorFundo2.Text = "F2";
            this.rdoCorFundo2.UseVisualStyleBackColor = true;
            this.rdoCorFundo2.CheckedChanged += new System.EventHandler(this.rdoCorFundo_CheckedChanged);
            // 
            // picCorFundo2
            // 
            this.picCorFundo2.BackColor = System.Drawing.Color.Green;
            this.picCorFundo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCorFundo2.Location = new System.Drawing.Point(40, 21);
            this.picCorFundo2.Name = "picCorFundo2";
            this.picCorFundo2.Size = new System.Drawing.Size(28, 19);
            this.picCorFundo2.TabIndex = 4;
            this.picCorFundo2.TabStop = false;
            this.picCorFundo2.Click += new System.EventHandler(this.picCorFundo2_Click);
            // 
            // picCorFundo1
            // 
            this.picCorFundo1.BackColor = System.Drawing.Color.Blue;
            this.picCorFundo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCorFundo1.Location = new System.Drawing.Point(40, 0);
            this.picCorFundo1.Name = "picCorFundo1";
            this.picCorFundo1.Size = new System.Drawing.Size(28, 19);
            this.picCorFundo1.TabIndex = 2;
            this.picCorFundo1.TabStop = false;
            this.picCorFundo1.Click += new System.EventHandler(this.picCorFundo_Click);
            // 
            // numPenWidth
            // 
            this.numPenWidth.Location = new System.Drawing.Point(134, 19);
            this.numPenWidth.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numPenWidth.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numPenWidth.Name = "numPenWidth";
            this.numPenWidth.Size = new System.Drawing.Size(32, 20);
            this.numPenWidth.TabIndex = 4;
            this.numPenWidth.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numPenWidth.ValueChanged += new System.EventHandler(this.numPenWidth_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Traçado";
            // 
            // picPenWidth
            // 
            this.picPenWidth.BackColor = System.Drawing.Color.White;
            this.picPenWidth.Location = new System.Drawing.Point(168, 18);
            this.picPenWidth.Name = "picPenWidth";
            this.picPenWidth.Size = new System.Drawing.Size(20, 21);
            this.picPenWidth.TabIndex = 6;
            this.picPenWidth.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 44);
            this.Controls.Add(this.picPenWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numPenWidth);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlTools);
            this.Controls.Add(this.chkModoDesenho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "SHARP Screen drawing tool";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.pnlTools.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCorFundo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCorFundo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPenWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPenWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkModoDesenho;
        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.PictureBox picCorFundo1;
        private System.Windows.Forms.RadioButton rdoArrow;
        private System.Windows.Forms.RadioButton rdoLinha;
        private System.Windows.Forms.RadioButton rdoCurve;
        private System.Windows.Forms.RadioButton rdoElipse;
        private System.Windows.Forms.RadioButton rdoRect;
        private System.Windows.Forms.RadioButton rdoCorFundo1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdoCorFundo2;
        private System.Windows.Forms.PictureBox picCorFundo2;
        private System.Windows.Forms.NumericUpDown numPenWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picPenWidth;
    }
}

