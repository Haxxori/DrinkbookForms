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
using System.Diagnostics;

namespace Book
{
    public partial class Form1 : Form
    {


            public Form1()
            {
                InitializeComponent();
                foreach (var line in File.ReadAllLines("D:\\recipes.txt"))
                {
                    Debug.WriteLine("line = " + line);
                    RecipesListBox.Items.Add(line);
                }
            }

            private void NewRecipeB_Click(object sender, EventArgs e)
            {
                RecipeNameBox.Visible = true;
                RecipeTypeBox.Visible = true;
                RecipeIngredientBox.Visible = true;
                SaveRecipeB.Visible = true;
                RecipeMixBox.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
            }

            private void RecipeNameBox_TextChanged(object sender, EventArgs e)
            {

            }

            private void RecipeTypeBox_TextChanged(object sender, EventArgs e)
            {

            }

            private void RecipeIngredientBox_TextChanged(object sender, EventArgs e)
            {

            }

            public void SaveRecipeB_Click(object sender, EventArgs e)
            {
                using (System.IO.StreamWriter objWriter = new StreamWriter("D:\\recipes.txt", true))
                {

                    objWriter.Write(RecipeNameBox.Text + "|");
                    objWriter.Write(RecipeTypeBox.Text + "|");
                    objWriter.Write(RecipeIngredientBox.Text + "|");
                    objWriter.Write(RecipeMixBox.Text + "\n");
                    objWriter.WriteLine();

                    objWriter.Close();

                    MessageBox.Show("Uusi resepti on tallennettu.");

                Drinks d = new Drinks();
                }
            }

            private void RecipesListBox_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void label3_Click(object sender, EventArgs e)
            {

            }

            private void RecipeMixBox_TextChanged(object sender, EventArgs e)
            {

            }
        
    }
}
