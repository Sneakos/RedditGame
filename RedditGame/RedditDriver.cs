using RedditGame.Properties;
using RedditSharp;
using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace RedditGame
{
    public partial class RedditDriver : Form
    {
        #region Instance Variables

        private RedditSharp.Things.Post redditPost;
        private RedditSharp.Things.Subreddit frontPage;
        private ArrayList hot;
        private WebClient wc = new WebClient();
        private int totalCorrect = 0;
        private int currPosts = 10;

        #endregion

        #region Initializors

        public RedditDriver()
        {
            InitializeComponent();

            Init();
        }

        public void Init()
        {
            try
            {
                hot = new ArrayList();
                string[] subreddits = Resources.Subreddits.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                foreach (string line in subreddits)
                {
                    cmbSubreddits.Items.Add(line);
                }
                btnSubmit.Enabled = false;
                rtbTitle.SelectAll();
                rtbTitle.SelectionAlignment = HorizontalAlignment.Center;

                Reddit reddit = new Reddit();
                frontPage = reddit.FrontPage;
                hot.AddRange(frontPage.Hot.Take(10).ToArray());

                GetNewSubreddit();
            }
            catch (WebException)
            {
                MessageBox.Show("Error: No Internet");
                Environment.Exit(1);
            }
        }

        #endregion

        #region Methods

        private void GetNewSubreddit()
        {
            if (hot.Count <= 0)
            {
                hot.AddRange(frontPage.Hot.Skip(currPosts).Take(10).ToArray());
                currPosts += 10;
            }

            redditPost = (RedditSharp.Things.Post)hot[0];
            hot.RemoveAt(0);
            rtbTitle.Text = redditPost.Title;
            rtbTitle.SelectAll();
            rtbTitle.SelectionAlignment = HorizontalAlignment.Center;
            if (redditPost.SelfText != "")
            {
                txtPost.Enabled = true;
                txtPost.Text = redditPost.SelfText;
            }
            else
            {
                txtPost.Text = "No self text";
                txtPost.Enabled = false;
            }
            lblKarma.Text = "Karma: " + redditPost.Upvotes;
            lblCommentCount.Text = "Comments: " + redditPost.CommentCount;
            Image img;
            try
            {
                img = Image.FromStream(wc.OpenRead(redditPost.Thumbnail));
            }
            catch (WebException)
            {
                img = Resources.Default;
            }
            img = ResizeImage(img, pbPostPicture.Width, pbPostPicture.Height);
            pbPostPicture.Image = img;
            lblSubredditName.Text = redditPost.SubredditName;
        }

        public Bitmap ResizeImage(Image image, int width, int height)
        {
            Rectangle destRect = new Rectangle(0, 0, width, height);
            Bitmap destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (Graphics graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (ImageAttributes wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        #endregion

        #region Events

        private void PbPostPicture_Click(object sender, EventArgs e)
        {
            string url = redditPost.Url.ToString();
            if (url.Contains("v.redd.it") || url.Contains("reddit.com"))
            {
                string msg = "Warning: This link most likely will redirect you to the subreddit itself. Continue?";
                DialogResult dialogResult = MessageBox.Show(msg, "Cheating Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(redditPost.Url.ToString());
                }
            }
            else
            {
                System.Diagnostics.Process.Start(redditPost.Url.ToString());
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            GetNewSubreddit();
            btnSubmit.Enabled = false;
            lblSubredditName.Visible = false;
            lblResult.Visible = false;
            cmbSubreddits.Enabled = true;
            btnRevealAnswer.Enabled = true;
            cmbSubreddits.Text = "";
            AcceptButton = btnSubmit;
            cmbSubreddits.Focus();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
            cmbSubreddits.Enabled = false;
            btnRevealAnswer.Enabled = false;
            AcceptButton = btnNext;
            string name = redditPost.SubredditName.ToLower();
            string answer = cmbSubreddits.Text.ToLower();
            lblSubredditName.Visible = true;
            lblResult.Visible = true;
            if (answer.Equals(name))
            {
                totalCorrect += 1;
                lblResult.Text = "Correct!";
                lblResult.BackColor = Color.LightGreen;
            }
            else
            {
                lblResult.Text = "Incorrect!";
                lblResult.BackColor = Color.Red;
            }
            lblTotalCorrect.Text = "Score: " + totalCorrect;
        }

        private void CmbSubreddits_TextChanged(object sender, EventArgs e)
        {
            if (cmbSubreddits.Text != "")
                btnSubmit.Enabled = true;
            else
                btnSubmit.Enabled = false;
        }

        private void BtnRevealAnswer_Click(object sender, EventArgs e)
        {
            lblSubredditName.Visible = true;
            cmbSubreddits.Enabled = false;
            btnSubmit.Enabled = false;
        }

        private void LblSubredditName_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://reddit.com" + redditPost.Permalink);
        }

        #endregion
    }
}