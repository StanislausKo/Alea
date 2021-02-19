namespace Alea
{
	partial class PasswordGeneratorDialog
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
			this.label1 = new System.Windows.Forms.Label();
			this.m_tbPattern = new System.Windows.Forms.TextBox();
			this.m_tbPasswo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.m_btGenerate = new System.Windows.Forms.Button();
			this.m_btCopy = new System.Windows.Forms.Button();
			this.m_btClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Pattern";
			// 
			// m_tbPattern
			// 
			this.m_tbPattern.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_tbPattern.Location = new System.Drawing.Point(61, 5);
			this.m_tbPattern.Name = "m_tbPattern";
			this.m_tbPattern.Size = new System.Drawing.Size(349, 21);
			this.m_tbPattern.TabIndex = 1;
			this.m_tbPattern.Text = "AaaaBbbb999";
			// 
			// m_tbPasswo
			// 
			this.m_tbPasswo.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.m_tbPasswo.Location = new System.Drawing.Point(61, 42);
			this.m_tbPasswo.Name = "m_tbPasswo";
			this.m_tbPasswo.Size = new System.Drawing.Size(349, 21);
			this.m_tbPasswo.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Result";
			// 
			// m_btGenerate
			// 
			this.m_btGenerate.Location = new System.Drawing.Point(61, 81);
			this.m_btGenerate.Name = "m_btGenerate";
			this.m_btGenerate.Size = new System.Drawing.Size(75, 23);
			this.m_btGenerate.TabIndex = 4;
			this.m_btGenerate.Text = "&Generate";
			this.m_btGenerate.UseVisualStyleBackColor = true;
			this.m_btGenerate.Click += new System.EventHandler(this.OnGenerate);
			// 
			// m_btCopy
			// 
			this.m_btCopy.Location = new System.Drawing.Point(198, 81);
			this.m_btCopy.Name = "m_btCopy";
			this.m_btCopy.Size = new System.Drawing.Size(75, 23);
			this.m_btCopy.TabIndex = 4;
			this.m_btCopy.Text = "&Copy";
			this.m_btCopy.UseVisualStyleBackColor = true;
			this.m_btCopy.Click += new System.EventHandler(this.OnCopy);
			// 
			// m_btClose
			// 
			this.m_btClose.Location = new System.Drawing.Point(335, 81);
			this.m_btClose.Name = "m_btClose";
			this.m_btClose.Size = new System.Drawing.Size(75, 23);
			this.m_btClose.TabIndex = 4;
			this.m_btClose.Text = "&Close";
			this.m_btClose.UseVisualStyleBackColor = true;
			this.m_btClose.Click += new System.EventHandler(this.OnClose);
			// 
			// PasswordGeneratorDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(422, 129);
			this.Controls.Add(this.m_btClose);
			this.Controls.Add(this.m_btCopy);
			this.Controls.Add(this.m_btGenerate);
			this.Controls.Add(this.m_tbPasswo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.m_tbPattern);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "PasswordGeneratorDialog";
			this.Text = "PasswordGeneratorDialog";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox m_tbPattern;
		private System.Windows.Forms.TextBox m_tbPasswo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button m_btGenerate;
		private System.Windows.Forms.Button m_btCopy;
		private System.Windows.Forms.Button m_btClose;
	}
}