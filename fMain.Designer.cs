namespace MultiChoice
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lbType = new System.Windows.Forms.Label();
            this.lbRemember = new System.Windows.Forms.Label();
            this.cbRemember = new System.Windows.Forms.ComboBox();
            this.rtbQuestion = new System.Windows.Forms.RichTextBox();
            this.lbLevel = new System.Windows.Forms.Label();
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.rtbAnswer = new System.Windows.Forms.RichTextBox();
            this.tmStart = new System.Windows.Forms.Timer(this.components);
            this.lbAnswer = new System.Windows.Forms.Label();
            this.cbAnswer = new System.Windows.Forms.ComboBox();
            this.lbQuestion = new System.Windows.Forms.Label();
            this.lbDatabase = new System.Windows.Forms.Label();
            this.cbQuestion = new System.Windows.Forms.ComboBox();
            this.cbDatabase = new System.Windows.Forms.ComboBox();
            this.Sheet = new System.Windows.Forms.Label();
            this.cbSheet = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbType
            // 
            this.cbType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.ForeColor = System.Drawing.Color.Black;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Multichoice",
            "Hint",
            "Scramble"});
            this.cbType.Location = new System.Drawing.Point(608, 5);
            this.cbType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(297, 35);
            this.cbType.TabIndex = 103;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.ForeColor = System.Drawing.Color.Blue;
            this.lbType.Location = new System.Drawing.Point(536, 9);
            this.lbType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(59, 27);
            this.lbType.TabIndex = 105;
            this.lbType.Text = "Type";
            // 
            // lbRemember
            // 
            this.lbRemember.AutoSize = true;
            this.lbRemember.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRemember.ForeColor = System.Drawing.Color.Blue;
            this.lbRemember.Location = new System.Drawing.Point(536, 55);
            this.lbRemember.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRemember.Name = "lbRemember";
            this.lbRemember.Size = new System.Drawing.Size(117, 27);
            this.lbRemember.TabIndex = 107;
            this.lbRemember.Text = "Remember";
            // 
            // cbRemember
            // 
            this.cbRemember.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbRemember.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbRemember.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRemember.ForeColor = System.Drawing.Color.Black;
            this.cbRemember.FormattingEnabled = true;
            this.cbRemember.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbRemember.Location = new System.Drawing.Point(665, 48);
            this.cbRemember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRemember.Name = "cbRemember";
            this.cbRemember.Size = new System.Drawing.Size(69, 35);
            this.cbRemember.TabIndex = 106;
            this.cbRemember.SelectedIndexChanged += new System.EventHandler(this.cbRemember_SelectedIndexChanged);
            // 
            // rtbQuestion
            // 
            this.rtbQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbQuestion.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbQuestion.ForeColor = System.Drawing.Color.Blue;
            this.rtbQuestion.Location = new System.Drawing.Point(3, 95);
            this.rtbQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbQuestion.Name = "rtbQuestion";
            this.rtbQuestion.Size = new System.Drawing.Size(903, 282);
            this.rtbQuestion.TabIndex = 108;
            this.rtbQuestion.Text = "";
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLevel.ForeColor = System.Drawing.Color.Blue;
            this.lbLevel.Location = new System.Drawing.Point(744, 52);
            this.lbLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(67, 27);
            this.lbLevel.TabIndex = 110;
            this.lbLevel.Text = "Level";
            // 
            // cbLevel
            // 
            this.cbLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbLevel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLevel.ForeColor = System.Drawing.Color.Black;
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            "10",
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800",
            "900",
            "1000",
            "2000",
            "3000",
            "4000",
            "5000",
            "10000"});
            this.cbLevel.Location = new System.Drawing.Point(819, 48);
            this.cbLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(87, 35);
            this.cbLevel.TabIndex = 109;
            this.cbLevel.SelectedIndexChanged += new System.EventHandler(this.cbLevel_SelectedIndexChanged);
            // 
            // rtbAnswer
            // 
            this.rtbAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbAnswer.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAnswer.ForeColor = System.Drawing.Color.Green;
            this.rtbAnswer.Location = new System.Drawing.Point(3, 385);
            this.rtbAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbAnswer.Name = "rtbAnswer";
            this.rtbAnswer.Size = new System.Drawing.Size(903, 51);
            this.rtbAnswer.TabIndex = 111;
            this.rtbAnswer.Text = "";
            this.rtbAnswer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtbAnswer_KeyUp);
            // 
            // tmStart
            // 
            this.tmStart.Interval = 3000;
            this.tmStart.Tick += new System.EventHandler(this.tmStart_Tick);
            // 
            // lbAnswer
            // 
            this.lbAnswer.AutoSize = true;
            this.lbAnswer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnswer.ForeColor = System.Drawing.Color.Blue;
            this.lbAnswer.Location = new System.Drawing.Point(277, 55);
            this.lbAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAnswer.Name = "lbAnswer";
            this.lbAnswer.Size = new System.Drawing.Size(86, 27);
            this.lbAnswer.TabIndex = 117;
            this.lbAnswer.Text = "Answer";
            // 
            // cbAnswer
            // 
            this.cbAnswer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAnswer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAnswer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAnswer.ForeColor = System.Drawing.Color.Black;
            this.cbAnswer.FormattingEnabled = true;
            this.cbAnswer.Location = new System.Drawing.Point(375, 52);
            this.cbAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAnswer.Name = "cbAnswer";
            this.cbAnswer.Size = new System.Drawing.Size(152, 35);
            this.cbAnswer.TabIndex = 116;
            this.cbAnswer.SelectedIndexChanged += new System.EventHandler(this.cbAnswer_SelectedIndexChanged);
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestion.ForeColor = System.Drawing.Color.Blue;
            this.lbQuestion.Location = new System.Drawing.Point(5, 58);
            this.lbQuestion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(98, 27);
            this.lbQuestion.TabIndex = 115;
            this.lbQuestion.Text = "Question";
            // 
            // lbDatabase
            // 
            this.lbDatabase.AutoSize = true;
            this.lbDatabase.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatabase.ForeColor = System.Drawing.Color.Blue;
            this.lbDatabase.Location = new System.Drawing.Point(4, 9);
            this.lbDatabase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDatabase.Name = "lbDatabase";
            this.lbDatabase.Size = new System.Drawing.Size(101, 27);
            this.lbDatabase.TabIndex = 114;
            this.lbDatabase.Text = "Database";
            // 
            // cbQuestion
            // 
            this.cbQuestion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbQuestion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbQuestion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbQuestion.ForeColor = System.Drawing.Color.Black;
            this.cbQuestion.FormattingEnabled = true;
            this.cbQuestion.Location = new System.Drawing.Point(116, 52);
            this.cbQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbQuestion.Name = "cbQuestion";
            this.cbQuestion.Size = new System.Drawing.Size(152, 35);
            this.cbQuestion.TabIndex = 113;
            this.cbQuestion.SelectedIndexChanged += new System.EventHandler(this.cbQuestion_SelectedIndexChanged);
            // 
            // cbDatabase
            // 
            this.cbDatabase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbDatabase.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbDatabase.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDatabase.ForeColor = System.Drawing.Color.Black;
            this.cbDatabase.FormattingEnabled = true;
            this.cbDatabase.Location = new System.Drawing.Point(116, 5);
            this.cbDatabase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbDatabase.Name = "cbDatabase";
            this.cbDatabase.Size = new System.Drawing.Size(152, 35);
            this.cbDatabase.TabIndex = 112;
            this.cbDatabase.SelectedIndexChanged += new System.EventHandler(this.cbDatabase_SelectedIndexChanged);
            // 
            // Sheet
            // 
            this.Sheet.AutoSize = true;
            this.Sheet.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sheet.ForeColor = System.Drawing.Color.Blue;
            this.Sheet.Location = new System.Drawing.Point(277, 11);
            this.Sheet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sheet.Name = "Sheet";
            this.Sheet.Size = new System.Drawing.Size(65, 27);
            this.Sheet.TabIndex = 119;
            this.Sheet.Text = "Sheet";
            // 
            // cbSheet
            // 
            this.cbSheet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSheet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSheet.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSheet.ForeColor = System.Drawing.Color.Black;
            this.cbSheet.FormattingEnabled = true;
            this.cbSheet.Location = new System.Drawing.Point(375, 5);
            this.cbSheet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSheet.Name = "cbSheet";
            this.cbSheet.Size = new System.Drawing.Size(152, 35);
            this.cbSheet.TabIndex = 118;
            this.cbSheet.SelectedIndexChanged += new System.EventHandler(this.cbSheet_SelectedIndexChanged);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 437);
            this.Controls.Add(this.Sheet);
            this.Controls.Add(this.cbSheet);
            this.Controls.Add(this.lbAnswer);
            this.Controls.Add(this.cbAnswer);
            this.Controls.Add(this.lbQuestion);
            this.Controls.Add(this.lbDatabase);
            this.Controls.Add(this.cbQuestion);
            this.Controls.Add(this.cbDatabase);
            this.Controls.Add(this.rtbAnswer);
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.cbLevel);
            this.Controls.Add(this.lbRemember);
            this.Controls.Add(this.cbRemember);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.rtbQuestion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Progress";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbRemember;
        private System.Windows.Forms.ComboBox cbRemember;
        private System.Windows.Forms.RichTextBox rtbQuestion;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.ComboBox cbLevel;
        private System.Windows.Forms.RichTextBox rtbAnswer;
        private System.Windows.Forms.Timer tmStart;
        private System.Windows.Forms.Label lbAnswer;
        private System.Windows.Forms.ComboBox cbAnswer;
        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.Label lbDatabase;
        private System.Windows.Forms.ComboBox cbQuestion;
        private System.Windows.Forms.ComboBox cbDatabase;
        private System.Windows.Forms.Label Sheet;
        private System.Windows.Forms.ComboBox cbSheet;
    }
}

