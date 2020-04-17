namespace AviationAcronmys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtAcronym = new System.Windows.Forms.TextBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.labelAcronym = new System.Windows.Forms.Label();
            this.txtMeaning = new System.Windows.Forms.TextBox();
            this.labelMeaning = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lableInfo = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtAcronym
            // 
            this.txtAcronym.BackColor = System.Drawing.SystemColors.Info;
            this.txtAcronym.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtAcronym.Location = new System.Drawing.Point(517, 40);
            this.txtAcronym.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAcronym.Name = "txtAcronym";
            this.txtAcronym.Size = new System.Drawing.Size(108, 26);
            this.txtAcronym.TabIndex = 0;
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.Lime;
            this.btnADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.Maroon;
            this.btnADD.Location = new System.Drawing.Point(638, 18);
            this.btnADD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(118, 69);
            this.btnADD.TabIndex = 1;
            this.btnADD.Text = "ADD";
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.BtnADD_Click);
            // 
            // labelAcronym
            // 
            this.labelAcronym.AutoSize = true;
            this.labelAcronym.Location = new System.Drawing.Point(517, 20);
            this.labelAcronym.Name = "labelAcronym";
            this.labelAcronym.Size = new System.Drawing.Size(63, 18);
            this.labelAcronym.TabIndex = 2;
            this.labelAcronym.Text = "Acronym";
            // 
            // txtMeaning
            // 
            this.txtMeaning.BackColor = System.Drawing.SystemColors.Info;
            this.txtMeaning.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtMeaning.Location = new System.Drawing.Point(517, 119);
            this.txtMeaning.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMeaning.Multiline = true;
            this.txtMeaning.Name = "txtMeaning";
            this.txtMeaning.Size = new System.Drawing.Size(239, 24);
            this.txtMeaning.TabIndex = 3;
            this.txtMeaning.TextChanged += new System.EventHandler(this.TxtMeaning_TextChanged);
            // 
            // labelMeaning
            // 
            this.labelMeaning.AutoSize = true;
            this.labelMeaning.Location = new System.Drawing.Point(517, 99);
            this.labelMeaning.Name = "labelMeaning";
            this.labelMeaning.Size = new System.Drawing.Size(62, 18);
            this.labelMeaning.TabIndex = 4;
            this.labelMeaning.Text = "Meaning";
            this.labelMeaning.Click += new System.EventHandler(this.LabelMeaning_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Info;
            this.txtDescription.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtDescription.Location = new System.Drawing.Point(517, 197);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(239, 189);
            this.txtDescription.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Description";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Lime;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Maroon;
            this.btnSearch.Location = new System.Drawing.Point(288, 128);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 52);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Info;
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtSearch.Location = new System.Drawing.Point(93, 132);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(143, 32);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.Text = "Type here..";
            this.txtSearch.Click += new System.EventHandler(this.Search_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // lableInfo
            // 
            this.lableInfo.AutoSize = true;
            this.lableInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lableInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableInfo.Location = new System.Drawing.Point(91, 250);
            this.lableInfo.MaximumSize = new System.Drawing.Size(349, 0);
            this.lableInfo.Name = "lableInfo";
            this.lableInfo.Size = new System.Drawing.Size(181, 18);
            this.lableInfo.TabIndex = 9;
            this.lableInfo.Text = "In order to find of acronym";
            this.lableInfo.Click += new System.EventHandler(this.Label2_Click);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(520, 409);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(63, 18);
            this.labelCategory.TabIndex = 10;
            this.labelCategory.Text = "Category";
            // 
            // comboCategory
            // 
            this.comboCategory.BackColor = System.Drawing.SystemColors.Info;
            this.comboCategory.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(517, 431);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(121, 26);
            this.comboCategory.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AviationAcronmys.Properties.Resources.IGA_001;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.lableInfo);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.labelMeaning);
            this.Controls.Add(this.txtMeaning);
            this.Controls.Add(this.labelAcronym);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.txtAcronym);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Aviation Acronym finder";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAcronym;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Label labelAcronym;
        private System.Windows.Forms.TextBox txtMeaning;
        private System.Windows.Forms.Label labelMeaning;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lableInfo;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.ComboBox comboCategory;
    }
}

