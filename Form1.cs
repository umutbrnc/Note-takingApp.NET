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

namespace Intern_task_DT
{
    public partial class myForm : Form
    {
        public myForm()
        {
            InitializeComponent();
        }
    
        private string clipboard;

        Stack<string> undoStack = new Stack<string>();
        Stack<string> redoStack = new Stack<string>();

        bool boldflag = false;
        bool italicflag = false;
        bool underlineflag = false;


        //---------------------------------------------------------------------------------------------------- FILE 


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text Document (*.txt)|*.txt";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        txtMain.Text = File.ReadAllText(ofd.FileName);
                        MessageBox.Show("File opened successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while opening the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text Document (*.txt)|*.txt";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(sfd.FileName, txtMain.Text);
                        MessageBox.Show("File saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while saving the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNo);

            switch (result)
            {
                case DialogResult.Yes://save
                    saveToolStripMenuItem_Click(sender, e);
                    break;
                case DialogResult.No://don't save
                    break;
            }

            this.Close();
        }



        //---------------------------------------------------------------------------------------------------- EDIT


        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undoStack.Push(txtMain.Text);
            clipboard =txtMain.SelectedText;
            txtMain.SelectedText="";
            
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undoStack.Push(txtMain.Text);
            clipboard = txtMain.SelectedText;
            
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undoStack.Push(txtMain.Text);
            txtMain.SelectedText = clipboard;
            
        }


        private void selectallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undoStack.Push(txtMain.Text);
            txtMain.SelectAll();
           
        }


        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 0)
            {
                redoStack.Push(txtMain.Text); 
                txtMain.Text = undoStack.Pop(); 





                //---------------------------------button controls
                
                
                //bold
                if (txtMain.Font.Bold == true)
                {
                    btnBold.BackColor = Color.Pink;
                    boldflag = true;
                }
                else if (txtMain.Font.Bold == false)
                {
                    btnBold.BackColor = Color.Lavender;
                    boldflag = false;

                }

                //italic
                if (txtMain.Font.Italic == true)
                {
                    btnItalic.BackColor = Color.Pink;
                    italicflag = true;
                }
                else if (!txtMain.Font.Italic)
                {
                    btnItalic.BackColor = Color.Lavender;
                    italicflag = false;

                }

                //underline
                if (txtMain.Font.Underline == true)
                {
                    btnUnderline.BackColor = Color.Pink;
                    underlineflag = true;
                }
                else if (!txtMain.Font.Underline)
                {
                    btnUnderline.BackColor = Color.Lavender;
                    underlineflag = false;

                }


            }



        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (redoStack.Count > 0)
            {
                undoStack.Push(txtMain.Text); 
                txtMain.Text = redoStack.Pop(); 
            }
        }


        //---------------------------------------------------------------------------------------------------- FORMAT

       

        private void btnBold_Click(object sender, EventArgs e)
        {

            if (boldflag == false)
            {
                undoStack.Push(txtMain.Text);
                txtMain.SelectionFont = new Font(txtMain.Font, FontStyle.Bold);
                boldflag = true;
                btnBold.BackColor = Color.Pink;
            }
            else
            {
                undoStack.Push(txtMain.Text);
                txtMain.SelectionFont = new Font(txtMain.Font, FontStyle.Regular);
                boldflag = false;
                btnBold.BackColor = Color.Lavender;
            }

        }
        private void btnItalic_Click(object sender, EventArgs e)
        {

            if (italicflag == false)
            {
                undoStack.Push(txtMain.Text);
                txtMain.SelectionFont = new Font(txtMain.Font, FontStyle.Italic);
                italicflag = true;
                btnItalic.BackColor = Color.Pink;
            }
            else
            {
                undoStack.Push(txtMain.Text);
                txtMain.SelectionFont = new Font(txtMain.Font, FontStyle.Regular);
                italicflag = false;
                btnItalic.BackColor = Color.Lavender;
            }
           
        }



        private void btnUnderline_Click(object sender, EventArgs e)
        {
            if (underlineflag == false)
            {
                undoStack.Push(txtMain.Text);
                txtMain.SelectionFont = new Font(txtMain.Font, FontStyle.Underline);
                underlineflag = true;
                btnUnderline.BackColor = Color.Pink;
            }
            else
            {
                undoStack.Push(txtMain.Text);
                txtMain.SelectionFont = new Font(txtMain.Font, FontStyle.Regular);
                underlineflag = false;
                btnUnderline.BackColor = Color.Lavender;
            }
           
        }

      


        ColorSelector cs = new ColorSelector();

        private void btnColor_Click(object sender, EventArgs e)
        {

            ColorSelector Colors = new ColorSelector();
            Colors.ShowDialog();

            try
            {

                int r = Convert.ToInt32(Colors.Redd);
                int g = Convert.ToInt32(Colors.Greenn);
                int b = Convert.ToInt32(Colors.Bluee);
                Color myColor = Color.FromArgb(r,g,b);
                txtMain.ForeColor = myColor;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        //---------------------------------------------------------------------------------------------------- SEARCH


        private void toolStripTextBox_Click(object sender, EventArgs e)
        {
            toolStripTextBox.Text="";
        }
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string wordToSearch = toolStripTextBox.Text.Trim();

            txtMain.SelectAll();
            txtMain.SelectionBackColor = Color.White;

            if (wordToSearch != string.Empty)
            {
                int startIndex = 0;
                while (startIndex < txtMain.TextLength)
                {
                    int wordStartIndex = txtMain.Find(wordToSearch, startIndex, RichTextBoxFinds.None);
                    if (wordStartIndex != -1)
                    {
                        txtMain.SelectionStart = wordStartIndex;
                        txtMain.SelectionLength = wordToSearch.Length;
                        txtMain.SelectionBackColor = Color.Orchid;
                    }
                    else
                        break;
                    startIndex = wordStartIndex + wordToSearch.Length;
                }
            }




        }



        //---------------------------------------------------------------------------------------------------- CLEAR

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undoStack.Push(txtMain.Text);
            txtMain.Clear();
        }

      
    }
}
