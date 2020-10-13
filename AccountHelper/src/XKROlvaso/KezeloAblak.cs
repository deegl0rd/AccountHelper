using AccountHelper.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace AccountHelper.src.XKROlvaso
{
    public partial class KezeloAblak : Form
    {
        #region Munkamezők

        const string work_Folder_name = "temp";
        string work_Folder;
        XmlKezelo xml;
        ExcelKezelo exc;
        NevjegyPanel nevjegy;

        #endregion

        #region Konstruktor

        public KezeloAblak()
        {
            InitializeComponent();
        }

        #endregion

        #region Mappa tartalom törlő metódus

        private void MappaTartalomTorol(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }

            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }

        #endregion

        #region Excel fájl készítő metódus

        private void ExcelKeszit()
        {
            if (String.IsNullOrEmpty(Settings.Default["OutputFolder"].ToString()))
            {
                MessageBox.Show(null, "Az excel fájl létrehozása nem sikerült, mert nincs kimeneti mappa beállítva!", "Kimeneti mappa hiányzik!");
                return;
            }

            string excelFajlNeve = "Excel kimutatás - " + DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH'-'mm'-'ss");
            string excelFajlHelye = Settings.Default["OutputFolder"].ToString() + "\\" + excelFajlNeve + ".xlsx";

            exc = new ExcelKezelo(Settings.Default["OutputFolder"].ToString(), excelFajlNeve);
            List<ListViewItem> list = new List<ListViewItem>(); ;

            foreach (ListViewItem item in Lista.SelectedItems)
            {
                list.Add(item);
            }

            for (int i = 0; i < list.Count; i++)
            {
                int j = i + 2;
                exc.CellaIr("A" + j, list[i].Text);
                exc.CellaIr("B" + j, list[i].SubItems[1].Text);
                exc.CellaIr("C" + j, list[i].SubItems[2].Text);
                exc.CellaIr("D" + j, list[i].SubItems[3].Text);
                exc.CellaIr("E" + j, list[i].SubItems[4].Text);
                exc.CellaIr("F" + j, list[i].SubItems[5].Text);
                exc.CellaIr("G" + j, list[i].SubItems[6].Text);
            }

            exc.ExcelBezar();

            list.Clear();

            foreach (ListViewItem item in Lista.Items)
            {
                item.Selected = false;
            }

            ExcelKeszMsg(excelFajlHelye);
        }

        #endregion

        #region Excel Messagebox

        private void ExcelKeszMsg(string fajlHelye)
        {
            DialogResult result = MessageBox.Show(null, "Szeretné megnyitni?", "Az excel fájl elkészült!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(fajlHelye);
            }
        }

        #endregion

        #region Listához adó metódus

        private void ListahozAd(string file)
        {
            xml = new XmlKezelo(file);
            ListViewItem item;

            item = new ListViewItem(xml.Nev)
            {
                UseItemStyleForSubItems = false,
            };

            item.SubItems.Add(xml.DatumKezdete);
            item.SubItems.Add(xml.DatumVege);
            item.SubItems.Add(xml.DatumNapokSzama);
            item.SubItems.Add(xml.Adoazonosito);
            item.SubItems.Add(xml.Tajszam);
            item.SubItems.Add(xml.Tipus);

            item.SubItems[6].Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular);

            Lista.Items.Add(item);

            if (item.SubItems[6].Text.Equals("U"))
            {
                item.SubItems[6].ForeColor = Color.Blue;
            }
            else if (item.SubItems[6].Text.Equals("I"))
            {
                item.SubItems[6].ForeColor = Color.Red;
            }
        }

        #endregion

        #region Ablak betöltés event

        private void KezeloAblak_Load(object sender, EventArgs e)
        {
            nevjegy = new NevjegyPanel();
            work_Folder = Application.StartupPath + "/" + work_Folder_name;
            kimenetiHely.Text = Settings.Default["OutputFolder"].ToString();

            Lista.Columns[0].Width = (int)Settings.Default["oszlop0"];
            Lista.Columns[1].Width = (int)Settings.Default["oszlop1"];
            Lista.Columns[2].Width = (int)Settings.Default["oszlop2"];
            Lista.Columns[3].Width = (int)Settings.Default["oszlop3"];
            Lista.Columns[4].Width = (int)Settings.Default["oszlop4"];
            Lista.Columns[5].Width = (int)Settings.Default["oszlop5"];
            Lista.Columns[6].Width = (int)Settings.Default["oszlop6"];
        }

        #endregion

        #region Fájlnyitó ablak event

        private void FajlNyito_FileOk(object sender, CancelEventArgs e)
        {
            int items_countBefore = 0, items_countAfter = 0;

            string xkrFileName;
            string zipFileName;

            foreach (string filePath in fajlNyito.FileNames)
            {
                if (Path.GetExtension(filePath) == ".xkr")
                {
                    xkrFileName = Path.GetFileName(filePath);

                    if (!File.Exists(work_Folder + "/" + xkrFileName))
                    {
                        File.Copy(filePath, work_Folder + "/" + xkrFileName);
                    }
                }
                else if (Path.GetExtension(filePath) == ".zip")
                {
                    zipFileName = Path.GetFileNameWithoutExtension(filePath);
                    string folder = work_Folder + "/" + zipFileName;
                    Directory.CreateDirectory(folder);
                    ZipFile.ExtractToDirectory(filePath, folder);
                }
            };

            foreach (string file in Directory.GetFiles(work_Folder, "*.xkr", SearchOption.AllDirectories))
            {
                items_countBefore = Lista.Items.Count;
                ListahozAd(file);
                items_countAfter = Lista.Items.Count;
            }

            if (items_countBefore != items_countAfter)
            {
                fajlBehuzasSzoveg.Visible = false;
            }
            else
            {
                MessageBox.Show("Ennek a fájlnak nincs .xkr fájl tartalma!", "Nincs .xkr!");
            }

            MappaTartalomTorol(work_Folder);
        }

        #endregion

        #region Gombok

        private void KimenetGomb_Click(object sender, EventArgs e)
        {
            DialogResult dr = helyValaszto.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Settings.Default["OutputFolder"] = helyValaszto.SelectedPath;
                Settings.Default.Save();
                kimenetiHely.Text = Settings.Default["OutputFolder"].ToString();
            }
        }

        private void FajlokGomb_Click(object sender, EventArgs e)
        {
            fajlNyito.ShowDialog();
        }

        private void NevjegyGomb_Click(object sender, EventArgs e)
        {
            nevjegy.ShowDialog();
        }

        private void ExcelKonvertalGomb_Click(object sender, EventArgs e)
        {
            if (Lista.Items.Count == 0) return;
            MindenKijelolMenupont_Click(this, null);
            ExcelKeszit();
        }

        private void TorlesGomb_Click(object sender, EventArgs e)
        {
            if (Lista.Items.Count == 0) return;

            MindenKijelolMenupont_Click(this, null);
            TorlesMenupont_Click(this, null);

            Lista.Sorting = SortOrder.None;
            rendezesGomb.Text = "Rendezés: Nincs";
        }

        private void RendezesGomb_Click(object sender, EventArgs e)
        {
            if (Lista.Items.Count <= 1) return;

            switch (Lista.Sorting)
            {
                case SortOrder.None:
                    {
                        Lista.Sorting = SortOrder.Ascending;
                        rendezesGomb.Text = "Rendezés: A-Z";
                        break;
                    }
                case SortOrder.Ascending:
                    {
                        Lista.Sorting = SortOrder.Descending;
                        rendezesGomb.Text = "Rendezés: Z-A";
                        break;
                    }
                case SortOrder.Descending:
                    {
                        Lista.Sorting = SortOrder.Ascending;
                        rendezesGomb.Text = "Rendezés: A-Z";
                        break;
                    }
            }
        }

        #endregion

        #region Lista eventek

        private void Lista_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (Lista.FocusedItem.Bounds.Contains(e.Location))
                {
                    if (Lista.SelectedItems.Count > 1)
                    {
                        jobbKlikkMenu.Items[0].Visible = false;
                    }
                    else
                    {
                        jobbKlikkMenu.Items[0].Visible = true;
                    }

                    jobbKlikkMenu.Show(Cursor.Position);
                }
            }
        }

        private void Lista_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                TorlesMenupont_Click(this, null);
            }
            else if (e.KeyCode == Keys.E && e.Modifiers == Keys.Control)
            {
                ExcelKonvertalasMenupont_Click(this, null);
            }
            else if (e.KeyCode == Keys.A && e.Modifiers == Keys.Control)
            {
                MindenKijelolMenupont_Click(this, null);
            }
        }

        private void Lista_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            Settings.Default["oszlop" + e.ColumnIndex.ToString()] = Lista.Columns[e.ColumnIndex].Width;
            Settings.Default.Save();
        }

        private void Lista_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            switch (Lista.Sorting)
            {
                case SortOrder.None:
                    {
                        Lista.Sorting = SortOrder.Ascending;
                        rendezesGomb.Text = "Rendezés: A-Z";
                        break;
                    }
                case SortOrder.Ascending:
                    {
                        Lista.Sorting = SortOrder.Descending;
                        rendezesGomb.Text = "Rendezés: Z-A";
                        break;
                    }
                case SortOrder.Descending:
                    {
                        Lista.Sorting = SortOrder.Ascending;
                        rendezesGomb.Text = "Rendezés: A-Z";
                        break;
                    }
            }
        }

        #endregion

        #region Lista behúzás eventek

        private void Lista_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
            fajlBehuzasSzoveg.ForeColor = Color.Red;
            fajlBehuzasSzoveg.BackColor = Color.FloralWhite;
        }

        private void Lista_DragLeave(object sender, EventArgs e)
        {
            fajlBehuzasSzoveg.ForeColor = Color.Gray;
            fajlBehuzasSzoveg.BackColor = Color.White;
        }

        private void Lista_DragDrop(object sender, DragEventArgs e)
        {
            string xkrFileName;
            string zipFileName;

            int items_countBefore = 0, items_countAfter = 0;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            foreach (string filePath in files)
            {
                if (Path.GetExtension(filePath) == ".xkr")
                {
                    xkrFileName = Path.GetFileName(filePath);

                    if (!File.Exists(work_Folder + "/" + xkrFileName))
                    {
                        File.Copy(filePath, work_Folder + "/" + xkrFileName);
                    }
                }
                else if (Path.GetExtension(filePath) == ".zip")
                {
                    zipFileName = Path.GetFileNameWithoutExtension(filePath);
                    string folder = work_Folder + "/" + zipFileName;
                    Directory.CreateDirectory(folder);
                    ZipFile.ExtractToDirectory(filePath, folder);
                }
                else
                {
                    fajlBehuzasSzoveg.ForeColor = Color.Gray;
                    fajlBehuzasSzoveg.BackColor = Color.White;
                    MessageBox.Show("A program csak .xkr és .zip kiterjesztésű fájlokat fogad el!", "Nem támogatott formátum");
                    return;
                }
            };

            foreach (string file in Directory.GetFiles(work_Folder, "*.xkr", SearchOption.AllDirectories))
            {

                items_countBefore = Lista.Items.Count;
                ListahozAd(file);
                items_countAfter = Lista.Items.Count;
            }

            fajlBehuzasSzoveg.ForeColor = Color.Gray;
            fajlBehuzasSzoveg.BackColor = Color.White;

            if (items_countBefore != items_countAfter)
            {
                fajlBehuzasSzoveg.Visible = false;
            }
            else
            {
                MessageBox.Show("Ennek a fájlnak nincs .xkr fájl tartalma!", "Nincs .xkr!");
            }

            MappaTartalomTorol(work_Folder);
        }

        #endregion

        #region Fájl behúzás szöveg eventek

        private void FajlBehuzasSzoveg_DragEnter(object sender, DragEventArgs e)
        {
            Lista_DragEnter(this, e);
        }

        private void FajlBehuzasSzoveg_DragLeave(object sender, EventArgs e)
        {
            Lista_DragLeave(this, e);
        }

        private void FajlBehuzasSzoveg_DragDrop(object sender, DragEventArgs e)
        {
            Lista_DragDrop(this, e);
        }

        #endregion

        #region Menüpont eventek

        private void NevMasolasaMenupont_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Lista.FocusedItem.Text);
        }

        private void MikortolMasolasaMenupont_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Lista.FocusedItem.SubItems[1].Text);
        }

        private void MeddigMasolasaMenupont_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Lista.FocusedItem.SubItems[2].Text);
        }

        private void NapokMasolasaMenupont_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Lista.FocusedItem.SubItems[3].Text);
        }

        private void AdoszamMasolasaMenupont_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Lista.FocusedItem.SubItems[4].Text);
        }

        private void TajszamMasolasaMenupont_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Lista.FocusedItem.SubItems[5].Text);
        }

        private void TipusMasolasaMenupont_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Lista.FocusedItem.SubItems[6].Text);
        }

        private void TorlesMenupont_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in Lista.SelectedItems)
            {
                item.Remove();
            }

            if (Lista.Items.Count == 0)
            {
                fajlBehuzasSzoveg.Visible = true;
            }
        }

        private void MindenKijelolMenupont_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in Lista.Items)
            {
                item.Selected = true;
            }
        }

        private void ExcelKonvertalasMenupont_Click(object sender, EventArgs e)
        {
            if (Lista.Items.Count == 0) return;
            ExcelKeszit();
        }

        private void MindentExcelbeKonvertalasMenupont_Click(object sender, EventArgs e)
        {
            ExcelKonvertalGomb_Click(this, null);
        }

        #endregion
    }
}