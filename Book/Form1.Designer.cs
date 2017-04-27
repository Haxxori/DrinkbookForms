namespace Book
{
    partial class Form1
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
            this.NewRecipeB = new System.Windows.Forms.Button();
            this.RecipeNameBox = new System.Windows.Forms.TextBox();
            this.RecipeTypeBox = new System.Windows.Forms.TextBox();
            this.RecipeIngredientBox = new System.Windows.Forms.RichTextBox();
            this.SaveRecipeB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RecipesListBox = new System.Windows.Forms.ListBox();
            this.RecipeMixBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewRecipeB
            // 
            this.NewRecipeB.Location = new System.Drawing.Point(38, 39);
            this.NewRecipeB.Name = "NewRecipeB";
            this.NewRecipeB.Size = new System.Drawing.Size(75, 23);
            this.NewRecipeB.TabIndex = 0;
            this.NewRecipeB.Text = "Uusi resepti";
            this.NewRecipeB.UseVisualStyleBackColor = true;
            this.NewRecipeB.Click += new System.EventHandler(this.NewRecipeB_Click);
            // 
            // RecipeNameBox
            // 
            this.RecipeNameBox.Location = new System.Drawing.Point(310, 25);
            this.RecipeNameBox.Name = "RecipeNameBox";
            this.RecipeNameBox.Size = new System.Drawing.Size(170, 20);
            this.RecipeNameBox.TabIndex = 1;
            this.RecipeNameBox.Visible = false;
            this.RecipeNameBox.TextChanged += new System.EventHandler(this.RecipeNameBox_TextChanged);
            // 
            // RecipeTypeBox
            // 
            this.RecipeTypeBox.Location = new System.Drawing.Point(309, 51);
            this.RecipeTypeBox.Name = "RecipeTypeBox";
            this.RecipeTypeBox.Size = new System.Drawing.Size(170, 20);
            this.RecipeTypeBox.TabIndex = 2;
            this.RecipeTypeBox.Visible = false;
            this.RecipeTypeBox.TextChanged += new System.EventHandler(this.RecipeTypeBox_TextChanged);
            // 
            // RecipeIngredientBox
            // 
            this.RecipeIngredientBox.Location = new System.Drawing.Point(309, 77);
            this.RecipeIngredientBox.Name = "RecipeIngredientBox";
            this.RecipeIngredientBox.Size = new System.Drawing.Size(169, 121);
            this.RecipeIngredientBox.TabIndex = 3;
            this.RecipeIngredientBox.Text = "";
            this.RecipeIngredientBox.Visible = false;
            this.RecipeIngredientBox.TextChanged += new System.EventHandler(this.RecipeIngredientBox_TextChanged);
            // 
            // SaveRecipeB
            // 
            this.SaveRecipeB.Location = new System.Drawing.Point(310, 326);
            this.SaveRecipeB.Name = "SaveRecipeB";
            this.SaveRecipeB.Size = new System.Drawing.Size(75, 23);
            this.SaveRecipeB.TabIndex = 4;
            this.SaveRecipeB.Text = "Tallenna";
            this.SaveRecipeB.UseVisualStyleBackColor = true;
            this.SaveRecipeB.Visible = false;
            this.SaveRecipeB.Click += new System.EventHandler(this.SaveRecipeB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(229, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Reseptin nimi:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Reseptin tyyppi:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Raaka-aineet:";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // RecipesListBox
            // 
            this.RecipesListBox.FormattingEnabled = true;
            this.RecipesListBox.Location = new System.Drawing.Point(38, 78);
            this.RecipesListBox.Name = "RecipesListBox";
            this.RecipesListBox.Size = new System.Drawing.Size(120, 95);
            this.RecipesListBox.TabIndex = 8;
            this.RecipesListBox.SelectedIndexChanged += new System.EventHandler(this.RecipesListBox_SelectedIndexChanged);
            // 
            // RecipeMixBox
            // 
            this.RecipeMixBox.Location = new System.Drawing.Point(309, 204);
            this.RecipeMixBox.Name = "RecipeMixBox";
            this.RecipeMixBox.Size = new System.Drawing.Size(169, 116);
            this.RecipeMixBox.TabIndex = 9;
            this.RecipeMixBox.Text = "";
            this.RecipeMixBox.Visible = false;
            this.RecipeMixBox.TextChanged += new System.EventHandler(this.RecipeMixBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Valmistusohje:";
            this.label4.Visible = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(516, 373);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RecipeMixBox);
            this.Controls.Add(this.RecipesListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SaveRecipeB);
            this.Controls.Add(this.RecipeIngredientBox);
            this.Controls.Add(this.RecipeTypeBox);
            this.Controls.Add(this.RecipeNameBox);
            this.Controls.Add(this.NewRecipeB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button NewRecipeB;
        private System.Windows.Forms.TextBox RecipeNameBox;
        private System.Windows.Forms.TextBox RecipeTypeBox;
        private System.Windows.Forms.RichTextBox RecipeIngredientBox;
        private System.Windows.Forms.Button SaveRecipeB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox RecipesListBox;
        private System.Windows.Forms.RichTextBox RecipeMixBox;
        private System.Windows.Forms.Label label4;
    }
}

