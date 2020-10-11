namespace Alea
{
	partial class AleaForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AleaForm));
			this._msAlea = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this._tsAlea = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this._nudNumberOfPhrases = new Pikka.Domain.Gui.Controls.ToolStripNumericUpDown();
			this._ssAlea = new System.Windows.Forms.StatusStrip();
			this._lblInfo = new System.Windows.Forms.ToolStripStatusLabel();
			this._txResult = new System.Windows.Forms.TextBox();
			this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
			this._btLanguageNew = new System.Windows.Forms.ToolStripButton();
			this._btLanguageLoad = new System.Windows.Forms.ToolStripButton();
			this._btLanguageSave = new System.Windows.Forms.ToolStripButton();
			this._btLanguageDefault = new System.Windows.Forms.ToolStripButton();
			this._btGenerateText = new System.Windows.Forms.ToolStripButton();
			this._btCopyToClipboard = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this._btQuit = new System.Windows.Forms.ToolStripButton();
			this._msAlea.SuspendLayout();
			this._tsAlea.SuspendLayout();
			this._ssAlea.SuspendLayout();
			this.SuspendLayout();
			// 
			// _msAlea
			// 
			this._msAlea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(96)))));
			this._msAlea.Font = new System.Drawing.Font("Consolas", 10F);
			this._msAlea.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem2,
            this.toolStripMenuItem11,
            this.toolStripMenuItem14});
			this._msAlea.Location = new System.Drawing.Point(0, 0);
			this._msAlea.Name = "_msAlea";
			this._msAlea.Size = new System.Drawing.Size(933, 25);
			this._msAlea.TabIndex = 0;
			this._msAlea.Text = "menuStrip1";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(96)))));
			this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveasToolStripMenuItem,
            this.defaultToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
			this.toolStripMenuItem3.ForeColor = System.Drawing.Color.White;
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(84, 21);
			this.toolStripMenuItem3.Text = "&Language";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(96)))));
			this.newToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.newToolStripMenuItem.Text = "&New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.OnLanguageNew);
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(96)))));
			this.loadToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
			this.loadToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.loadToolStripMenuItem.Text = "&Load";
			this.loadToolStripMenuItem.Click += new System.EventHandler(this.OnLanguageLoad);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(96)))));
			this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.OnLanguageSave);
			// 
			// saveasToolStripMenuItem
			// 
			this.saveasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(96)))));
			this.saveasToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.saveasToolStripMenuItem.Name = "saveasToolStripMenuItem";
			this.saveasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.saveasToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.saveasToolStripMenuItem.Text = "Save &as";
			this.saveasToolStripMenuItem.Click += new System.EventHandler(this.OnLanguageSaveAs);
			// 
			// defaultToolStripMenuItem
			// 
			this.defaultToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(96)))));
			this.defaultToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
			this.defaultToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
			this.defaultToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.defaultToolStripMenuItem.Text = "&Default";
			this.defaultToolStripMenuItem.Click += new System.EventHandler(this.OnLanguageDefault);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(96)))));
			this.toolStripSeparator1.ForeColor = System.Drawing.Color.White;
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(233, 6);
			// 
			// quitToolStripMenuItem
			// 
			this.quitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(96)))));
			this.quitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
			this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.quitToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
			this.quitToolStripMenuItem.Text = "&Quit";
			this.quitToolStripMenuItem.Click += new System.EventHandler(this.OnLanguageQuit);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(96)))));
			this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.toClipboardToolStripMenuItem,
            this.saveToolStripMenuItem1});
			this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(52, 21);
			this.toolStripMenuItem2.Text = "&Text";
			// 
			// createToolStripMenuItem
			// 
			this.createToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(96)))));
			this.createToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.createToolStripMenuItem.Name = "createToolStripMenuItem";
			this.createToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
			this.createToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
			this.createToolStripMenuItem.Text = "&Generate";
			this.createToolStripMenuItem.Click += new System.EventHandler(this.OnTextGenerate);
			// 
			// toClipboardToolStripMenuItem
			// 
			this.toClipboardToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(96)))));
			this.toClipboardToolStripMenuItem.ForeColor = System.Drawing.Color.White;
			this.toClipboardToolStripMenuItem.Name = "toClipboardToolStripMenuItem";
			this.toClipboardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.toClipboardToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
			this.toClipboardToolStripMenuItem.Text = "To &Clipboard";
			this.toClipboardToolStripMenuItem.Click += new System.EventHandler(this.OnTextToClipboard);
			// 
			// saveToolStripMenuItem1
			// 
			this.saveToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(96)))));
			this.saveToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
			this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
			this.saveToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem1.Size = new System.Drawing.Size(228, 22);
			this.saveToolStripMenuItem1.Text = "&Save";
			this.saveToolStripMenuItem1.Click += new System.EventHandler(this.OnTextSave);
			// 
			// _tsAlea
			// 
			this._tsAlea.AutoSize = false;
			this._tsAlea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(96)))));
			this._tsAlea.Font = new System.Drawing.Font("Consolas", 10F);
			this._tsAlea.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._btLanguageNew,
            this._btLanguageLoad,
            this._btLanguageSave,
            this._btLanguageDefault,
            this._btGenerateText,
            this._btCopyToClipboard,
            this.toolStripSeparator2,
            this.toolStripButton2,
            this.toolStripSeparator3,
            this._btQuit,
            this.toolStripLabel1,
            this._nudNumberOfPhrases});
			this._tsAlea.Location = new System.Drawing.Point(0, 25);
			this._tsAlea.Name = "_tsAlea";
			this._tsAlea.Size = new System.Drawing.Size(933, 40);
			this._tsAlea.TabIndex = 1;
			this._tsAlea.Text = "toolStrip1";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 40);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(0, 1, 6, 2);
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(144, 37);
			this.toolStripLabel1.Text = "Number of phrases";
			// 
			// _nudNumberOfPhrases
			// 
			this._nudNumberOfPhrases.AutoSize = false;
			this._nudNumberOfPhrases.BackColor = System.Drawing.Color.Black;
			this._nudNumberOfPhrases.ForeColor = System.Drawing.Color.White;
			this._nudNumberOfPhrases.Increment = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this._nudNumberOfPhrases.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this._nudNumberOfPhrases.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this._nudNumberOfPhrases.Name = "_nudNumberOfPhrases";
			this._nudNumberOfPhrases.Size = new System.Drawing.Size(60, 38);
			this._nudNumberOfPhrases.Text = "1";
			this._nudNumberOfPhrases.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// _ssAlea
			// 
			this._ssAlea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(96)))));
			this._ssAlea.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._lblInfo});
			this._ssAlea.Location = new System.Drawing.Point(0, 497);
			this._ssAlea.Name = "_ssAlea";
			this._ssAlea.Size = new System.Drawing.Size(933, 22);
			this._ssAlea.TabIndex = 2;
			this._ssAlea.Text = "statusStrip1";
			// 
			// _lblInfo
			// 
			this._lblInfo.Font = new System.Drawing.Font("Consolas", 10F);
			this._lblInfo.Name = "_lblInfo";
			this._lblInfo.Size = new System.Drawing.Size(72, 17);
			this._lblInfo.Text = "...ready";
			// 
			// _txResult
			// 
			this._txResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this._txResult.Font = new System.Drawing.Font("Courier New", 14F);
			this._txResult.Location = new System.Drawing.Point(0, 65);
			this._txResult.Multiline = true;
			this._txResult.Name = "_txResult";
			this._txResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this._txResult.Size = new System.Drawing.Size(933, 432);
			this._txResult.TabIndex = 3;
			// 
			// toolStripMenuItem11
			// 
			this.toolStripMenuItem11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(96)))));
			this.toolStripMenuItem11.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem12,
            this.toolStripMenuItem13});
			this.toolStripMenuItem11.ForeColor = System.Drawing.Color.White;
			this.toolStripMenuItem11.Name = "toolStripMenuItem11";
			this.toolStripMenuItem11.Size = new System.Drawing.Size(60, 21);
			this.toolStripMenuItem11.Text = "&Tools";
			// 
			// toolStripMenuItem12
			// 
			this.toolStripMenuItem12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(96)))));
			this.toolStripMenuItem12.ForeColor = System.Drawing.Color.White;
			this.toolStripMenuItem12.Name = "toolStripMenuItem12";
			this.toolStripMenuItem12.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
			this.toolStripMenuItem12.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItem12.Text = "Create &Password";
			this.toolStripMenuItem12.Click += new System.EventHandler(this.OnToolsCreatePassword);
			// 
			// toolStripMenuItem13
			// 
			this.toolStripMenuItem13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(96)))));
			this.toolStripMenuItem13.ForeColor = System.Drawing.Color.White;
			this.toolStripMenuItem13.Name = "toolStripMenuItem13";
			this.toolStripMenuItem13.Size = new System.Drawing.Size(300, 22);
			this.toolStripMenuItem13.Text = "&Settings";
			this.toolStripMenuItem13.Click += new System.EventHandler(this.OnToolsSettings);
			// 
			// toolStripMenuItem14
			// 
			this.toolStripMenuItem14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(96)))));
			this.toolStripMenuItem14.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem15});
			this.toolStripMenuItem14.ForeColor = System.Drawing.Color.White;
			this.toolStripMenuItem14.Name = "toolStripMenuItem14";
			this.toolStripMenuItem14.Size = new System.Drawing.Size(52, 21);
			this.toolStripMenuItem14.Text = "&Help";
			// 
			// toolStripMenuItem15
			// 
			this.toolStripMenuItem15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(96)))));
			this.toolStripMenuItem15.ForeColor = System.Drawing.Color.White;
			this.toolStripMenuItem15.Name = "toolStripMenuItem15";
			this.toolStripMenuItem15.Size = new System.Drawing.Size(116, 22);
			this.toolStripMenuItem15.Text = "&About";
			this.toolStripMenuItem15.Click += new System.EventHandler(this.OnHelpAbout);
			// 
			// _btLanguageNew
			// 
			this._btLanguageNew.AutoSize = false;
			this._btLanguageNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._btLanguageNew.Image = global::Alea.Properties.Resources.LanguageNew;
			this._btLanguageNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._btLanguageNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._btLanguageNew.Margin = new System.Windows.Forms.Padding(0);
			this._btLanguageNew.Name = "_btLanguageNew";
			this._btLanguageNew.Size = new System.Drawing.Size(36, 36);
			this._btLanguageNew.Text = "toolStripButton1";
			this._btLanguageNew.ToolTipText = "Created a new language";
			this._btLanguageNew.Click += new System.EventHandler(this.OnLanguageNew);
			// 
			// _btLanguageLoad
			// 
			this._btLanguageLoad.AutoSize = false;
			this._btLanguageLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._btLanguageLoad.Image = global::Alea.Properties.Resources.LanguageLoad;
			this._btLanguageLoad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._btLanguageLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._btLanguageLoad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this._btLanguageLoad.Name = "_btLanguageLoad";
			this._btLanguageLoad.Size = new System.Drawing.Size(36, 36);
			this._btLanguageLoad.Text = "toolStripButton2";
			this._btLanguageLoad.ToolTipText = "Loads a language from file";
			this._btLanguageLoad.Click += new System.EventHandler(this.OnLanguageLoad);
			// 
			// _btLanguageSave
			// 
			this._btLanguageSave.AutoSize = false;
			this._btLanguageSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._btLanguageSave.Image = global::Alea.Properties.Resources.LanguageSave;
			this._btLanguageSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._btLanguageSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._btLanguageSave.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
			this._btLanguageSave.Name = "_btLanguageSave";
			this._btLanguageSave.Size = new System.Drawing.Size(36, 36);
			this._btLanguageSave.Text = "toolStripButton3";
			this._btLanguageSave.ToolTipText = "Saves the language";
			this._btLanguageSave.Click += new System.EventHandler(this.OnLanguageSave);
			// 
			// _btLanguageDefault
			// 
			this._btLanguageDefault.AutoSize = false;
			this._btLanguageDefault.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._btLanguageDefault.Image = global::Alea.Properties.Resources.Default;
			this._btLanguageDefault.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._btLanguageDefault.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._btLanguageDefault.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
			this._btLanguageDefault.Name = "_btLanguageDefault";
			this._btLanguageDefault.Size = new System.Drawing.Size(36, 36);
			this._btLanguageDefault.Text = "toolStripButton1";
			this._btLanguageDefault.ToolTipText = "Set default language";
			this._btLanguageDefault.Click += new System.EventHandler(this.OnLanguageDefault);
			// 
			// _btGenerateText
			// 
			this._btGenerateText.AutoSize = false;
			this._btGenerateText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._btGenerateText.Image = global::Alea.Properties.Resources.Dice;
			this._btGenerateText.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this._btGenerateText.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._btGenerateText.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._btGenerateText.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
			this._btGenerateText.Name = "_btGenerateText";
			this._btGenerateText.Size = new System.Drawing.Size(36, 36);
			this._btGenerateText.ToolTipText = "Generates Text";
			this._btGenerateText.Click += new System.EventHandler(this.OnTextGenerate);
			// 
			// _btCopyToClipboard
			// 
			this._btCopyToClipboard.AutoSize = false;
			this._btCopyToClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._btCopyToClipboard.Image = global::Alea.Properties.Resources.CopyToClipboard;
			this._btCopyToClipboard.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._btCopyToClipboard.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._btCopyToClipboard.Margin = new System.Windows.Forms.Padding(0);
			this._btCopyToClipboard.Name = "_btCopyToClipboard";
			this._btCopyToClipboard.Size = new System.Drawing.Size(36, 36);
			this._btCopyToClipboard.Text = "toolStripButton1";
			this._btCopyToClipboard.ToolTipText = "Copy text to clipboard";
			this._btCopyToClipboard.Click += new System.EventHandler(this.OnTextToClipboard);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.AutoSize = false;
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = global::Alea.Properties.Resources.Settings;
			this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(36, 36);
			this.toolStripButton2.Text = "toolStripButton1";
			this.toolStripButton2.ToolTipText = "Settings";
			this.toolStripButton2.Click += new System.EventHandler(this.OnToolsSettings);
			// 
			// _btQuit
			// 
			this._btQuit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this._btQuit.AutoSize = false;
			this._btQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this._btQuit.Image = global::Alea.Properties.Resources.Quit;
			this._btQuit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this._btQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._btQuit.Margin = new System.Windows.Forms.Padding(0);
			this._btQuit.Name = "_btQuit";
			this._btQuit.Size = new System.Drawing.Size(36, 36);
			this._btQuit.Text = "toolStripButton1";
			this._btQuit.ToolTipText = "Quit";
			this._btQuit.Click += new System.EventHandler(this.OnLanguageQuit);
			// 
			// AleaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(48)))));
			this.ClientSize = new System.Drawing.Size(933, 519);
			this.Controls.Add(this._txResult);
			this.Controls.Add(this._ssAlea);
			this.Controls.Add(this._tsAlea);
			this.Controls.Add(this._msAlea);
			this.Font = new System.Drawing.Font("Consolas", 10F);
			this.ForeColor = System.Drawing.Color.White;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this._msAlea;
			this.Name = "AleaForm";
			this.Text = "Alea 1.0.0.0";
			this._msAlea.ResumeLayout(false);
			this._msAlea.PerformLayout();
			this._tsAlea.ResumeLayout(false);
			this._tsAlea.PerformLayout();
			this._ssAlea.ResumeLayout(false);
			this._ssAlea.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip _msAlea;
		private System.Windows.Forms.ToolStrip _tsAlea;
		private System.Windows.Forms.StatusStrip _ssAlea;
		private System.Windows.Forms.ToolStripStatusLabel _lblInfo;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toClipboardToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
		private System.Windows.Forms.ToolStripButton _btLanguageNew;
		private System.Windows.Forms.ToolStripButton _btLanguageLoad;
		private System.Windows.Forms.ToolStripButton _btLanguageSave;
		private System.Windows.Forms.ToolStripButton _btGenerateText;
		private System.Windows.Forms.ToolStripButton _btLanguageDefault;
		private System.Windows.Forms.ToolStripButton _btQuit;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton _btCopyToClipboard;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private Pikka.Domain.Gui.Controls.ToolStripNumericUpDown _nudNumberOfPhrases;
		private System.Windows.Forms.TextBox _txResult;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
	}
}

