namespace SPPM
{
	partial class item_list
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
			System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Highlight, null);
			System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
			this.bill_list = new System.Windows.Forms.ListView();
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.full_price = new System.Windows.Forms.TextBox();
			this.qty_txt = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.item_code = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_dis = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_dis_amt = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.i_price = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.user_dis = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// bill_list
			// 
			this.bill_list.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.bill_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
			this.bill_list.HideSelection = false;
			this.bill_list.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5,
            listViewItem6});
			this.bill_list.Location = new System.Drawing.Point(12, -6);
			this.bill_list.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.bill_list.Name = "bill_list";
			this.bill_list.Size = new System.Drawing.Size(637, 468);
			this.bill_list.TabIndex = 19;
			this.bill_list.UseCompatibleStateImageBehavior = false;
			this.bill_list.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "ID    ";
			this.columnHeader6.Width = 70;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Name";
			this.columnHeader7.Width = 99;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Price";
			this.columnHeader8.Width = 80;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Quntity";
			this.columnHeader9.Width = 90;
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Full Amount";
			this.columnHeader10.Width = 130;
			// 
			// full_price
			// 
			this.full_price.Location = new System.Drawing.Point(747, 215);
			this.full_price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.full_price.Multiline = true;
			this.full_price.Name = "full_price";
			this.full_price.Size = new System.Drawing.Size(149, 25);
			this.full_price.TabIndex = 23;
			// 
			// qty_txt
			// 
			this.qty_txt.Location = new System.Drawing.Point(744, 86);
			this.qty_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.qty_txt.Multiline = true;
			this.qty_txt.Name = "qty_txt";
			this.qty_txt.Size = new System.Drawing.Size(149, 29);
			this.qty_txt.TabIndex = 22;
			this.qty_txt.TextChanged += new System.EventHandler(this.qty_txt_TextChanged);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(743, 408);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(329, 41);
			this.button1.TabIndex = 21;
			this.button1.Text = "Done";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// item_code
			// 
			this.item_code.Location = new System.Drawing.Point(743, 15);
			this.item_code.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.item_code.Multiline = true;
			this.item_code.Name = "item_code";
			this.item_code.Size = new System.Drawing.Size(149, 29);
			this.item_code.TabIndex = 20;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(655, 51);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(76, 17);
			this.label5.TabIndex = 26;
			this.label5.Text = "Items price";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(651, 89);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 17);
			this.label4.TabIndex = 25;
			this.label4.Text = "Items Quntity";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(655, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(71, 17);
			this.label3.TabIndex = 24;
			this.label3.Text = "Item Code";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(655, 129);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(90, 17);
			this.label1.TabIndex = 28;
			this.label1.Text = "Max DIsc (%)";
			// 
			// txt_dis
			// 
			this.txt_dis.Location = new System.Drawing.Point(743, 126);
			this.txt_dis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_dis.Multiline = true;
			this.txt_dis.Name = "txt_dis";
			this.txt_dis.Size = new System.Drawing.Size(61, 27);
			this.txt_dis.TabIndex = 27;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(806, 129);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(116, 17);
			this.label6.TabIndex = 32;
			this.label6.Text = "Max DIsc Amount";
			// 
			// txt_dis_amt
			// 
			this.txt_dis_amt.Location = new System.Drawing.Point(928, 126);
			this.txt_dis_amt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txt_dis_amt.Multiline = true;
			this.txt_dis_amt.Name = "txt_dis_amt";
			this.txt_dis_amt.Size = new System.Drawing.Size(102, 27);
			this.txt_dis_amt.TabIndex = 31;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(898, 18);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(86, 26);
			this.button2.TabIndex = 33;
			this.button2.Text = "Item Done";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(655, 215);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(76, 17);
			this.label7.TabIndex = 35;
			this.label7.Text = "Items price";
			// 
			// i_price
			// 
			this.i_price.Location = new System.Drawing.Point(743, 48);
			this.i_price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.i_price.Multiline = true;
			this.i_price.Name = "i_price";
			this.i_price.Size = new System.Drawing.Size(149, 25);
			this.i_price.TabIndex = 34;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(655, 170);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(61, 17);
			this.label8.TabIndex = 37;
			this.label8.Text = "DIsc (%)";
			// 
			// user_dis
			// 
			this.user_dis.Location = new System.Drawing.Point(743, 167);
			this.user_dis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.user_dis.Multiline = true;
			this.user_dis.Name = "user_dis";
			this.user_dis.Size = new System.Drawing.Size(61, 27);
			this.user_dis.TabIndex = 36;
			this.user_dis.Text = "0";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(806, 170);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(87, 17);
			this.label9.TabIndex = 39;
			this.label9.Text = "DIsc Amount";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(928, 167);
			this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(102, 27);
			this.textBox1.TabIndex = 38;
			this.textBox1.Text = "0";
			// 
			// item_list
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(1307, 473);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.user_dis);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.i_price);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txt_dis_amt);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_dis);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.full_price);
			this.Controls.Add(this.qty_txt);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.item_code);
			this.Controls.Add(this.bill_list);
			this.Name = "item_list";
			this.Text = "item_list";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView bill_list;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.TextBox full_price;
		private System.Windows.Forms.TextBox qty_txt;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox item_code;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_dis;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_dis_amt;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox i_price;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox user_dis;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox1;
	}
}