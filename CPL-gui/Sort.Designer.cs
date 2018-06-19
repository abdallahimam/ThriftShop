namespace CPL_gui
{
	partial class Sort
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
			this.buttonAdd = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbNumber = new System.Windows.Forms.TextBox();
			this.normalList = new System.Windows.Forms.ListBox();
			this.buttonRemove = new System.Windows.Forms.Button();
			this.buttonReset = new System.Windows.Forms.Button();
			this.buttonFindKth = new System.Windows.Forms.Button();
			this.tbKth = new System.Windows.Forms.TextBox();
			this.tbView = new System.Windows.Forms.TextBox();
			this.sortedList = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// buttonAdd
			// 
			this.buttonAdd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAdd.Location = new System.Drawing.Point(148, 147);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(120, 31);
			this.buttonAdd.TabIndex = 0;
			this.buttonAdd.Text = "Add Number";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(32, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(350, 22);
			this.label1.TabIndex = 1;
			this.label1.Text = "Welcome to find kth largest number";
			// 
			// tbNumber
			// 
			this.tbNumber.Location = new System.Drawing.Point(148, 106);
			this.tbNumber.MaxLength = 30;
			this.tbNumber.Name = "tbNumber";
			this.tbNumber.Size = new System.Drawing.Size(120, 20);
			this.tbNumber.TabIndex = 4;
			// 
			// normalList
			// 
			this.normalList.FormattingEnabled = true;
			this.normalList.Location = new System.Drawing.Point(64, 197);
			this.normalList.Name = "normalList";
			this.normalList.Size = new System.Drawing.Size(120, 147);
			this.normalList.TabIndex = 6;
			// 
			// buttonRemove
			// 
			this.buttonRemove.Location = new System.Drawing.Point(64, 409);
			this.buttonRemove.Name = "buttonRemove";
			this.buttonRemove.Size = new System.Drawing.Size(75, 35);
			this.buttonRemove.TabIndex = 8;
			this.buttonRemove.Text = "Remove";
			this.buttonRemove.UseVisualStyleBackColor = true;
			this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
			// 
			// buttonReset
			// 
			this.buttonReset.Location = new System.Drawing.Point(282, 409);
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.Size = new System.Drawing.Size(75, 35);
			this.buttonReset.TabIndex = 9;
			this.buttonReset.Text = "Reset";
			this.buttonReset.UseVisualStyleBackColor = true;
			this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
			// 
			// buttonFindKth
			// 
			this.buttonFindKth.Location = new System.Drawing.Point(148, 365);
			this.buttonFindKth.Name = "buttonFindKth";
			this.buttonFindKth.Size = new System.Drawing.Size(120, 31);
			this.buttonFindKth.TabIndex = 10;
			this.buttonFindKth.Text = "Find Kth Value";
			this.buttonFindKth.UseVisualStyleBackColor = true;
			this.buttonFindKth.Click += new System.EventHandler(this.buttonFindKth_Click);
			// 
			// tbKth
			// 
			this.tbKth.Location = new System.Drawing.Point(64, 371);
			this.tbKth.Name = "tbKth";
			this.tbKth.Size = new System.Drawing.Size(78, 20);
			this.tbKth.TabIndex = 13;
			// 
			// tbView
			// 
			this.tbView.HideSelection = false;
			this.tbView.Location = new System.Drawing.Point(282, 371);
			this.tbView.Name = "tbView";
			this.tbView.ReadOnly = true;
			this.tbView.Size = new System.Drawing.Size(75, 20);
			this.tbView.TabIndex = 14;
			// 
			// sortedList
			// 
			this.sortedList.FormattingEnabled = true;
			this.sortedList.Location = new System.Drawing.Point(237, 197);
			this.sortedList.Name = "sortedList";
			this.sortedList.Size = new System.Drawing.Size(120, 147);
			this.sortedList.TabIndex = 15;
			// 
			// Sort
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(419, 472);
			this.Controls.Add(this.sortedList);
			this.Controls.Add(this.tbView);
			this.Controls.Add(this.tbKth);
			this.Controls.Add(this.buttonFindKth);
			this.Controls.Add(this.buttonReset);
			this.Controls.Add(this.buttonRemove);
			this.Controls.Add(this.normalList);
			this.Controls.Add(this.tbNumber);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonAdd);
			this.Name = "Sort";
			this.Text = "Sort";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbNumber;
		private System.Windows.Forms.ListBox normalList;
		private System.Windows.Forms.Button buttonRemove;
		private System.Windows.Forms.Button buttonReset;
		private System.Windows.Forms.Button buttonFindKth;
		private System.Windows.Forms.TextBox tbKth;
		private System.Windows.Forms.TextBox tbView;
		private System.Windows.Forms.ListBox sortedList;
	}
}