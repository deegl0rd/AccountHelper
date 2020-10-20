namespace AccountHelper.src.Beallitasok
{
    partial class BeallitasokAblak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeallitasokAblak));
            this.beallitasokLista = new BrightIdeasSoftware.ObjectListView();
            this.oszlop_Ikon = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.oszlop_Nev = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.beallitas_Ikonok = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.beallitasokLista)).BeginInit();
            this.SuspendLayout();
            // 
            // beallitasokLista
            // 
            this.beallitasokLista.AllColumns.Add(this.oszlop_Ikon);
            this.beallitasokLista.AllColumns.Add(this.oszlop_Nev);
            this.beallitasokLista.CellEditUseWholeCell = false;
            this.beallitasokLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.oszlop_Ikon,
            this.oszlop_Nev});
            this.beallitasokLista.Cursor = System.Windows.Forms.Cursors.Default;
            this.beallitasokLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.beallitasokLista.FullRowSelect = true;
            this.beallitasokLista.GridLines = true;
            this.beallitasokLista.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.beallitasokLista.HideSelection = false;
            this.beallitasokLista.Location = new System.Drawing.Point(12, 12);
            this.beallitasokLista.Name = "beallitasokLista";
            this.beallitasokLista.RowHeight = 32;
            this.beallitasokLista.ShowGroups = false;
            this.beallitasokLista.Size = new System.Drawing.Size(244, 136);
            this.beallitasokLista.SmallImageList = this.beallitas_Ikonok;
            this.beallitasokLista.TabIndex = 1;
            this.beallitasokLista.UseCompatibleStateImageBehavior = false;
            this.beallitasokLista.View = System.Windows.Forms.View.Details;
            // 
            // oszlop_Ikon
            // 
            this.oszlop_Ikon.AspectName = "";
            this.oszlop_Ikon.Text = "Ikon";
            this.oszlop_Ikon.Width = 40;
            // 
            // oszlop_Nev
            // 
            this.oszlop_Nev.AspectName = "nev";
            this.oszlop_Nev.Text = "Beállítás";
            this.oszlop_Nev.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.oszlop_Nev.Width = 200;
            // 
            // beallitas_Ikonok
            // 
            this.beallitas_Ikonok.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("beallitas_Ikonok.ImageStream")));
            this.beallitas_Ikonok.TransparentColor = System.Drawing.Color.Transparent;
            this.beallitas_Ikonok.Images.SetKeyName(0, "alkalmazas");
            this.beallitas_Ikonok.Images.SetKeyName(1, "xkrolvaso");
            this.beallitas_Ikonok.Images.SetKeyName(2, "nyilvantartas");
            this.beallitas_Ikonok.Images.SetKeyName(3, "licensz");
            // 
            // BeallitasokAblak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 573);
            this.Controls.Add(this.beallitasokLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BeallitasokAblak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beállítások";
            this.Load += new System.EventHandler(this.BeallitasokAblak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.beallitasokLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView beallitasokLista;
        private BrightIdeasSoftware.OLVColumn oszlop_Ikon;
        private System.Windows.Forms.ImageList beallitas_Ikonok;
        private BrightIdeasSoftware.OLVColumn oszlop_Nev;
    }
}