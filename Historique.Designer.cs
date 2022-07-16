namespace Dofus_Fm
{
    partial class Historique
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.lblAction = new MaterialSkin.Controls.MaterialLabel();
            this.lblTemps = new System.Windows.Forms.Label();
            this.picRune2 = new System.Windows.Forms.PictureBox();
            this.picRune1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picRune2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRune1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.Depth = 0;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotal.Location = new System.Drawing.Point(189, 0);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(91, 50);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAction
            // 
            this.lblAction.Depth = 0;
            this.lblAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAction.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAction.Location = new System.Drawing.Point(80, 0);
            this.lblAction.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(109, 32);
            this.lblAction.TabIndex = 3;
            this.lblAction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTemps
            // 
            this.lblTemps.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTemps.ForeColor = System.Drawing.Color.Gray;
            this.lblTemps.Location = new System.Drawing.Point(80, 32);
            this.lblTemps.Name = "lblTemps";
            this.lblTemps.Size = new System.Drawing.Size(109, 18);
            this.lblTemps.TabIndex = 4;
            // 
            // picRune2
            // 
            this.picRune2.Dock = System.Windows.Forms.DockStyle.Left;
            this.picRune2.Location = new System.Drawing.Point(40, 0);
            this.picRune2.MaximumSize = new System.Drawing.Size(40, 50);
            this.picRune2.Name = "picRune2";
            this.picRune2.Size = new System.Drawing.Size(40, 50);
            this.picRune2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picRune2.TabIndex = 1;
            this.picRune2.TabStop = false;
            // 
            // picRune1
            // 
            this.picRune1.Dock = System.Windows.Forms.DockStyle.Left;
            this.picRune1.Location = new System.Drawing.Point(0, 0);
            this.picRune1.MaximumSize = new System.Drawing.Size(40, 50);
            this.picRune1.Name = "picRune1";
            this.picRune1.Size = new System.Drawing.Size(40, 50);
            this.picRune1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picRune1.TabIndex = 0;
            this.picRune1.TabStop = false;
            // 
            // Historique
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTemps);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.picRune2);
            this.Controls.Add(this.picRune1);
            this.MaximumSize = new System.Drawing.Size(280, 50);
            this.MinimumSize = new System.Drawing.Size(280, 50);
            this.Name = "Historique";
            this.Size = new System.Drawing.Size(280, 50);
            ((System.ComponentModel.ISupportInitialize)(this.picRune2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRune1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picRune1;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private MaterialSkin.Controls.MaterialLabel lblAction;
        private System.Windows.Forms.Label lblTemps;
        private System.Windows.Forms.PictureBox picRune2;
    }
}
