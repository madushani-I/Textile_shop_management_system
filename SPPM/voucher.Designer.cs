namespace SPPM
{
	partial class voucher
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_v_amt = new System.Windows.Forms.TextBox();
			this.txt_v_name = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.panel1.Controls.Add(this.txt_v_name);
			this.panel1.Controls.Add(this.txt_v_amt);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(8, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(715, 539);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Minion Pro", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(234, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(230, 45);
			this.label1.TabIndex = 0;
			this.label1.Text = "Create Vouchers";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(282, 365);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(182, 30);
			this.button1.TabIndex = 1;
			this.button1.Text = "Issue";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(154, 203);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Amount";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(154, 257);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "Name";
			// 
			// txt_v_amt
			// 
			this.txt_v_amt.Location = new System.Drawing.Point(282, 200);
			this.txt_v_amt.Name = "txt_v_amt";
			this.txt_v_amt.Size = new System.Drawing.Size(182, 22);
			this.txt_v_amt.TabIndex = 4;
			// 
			// txt_v_name
			// 
			this.txt_v_name.Location = new System.Drawing.Point(282, 264);
			this.txt_v_name.Name = "txt_v_name";
			this.txt_v_name.Size = new System.Drawing.Size(182, 22);
			this.txt_v_name.TabIndex = 5;
			// 
			// voucher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(735, 546);
			this.Controls.Add(this.panel1);
			this.Name = "voucher";
			this.Text = "voucher";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txt_v_name;
		private System.Windows.Forms.TextBox txt_v_amt;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
	}
}