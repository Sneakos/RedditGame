namespace RedditGame
{
    partial class RedditDriver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedditDriver));
            this.pbPostPicture = new System.Windows.Forms.PictureBox();
            this.cmbSubreddits = new System.Windows.Forms.ComboBox();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.lblKarma = new System.Windows.Forms.Label();
            this.lblCommentCount = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblSubredditStart = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblSubredditName = new System.Windows.Forms.Label();
            this.lblTotalCorrect = new System.Windows.Forms.Label();
            this.btnRevealAnswer = new System.Windows.Forms.Button();
            this.rtbTitle = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPostPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPostPicture
            // 
            this.pbPostPicture.Location = new System.Drawing.Point(12, 101);
            this.pbPostPicture.Name = "pbPostPicture";
            this.pbPostPicture.Size = new System.Drawing.Size(238, 160);
            this.pbPostPicture.TabIndex = 1;
            this.pbPostPicture.TabStop = false;
            this.pbPostPicture.Click += new System.EventHandler(this.PbPostPicture_Click);
            // 
            // cmbSubreddits
            // 
            this.cmbSubreddits.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbSubreddits.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSubreddits.FormattingEnabled = true;
            this.cmbSubreddits.Location = new System.Drawing.Point(124, 274);
            this.cmbSubreddits.Name = "cmbSubreddits";
            this.cmbSubreddits.Size = new System.Drawing.Size(384, 24);
            this.cmbSubreddits.TabIndex = 2;
            this.cmbSubreddits.TextChanged += new System.EventHandler(this.CmbSubreddits_TextChanged);
            // 
            // txtPost
            // 
            this.txtPost.Location = new System.Drawing.Point(256, 101);
            this.txtPost.Multiline = true;
            this.txtPost.Name = "txtPost";
            this.txtPost.ReadOnly = true;
            this.txtPost.Size = new System.Drawing.Size(252, 160);
            this.txtPost.TabIndex = 3;
            // 
            // lblKarma
            // 
            this.lblKarma.AutoSize = true;
            this.lblKarma.Location = new System.Drawing.Point(514, 244);
            this.lblKarma.Name = "lblKarma";
            this.lblKarma.Size = new System.Drawing.Size(49, 17);
            this.lblKarma.TabIndex = 4;
            this.lblKarma.Text = "Karma";
            // 
            // lblCommentCount
            // 
            this.lblCommentCount.AutoSize = true;
            this.lblCommentCount.Location = new System.Drawing.Point(514, 207);
            this.lblCommentCount.Name = "lblCommentCount";
            this.lblCommentCount.Size = new System.Drawing.Size(74, 17);
            this.lblCommentCount.TabIndex = 5;
            this.lblCommentCount.Text = "Comments";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(121, 303);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(387, 31);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Sumbit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(517, 303);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(126, 25);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // lblSubredditStart
            // 
            this.lblSubredditStart.AutoSize = true;
            this.lblSubredditStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubredditStart.Location = new System.Drawing.Point(8, 278);
            this.lblSubredditStart.Name = "lblSubredditStart";
            this.lblSubredditStart.Size = new System.Drawing.Size(103, 20);
            this.lblSubredditStart.TabIndex = 9;
            this.lblSubredditStart.Text = "reddit.com\\r\\";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(514, 101);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(85, 29);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "Result";
            this.lblResult.Visible = false;
            // 
            // lblSubredditName
            // 
            this.lblSubredditName.AutoSize = true;
            this.lblSubredditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubredditName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSubredditName.Location = new System.Drawing.Point(513, 176);
            this.lblSubredditName.Name = "lblSubredditName";
            this.lblSubredditName.Size = new System.Drawing.Size(129, 20);
            this.lblSubredditName.TabIndex = 11;
            this.lblSubredditName.Text = "Subreddit Name";
            this.lblSubredditName.Visible = false;
            this.lblSubredditName.Click += new System.EventHandler(this.LblSubredditName_Click);
            // 
            // lblTotalCorrect
            // 
            this.lblTotalCorrect.AutoSize = true;
            this.lblTotalCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCorrect.Location = new System.Drawing.Point(12, 341);
            this.lblTotalCorrect.Name = "lblTotalCorrect";
            this.lblTotalCorrect.Size = new System.Drawing.Size(72, 20);
            this.lblTotalCorrect.TabIndex = 12;
            this.lblTotalCorrect.Text = "Score: 0";
            // 
            // btnRevealAnswer
            // 
            this.btnRevealAnswer.Location = new System.Drawing.Point(517, 277);
            this.btnRevealAnswer.Name = "btnRevealAnswer";
            this.btnRevealAnswer.Size = new System.Drawing.Size(126, 25);
            this.btnRevealAnswer.TabIndex = 13;
            this.btnRevealAnswer.Text = "Reveal";
            this.btnRevealAnswer.UseVisualStyleBackColor = true;
            this.btnRevealAnswer.Click += new System.EventHandler(this.BtnRevealAnswer_Click);
            // 
            // rtbTitle
            // 
            this.rtbTitle.BackColor = System.Drawing.SystemColors.Control;
            this.rtbTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbTitle.Location = new System.Drawing.Point(12, 12);
            this.rtbTitle.Name = "rtbTitle";
            this.rtbTitle.Size = new System.Drawing.Size(522, 83);
            this.rtbTitle.TabIndex = 14;
            this.rtbTitle.Text = "Title";
            // 
            // RedditDriver
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 370);
            this.Controls.Add(this.rtbTitle);
            this.Controls.Add(this.btnRevealAnswer);
            this.Controls.Add(this.lblTotalCorrect);
            this.Controls.Add(this.lblSubredditName);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSubredditStart);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblCommentCount);
            this.Controls.Add(this.lblKarma);
            this.Controls.Add(this.txtPost);
            this.Controls.Add(this.cmbSubreddits);
            this.Controls.Add(this.pbPostPicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RedditDriver";
            this.Text = "Reddit Game";
            ((System.ComponentModel.ISupportInitialize)(this.pbPostPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbPostPicture;
        private System.Windows.Forms.ComboBox cmbSubreddits;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.Label lblKarma;
        private System.Windows.Forms.Label lblCommentCount;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblSubredditStart;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblSubredditName;
        private System.Windows.Forms.Label lblTotalCorrect;
        private System.Windows.Forms.Button btnRevealAnswer;
        private System.Windows.Forms.RichTextBox rtbTitle;
    }
}

