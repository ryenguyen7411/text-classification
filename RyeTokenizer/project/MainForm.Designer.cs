namespace LollipopUI
{
    partial class MainForm
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btn_canceled_indexing = new LollipopFlatButton();
            this.btn_canceled_tokenize = new LollipopFlatButton();
            this.progress_bar = new LollipopProgressBar();
            this.browse_folder_tokenized = new LollipopFolderInPut();
            this.btn_indexing = new LollipopButton();
            this.txtbox_indexed = new LollipopTextBox();
            this.btn_tokenize = new LollipopButton();
            this.txtbox_tokenized = new LollipopTextBox();
            this.browse_folder_raw = new LollipopFolderInPut();
            this.txtbox_input = new LollipopTextBox();
            this.label_rye = new LollipopLabel();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btn_canceled_indexing
            // 
            this.btn_canceled_indexing.BackColor = System.Drawing.Color.Transparent;
            this.btn_canceled_indexing.FontColor = "#508ef5";
            this.btn_canceled_indexing.Location = new System.Drawing.Point(771, 52);
            this.btn_canceled_indexing.Name = "btn_canceled_indexing";
            this.btn_canceled_indexing.Size = new System.Drawing.Size(90, 41);
            this.btn_canceled_indexing.TabIndex = 14;
            this.btn_canceled_indexing.Text = "Cancel";
            this.btn_canceled_indexing.Click += new System.EventHandler(this.btn_canceled_indexing_Click);
            // 
            // btn_canceled_tokenize
            // 
            this.btn_canceled_tokenize.BackColor = System.Drawing.Color.Transparent;
            this.btn_canceled_tokenize.FontColor = "#508ef5";
            this.btn_canceled_tokenize.Location = new System.Drawing.Point(374, 52);
            this.btn_canceled_tokenize.Name = "btn_canceled_tokenize";
            this.btn_canceled_tokenize.Size = new System.Drawing.Size(90, 41);
            this.btn_canceled_tokenize.TabIndex = 13;
            this.btn_canceled_tokenize.Text = "Cancel";
            this.btn_canceled_tokenize.Click += new System.EventHandler(this.btn_canceled_tokenize_Click);
            // 
            // progress_bar
            // 
            this.progress_bar.BGColor = "#508ef5";
            this.progress_bar.Location = new System.Drawing.Point(7, 440);
            this.progress_bar.Name = "progress_bar";
            this.progress_bar.Size = new System.Drawing.Size(916, 10);
            this.progress_bar.TabIndex = 12;
            this.progress_bar.Text = "100%";
            this.progress_bar.Value = 0;
            // 
            // browse_folder_tokenized
            // 
            this.browse_folder_tokenized.AccessibleDescription = "Open Tokenized folder";
            this.browse_folder_tokenized.FocusedColor = " #2196f3";
            this.browse_folder_tokenized.FontColor = "#9e9e9e";
            this.browse_folder_tokenized.IsEnabled = true;
            this.browse_folder_tokenized.Location = new System.Drawing.Point(313, 99);
            this.browse_folder_tokenized.MaxLength = 32767;
            this.browse_folder_tokenized.Name = "browse_folder_tokenized";
            this.browse_folder_tokenized.ReadOnly = true;
            this.browse_folder_tokenized.Size = new System.Drawing.Size(300, 24);
            this.browse_folder_tokenized.TabIndex = 8;
            this.browse_folder_tokenized.Text = "Please select folder";
            this.browse_folder_tokenized.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.browse_folder_tokenized.UseSystemPasswordChar = false;
            this.browse_folder_tokenized.TextChanged += new System.EventHandler(this.browse_folder_tokenized_TextChanged);
            // 
            // btn_indexing
            // 
            this.btn_indexing.BackColor = System.Drawing.Color.Transparent;
            this.btn_indexing.BGColor = " #2196f3";
            this.btn_indexing.FontColor = "#f5f5f5";
            this.btn_indexing.Location = new System.Drawing.Point(622, 52);
            this.btn_indexing.Name = "btn_indexing";
            this.btn_indexing.Size = new System.Drawing.Size(143, 41);
            this.btn_indexing.TabIndex = 7;
            this.btn_indexing.Text = "Indexing";
            this.btn_indexing.Click += new System.EventHandler(this.btn_indexing_Click);
            // 
            // txtbox_indexed
            // 
            this.txtbox_indexed.FocusedColor = " #2196f3";
            this.txtbox_indexed.FontColor = "#9e9e9e";
            this.txtbox_indexed.IsEnabled = true;
            this.txtbox_indexed.Location = new System.Drawing.Point(622, 129);
            this.txtbox_indexed.MaxLength = 32767;
            this.txtbox_indexed.Multiline = true;
            this.txtbox_indexed.Name = "txtbox_indexed";
            this.txtbox_indexed.ReadOnly = true;
            this.txtbox_indexed.Size = new System.Drawing.Size(300, 300);
            this.txtbox_indexed.TabIndex = 6;
            this.txtbox_indexed.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbox_indexed.UseSystemPasswordChar = false;
            this.txtbox_indexed.WordWrap = false;
            // 
            // btn_tokenize
            // 
            this.btn_tokenize.BackColor = System.Drawing.Color.Transparent;
            this.btn_tokenize.BGColor = " #2196f3";
            this.btn_tokenize.FontColor = "#f5f5f5";
            this.btn_tokenize.Location = new System.Drawing.Point(470, 52);
            this.btn_tokenize.Name = "btn_tokenize";
            this.btn_tokenize.Size = new System.Drawing.Size(143, 41);
            this.btn_tokenize.TabIndex = 5;
            this.btn_tokenize.Text = "Tokenizing";
            this.btn_tokenize.Click += new System.EventHandler(this.btn_tokenize_Click);
            // 
            // txtbox_tokenized
            // 
            this.txtbox_tokenized.FocusedColor = " #2196f3";
            this.txtbox_tokenized.FontColor = "#9e9e9e";
            this.txtbox_tokenized.IsEnabled = true;
            this.txtbox_tokenized.Location = new System.Drawing.Point(313, 129);
            this.txtbox_tokenized.MaxLength = 32767;
            this.txtbox_tokenized.Multiline = true;
            this.txtbox_tokenized.Name = "txtbox_tokenized";
            this.txtbox_tokenized.ReadOnly = true;
            this.txtbox_tokenized.Size = new System.Drawing.Size(300, 300);
            this.txtbox_tokenized.TabIndex = 4;
            this.txtbox_tokenized.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbox_tokenized.UseSystemPasswordChar = false;
            this.txtbox_tokenized.WordWrap = false;
            // 
            // browse_folder_raw
            // 
            this.browse_folder_raw.AccessibleDescription = "Open RawData folder";
            this.browse_folder_raw.FocusedColor = " #2196f3";
            this.browse_folder_raw.FontColor = "#9e9e9e";
            this.browse_folder_raw.IsEnabled = true;
            this.browse_folder_raw.Location = new System.Drawing.Point(7, 99);
            this.browse_folder_raw.MaxLength = 32767;
            this.browse_folder_raw.Name = "browse_folder_raw";
            this.browse_folder_raw.ReadOnly = true;
            this.browse_folder_raw.Size = new System.Drawing.Size(300, 24);
            this.browse_folder_raw.TabIndex = 2;
            this.browse_folder_raw.Text = "Please select folder";
            this.browse_folder_raw.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.browse_folder_raw.UseSystemPasswordChar = false;
            this.browse_folder_raw.TextChanged += new System.EventHandler(this.browse_folder_raw_TextChanged);
            // 
            // txtbox_input
            // 
            this.txtbox_input.FocusedColor = " #2196f3";
            this.txtbox_input.FontColor = "#9e9e9e";
            this.txtbox_input.IsEnabled = true;
            this.txtbox_input.Location = new System.Drawing.Point(7, 129);
            this.txtbox_input.MaxLength = 32767;
            this.txtbox_input.Multiline = true;
            this.txtbox_input.Name = "txtbox_input";
            this.txtbox_input.ReadOnly = true;
            this.txtbox_input.Size = new System.Drawing.Size(300, 300);
            this.txtbox_input.TabIndex = 1;
            this.txtbox_input.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbox_input.UseSystemPasswordChar = false;
            this.txtbox_input.WordWrap = false;
            // 
            // label_rye
            // 
            this.label_rye.AutoSize = true;
            this.label_rye.BackColor = System.Drawing.Color.Transparent;
            this.label_rye.Font = new System.Drawing.Font("Forte", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rye.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label_rye.Location = new System.Drawing.Point(12, 9);
            this.label_rye.Name = "label_rye";
            this.label_rye.Size = new System.Drawing.Size(208, 52);
            this.label_rye.TabIndex = 0;
            this.label_rye.Text = "Tokenizer";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this.btn_canceled_indexing);
            this.Controls.Add(this.btn_canceled_tokenize);
            this.Controls.Add(this.btn_indexing);
            this.Controls.Add(this.btn_tokenize);
            this.Controls.Add(this.txtbox_input);
            this.Controls.Add(this.txtbox_indexed);
            this.Controls.Add(this.txtbox_tokenized);
            this.Controls.Add(this.browse_folder_raw);
            this.Controls.Add(this.browse_folder_tokenized);
            this.Controls.Add(this.progress_bar);
            this.Controls.Add(this.label_rye);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rye Tokenizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


		#endregion

		private LollipopFlatButton btn_canceled_tokenize;
		private LollipopFlatButton btn_canceled_indexing;
		private LollipopButton btn_tokenize;
		private LollipopButton btn_indexing;
		private LollipopTextBox txtbox_input;
		private LollipopTextBox txtbox_indexed;
		private LollipopTextBox txtbox_tokenized;
		private LollipopFolderInPut browse_folder_raw;
		private LollipopFolderInPut browse_folder_tokenized;
		private LollipopProgressBar progress_bar;
		private LollipopLabel label_rye;
		private System.Windows.Forms.Timer timer;
	}
}

