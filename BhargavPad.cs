using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BhargavPad
{
    public partial class formBhargavPad : Form
    {

        string openFile = String.Empty;

        public formBhargavPad()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This will close the form.
        /// </summary>
        private void ExitClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// This will save the file.
        /// </summary>
        private void SaveClick(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// This will cut the selected properties. 
        /// </summary>
        private void CutClick(object sender, EventArgs e)
        {
            textBoxBody.Cut();
        }

        /// <summary>
        /// This will copy the selected properties.
        /// </summary>
        private void CopyClick(object sender, EventArgs e)
        {
            textBoxBody.Copy();
        }

        /// <summary>
        /// This will paste the cut or copied text. 
        /// </summary>
        
        private void PasteClick(object sender, EventArgs e)
        {
            textBoxBody.Paste();
        }

        /// <summary>
        /// This will select the all text that are in the textbox.
        /// </summary>
        private void SelectAllClick(object sender, EventArgs e)
        {
            textBoxBody.SelectAll();
        }

        private void NewClick(object sender, EventArgs e)
        {

        }

        private void SaveAsClick(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Text files (*.txt)|*.txt";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                openFile = saveDialog.FileName;

                SaveFile(openFile);
            }

        }
  
        /// <summary>
        ///  This will save the file at the path indicated by the filename passed in.
        /// </summary>
        /// <param name="fileName">It's file name!</param>
        private void SaveFile(string fileName)
        {
            FileStream fileToAccess = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fileToAccess);

            writer.Write(textBoxBody.Text);

            writer.Close();

        }

        private void menuHelpAbout_Click(object sender, EventArgs e)
        {

        }
    }
}
