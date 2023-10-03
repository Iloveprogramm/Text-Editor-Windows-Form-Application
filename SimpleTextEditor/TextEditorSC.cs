using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTextEditor
{
    public partial class TextEditorSC : Form
    {
        private User currentUser;
        private string currentFile = string.Empty;
        public TextEditorSC(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            UserTypetoolStripLabel.Text = "Username: " + currentUser.UserName + " - " + currentUser.UserType; //display the user type and username
            if (currentUser.UserType == "View") //when user is view type, disable some function
            {
                newToolStripMenuItem.Enabled = false; 
                saveToolStripMenuItem.Enabled = false;
                saveAsToolStripMenuItem.Enabled = false;
                editToolStripMenuItem.Enabled = false;
                toolStrip2.Enabled = false;
                toolStrip1.Enabled = false;
                richTextBox.ReadOnly = true;
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)//Logout method
        {
            LoginSC Lo = new LoginSC();
            Lo.Show();//show the login interface
            this.Hide();//close the current interface
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About Ab = new About();
            Ab.Show();
        }

        private void NewButtonToolStrip_Click(object sender, EventArgs e)//New method
        {
            DialogResult Result = MessageBox.Show("Do you want to create a new file?\n this will changed the unsaved work", "TextEditor - New File", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Result == DialogResult.Yes)
            {
                richTextBox.Text = string.Empty; 
                currentFile = string.Empty;
            }
        }

        private void OpenButtonToolStrip_Click(object sender, EventArgs e)//Open method
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog(); //File Dialog to Open File
            openFileDialog1.Title = "Open";
            openFileDialog1.Filter = "Rich Text Format files (*.rtf)|*.rtf|" +
                "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK && openFileDialog1.FileName.Length > 0)
            {
                currentFile = openFileDialog1.FileName; 
                MessageBox.Show("The File Open was:" + currentFile, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); //display which file is open
                richTextBox.Text = File.ReadAllText(this.currentFile);//using readalltext method to display the file
            }
        }

        private void SaveButtonToolStrip_Click(object sender, EventArgs e)//Save method
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save";
            if (currentFile == string.Empty) 
            {
                saveFile.Filter = "Rich Text Format file (*.rtf)|*.rtf|" + "Text file(*.txt) | *.txt";//only allow save as rtf format
                DialogResult dr = saveFile.ShowDialog();
                if (dr == DialogResult.OK && saveFile.FileName.Length > 0)
                {
                    currentFile = saveFile.FileName;
                    MessageBox.Show("The File Saved was:" + currentFile, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    richTextBox.SaveFile(currentFile, RichTextBoxStreamType.PlainText);
                }
            }
            else if(currentFile != string.Empty)
            {
                richTextBox.SaveFile(currentFile, RichTextBoxStreamType.PlainText);
            }
        }

        private void SaveAsToolStrip_Click(object sender, EventArgs e)//Save as method
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save As";
            saveFile.Filter = "Rich Text Format file (*.rtf)|*.rtf|" + "Text file(*.txt) | *.txt"; //only allow save as rtf format
            DialogResult dr = saveFile.ShowDialog();
            if (dr == DialogResult.OK && saveFile.FileName.Length > 0)
            {
                currentFile = saveFile.FileName;
                MessageBox.Show("The File Saved was:" + currentFile, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox.SaveFile(this.currentFile, RichTextBoxStreamType.PlainText);
            }
        }

        private void BoldButtonToolStrip_Click(object sender, EventArgs e)//Bold method
        {
            string fontName = richTextBox.SelectionFont.Name;
            float fontSize = richTextBox.SelectionFont.Size;
            FontStyle CurrentFontStyle = richTextBox.SelectionFont.Style ^ FontStyle.Bold;
            if (fontName != null)
            {
                richTextBox.SelectionFont = new Font(fontName, fontSize, CurrentFontStyle);
            }
         
        }

        private void ItalicsToolStrip_Click(object sender, EventArgs e)//Italic method
        {

            string fontName = richTextBox.SelectionFont.Name;
            float fontSize = richTextBox.SelectionFont.Size;
            FontStyle CurrentFontStyle = richTextBox.SelectionFont.Style ^ FontStyle.Italic;
            if (fontName != null)
            { 
                richTextBox.SelectionFont = new Font(fontName, fontSize, CurrentFontStyle);
            }
           
        }

        private void UnderLineToolStrip_Click(object sender, EventArgs e)//UnderLine method
        {
            string fontName = richTextBox.SelectionFont.Name;
            float fontSize = richTextBox.SelectionFont.Size;
            FontStyle CurrentFontStyle = richTextBox.SelectionFont.Style ^ FontStyle.Underline;
            if (fontName != null)
            {
                richTextBox.SelectionFont = new Font(fontName, fontSize, CurrentFontStyle);
            }
        }

       
        private void FontSize_SelectedIndexChanged(object sender, EventArgs e)//Change the Font size method
        {
            Font currentFont = richTextBox.SelectionFont; //get current font
            FontStyle fontStyle = richTextBox.SelectionFont.Style; // get fontstyle
            int fontSize = Int32.Parse(FontSize.ComboBox.SelectedIndex.ToString().Replace("pt", "")) + 8; // declare varible to store font size
            richTextBox.SelectionFont = new Font(currentFont.FontFamily, fontSize, fontStyle);//pass all to the new font arguement
        }

        private void AboutStripButton_Click(object sender, EventArgs e)
        {
            About Ab = new About();
            Ab.Show(); //show the about interface
        }

        private void CutbuttonToolStrip_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionLength > 0)
            {
                richTextBox.Cut();//cut the text in the richTextBox
            }
        }

        private void CopyButtonToolStrip_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectionLength > 0)
            {
                richTextBox.Copy();//copy the text in the richTextBox
            }
        }

        private void PastebuttonToolStrip_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Rtf))//if the clipboard contains the text
            {
                richTextBox.Paste();//, then paste the text into richtext box
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Do you want to create a new file?\n this will changed the unsaved work", "TextEditor - New File", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Result == DialogResult.Yes)//if yes
            {
                richTextBox.Text = string.Empty; //clean the text in richtextbox
                currentFile = string.Empty;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) //Open MenuItem
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog(); 
            openFileDialog1.Title = "Open";
            openFileDialog1.Filter = "Rich Text Format file (*.rtf)|*.rtf|" +
                "Text file (*.txt)|*.txt|All file (*.*)|*.*";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK && openFileDialog1.FileName.Length > 0)
            {
                currentFile = openFileDialog1.FileName;
                MessageBox.Show("The File Open was:" + currentFile, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox.Text = File.ReadAllText(this.currentFile);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) //Save MenuItem
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save";
            if (currentFile == string.Empty)
            {
                saveFile.Filter = "Rich Text Format file (*.rtf)|*.rtf|" + "Text file(*.txt) | *.txt";//only allow save as rtf format
                DialogResult dr = saveFile.ShowDialog();
                if (dr == DialogResult.OK && saveFile.FileName.Length > 0)
                {
                    currentFile = saveFile.FileName;
                    MessageBox.Show("The File Saved was:" + currentFile, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    richTextBox.SaveFile(currentFile, RichTextBoxStreamType.PlainText);
                }
            }
            else if (currentFile != string.Empty)
            {
                richTextBox.SaveFile(currentFile, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) //SaveAs MenuItem
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save As";
            saveFile.Filter = "Rich Text Format file (*.rtf)|*.rtf|" + "Text file(*.txt) | *.txt"; 
            DialogResult dr = saveFile.ShowDialog();
            if (dr == DialogResult.OK && saveFile.FileName.Length > 0)
            {
                currentFile = saveFile.FileName;
                MessageBox.Show("The File Saved was:" + currentFile, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox.SaveFile(this.currentFile, RichTextBoxStreamType.PlainText);
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e) //Cut menuItem
        {
            if (richTextBox.SelectionLength > 0)
            {
                richTextBox.Cut();//cut the text in the richTextBox
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)//Copy MenuItem
        {
            if (richTextBox.SelectionLength > 0)
            {
                richTextBox.Copy();//copy the text in the richTextBox
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)//Paste MenuItem
        {
            if (Clipboard.ContainsText(TextDataFormat.Rtf))//if the clipboard contains the text
            {
                richTextBox.Paste();//, then paste the text into richtext box
            }
        }
    }
}
