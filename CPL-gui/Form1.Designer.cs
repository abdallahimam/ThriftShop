namespace CPL_gui
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
			this.sort = new System.Windows.Forms.Button();
			this.linq = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// sort
			// 
			this.sort.Location = new System.Drawing.Point(11, 148);
			this.sort.Name = "sort";
			this.sort.Size = new System.Drawing.Size(290, 41);
			this.sort.TabIndex = 0;
			this.sort.Text = "Sort";
			this.sort.UseVisualStyleBackColor = true;
			this.sort.Click += new System.EventHandler(this.sort_Click);
			// 
			// linq
			// 
			this.linq.Location = new System.Drawing.Point(12, 207);
			this.linq.Name = "linq";
			this.linq.Size = new System.Drawing.Size(289, 43);
			this.linq.TabIndex = 1;
			this.linq.Text = "Linq";
			this.linq.UseVisualStyleBackColor = true;
			this.linq.Click += new System.EventHandler(this.linq_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(42, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(226, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "Welcome To Gui CPL";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(313, 298);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.linq);
			this.Controls.Add(this.sort);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button sort;
		private System.Windows.Forms.Button linq;
		private System.Windows.Forms.Label label1;
	}
}

