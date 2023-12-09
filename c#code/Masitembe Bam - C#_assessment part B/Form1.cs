using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcatinateApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        ArrayList Words = new ArrayList();
        ArrayList newWords = new ArrayList();
        

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            string word = this.txtWord.Text.ToLower();
            if (!String.IsNullOrEmpty(word))
            {
                if (Words.Contains(word))
                {
                    MessageBox.Show("Word already exists! \n Please try again.","instruction");
                    resetSelections();
                }
                else
                {
                    MessageBox.Show("Congratulations you added a new word to your list", "Message");

                    Words.Add(word);
                    cB1stWord.Items.Add(word);
                    cB2ndWord.Items.Add(word);
                    
                    resetSelections();
                    txtWord.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid word", "instruction");
            }

        }

        private void btnConcatenate_Click(object sender, EventArgs e)
        {
            
            if(rBremoveCB1.Checked || rBremoveCB2.Checked)
            {
                removeItem();
                resetSelections();
                btnConcatenate.Focus();
            }
            else
            {
                ConcatenateWordsCombo();
                resetSelections();
                btnConcatenate.Focus();

            }
        }

        private void removeItem()
        {
           
                if (String.IsNullOrEmpty(cB1stWord.Text) && rBremoveCB1.Checked)
                {
                    MessageBox.Show("Please select an item to remove ", "instruction");
                }
                else if (String.IsNullOrEmpty(cB2ndWord.Text) && rBremoveCB2.Checked)
                {
                    MessageBox.Show("Please select an item to remove ", "instruction");
                }
                else if (!(String.IsNullOrEmpty(cB1stWord.Text)) && rBremoveCB1.Checked)
                {
                    cB1stWord.Items.Remove(cB1stWord.SelectedItem.ToString());
                    MessageBox.Show("Item has been removed", "Message");
                }
                else if (!(String.IsNullOrEmpty(cB2ndWord.Text)) && rBremoveCB2.Checked)
                {
                    cB2ndWord.Items.Remove(cB2ndWord.SelectedItem.ToString());
                    MessageBox.Show("Item has been removed","Message");
                }
               
        }
   
        private void resetSelections()
        {
            txtWord.Clear();

            rBremoveCB1.Checked = false;
            rBremoveCB2.Checked = false;

            cB1stWord.SelectedIndex = -1;
            cB2ndWord.SelectedIndex = -1;
        }

        private void ConcatenateWordsCombo()
        {
            
            if (String.IsNullOrEmpty(cB1stWord.Text) || String.IsNullOrEmpty(cB2ndWord.Text))
            {
                MessageBox.Show("Please select items to be concatenated from both boxes", "instruction");
            }
            else if (cB1stWord.SelectedItem.ToString().Equals(cB2ndWord.SelectedItem.ToString()))
            {
                MessageBox.Show("Please select different options", "instruction");
            }
            else
            {
               lblConcatenated_word.Text = cB1stWord.SelectedItem.ToString() + cB2ndWord.SelectedItem.ToString();

                newWords.Add(lblConcatenated_word.Text);
            }
        }

        private void rBremoveCB1_CheckedChanged(object sender, EventArgs e)
        {
            if (rBremoveCB1.Checked)
            {
                btnConcatenate.Text = "Remove item";
            }
            else
            {
                btnConcatenate.Text = "Concatenate";
            }
        }

        private void rBremoveCB2_CheckedChanged(object sender, EventArgs e)
        {
            if (rBremoveCB2.Checked)
            {
                btnConcatenate.Text = "Remove item";
            }
            else
            {
                btnConcatenate.Text = "Concatenate";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
