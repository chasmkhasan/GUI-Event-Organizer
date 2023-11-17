namespace PartyOrganizer
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			txtMaxNumGues = new TextBox();
			txtCostPerPerson = new TextBox();
			txtFeePerPerson = new TextBox();
			grpNewParty = new GroupBox();
			btnCreateList = new Button();
			label4 = new Label();
			txtFirstName = new TextBox();
			label5 = new Label();
			txtLastName = new TextBox();
			groupBox2 = new GroupBox();
			btnAdd = new Button();
			label6 = new Label();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			lblNumberOfGuest = new Label();
			lblTotalCost = new Label();
			lblTotalFees = new Label();
			lblSurpDef = new Label();
			listGuest = new ListBox();
			btnChange = new Button();
			btnDetele = new Button();
			label10 = new Label();
			grpNewParty.SuspendLayout();
			groupBox2.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(18, 29);
			label1.Name = "label1";
			label1.Size = new Size(129, 15);
			label1.TabIndex = 0;
			label1.Text = "Max Number of Guests";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(18, 58);
			label2.Name = "label2";
			label2.Size = new Size(90, 15);
			label2.TabIndex = 1;
			label2.Text = "Cost Per Person";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(18, 84);
			label3.Name = "label3";
			label3.Size = new Size(84, 15);
			label3.TabIndex = 2;
			label3.Text = "Fee Per Person";
			// 
			// txtMaxNumGues
			// 
			txtMaxNumGues.Location = new Point(210, 23);
			txtMaxNumGues.Name = "txtMaxNumGues";
			txtMaxNumGues.Size = new Size(100, 23);
			txtMaxNumGues.TabIndex = 3;
			// 
			// txtCostPerPerson
			// 
			txtCostPerPerson.Location = new Point(210, 52);
			txtCostPerPerson.Name = "txtCostPerPerson";
			txtCostPerPerson.Size = new Size(100, 23);
			txtCostPerPerson.TabIndex = 4;
			// 
			// txtFeePerPerson
			// 
			txtFeePerPerson.Location = new Point(210, 81);
			txtFeePerPerson.Name = "txtFeePerPerson";
			txtFeePerPerson.Size = new Size(100, 23);
			txtFeePerPerson.TabIndex = 5;
			// 
			// grpNewParty
			// 
			grpNewParty.Controls.Add(btnCreateList);
			grpNewParty.Controls.Add(txtFeePerPerson);
			grpNewParty.Controls.Add(txtCostPerPerson);
			grpNewParty.Controls.Add(txtMaxNumGues);
			grpNewParty.Controls.Add(label3);
			grpNewParty.Controls.Add(label2);
			grpNewParty.Controls.Add(label1);
			grpNewParty.Location = new Point(19, 15);
			grpNewParty.Name = "grpNewParty";
			grpNewParty.Size = new Size(326, 154);
			grpNewParty.TabIndex = 6;
			grpNewParty.TabStop = false;
			grpNewParty.Text = "New Party";
			// 
			// btnCreateList
			// 
			btnCreateList.ForeColor = Color.FromArgb(0, 192, 0);
			btnCreateList.Location = new Point(76, 118);
			btnCreateList.Name = "btnCreateList";
			btnCreateList.Size = new Size(157, 28);
			btnCreateList.TabIndex = 6;
			btnCreateList.Text = "Create List";
			btnCreateList.UseVisualStyleBackColor = true;
			btnCreateList.Click += btnCreateList_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(21, 26);
			label4.Name = "label4";
			label4.Size = new Size(64, 15);
			label4.TabIndex = 7;
			label4.Text = "First Name";
			// 
			// txtFirstName
			// 
			txtFirstName.Location = new Point(119, 18);
			txtFirstName.Name = "txtFirstName";
			txtFirstName.Size = new Size(194, 23);
			txtFirstName.TabIndex = 7;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(22, 55);
			label5.Name = "label5";
			label5.Size = new Size(63, 15);
			label5.TabIndex = 8;
			label5.Text = "Last Name";
			// 
			// txtLastName
			// 
			txtLastName.Location = new Point(119, 52);
			txtLastName.Name = "txtLastName";
			txtLastName.Size = new Size(194, 23);
			txtLastName.TabIndex = 9;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(btnAdd);
			groupBox2.Controls.Add(txtLastName);
			groupBox2.Controls.Add(label5);
			groupBox2.Controls.Add(txtFirstName);
			groupBox2.Controls.Add(label4);
			groupBox2.Location = new Point(16, 182);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size(328, 123);
			groupBox2.TabIndex = 10;
			groupBox2.TabStop = false;
			groupBox2.Text = "Invite Guest";
			// 
			// btnAdd
			// 
			btnAdd.ForeColor = Color.FromArgb(0, 192, 0);
			btnAdd.Location = new Point(79, 89);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(157, 28);
			btnAdd.TabIndex = 7;
			btnAdd.Text = "Add";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(37, 360);
			label6.Name = "label6";
			label6.Size = new Size(103, 15);
			label6.TabIndex = 11;
			label6.Text = "Number of Guests";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(37, 392);
			label7.Name = "label7";
			label7.Size = new Size(59, 15);
			label7.TabIndex = 12;
			label7.Text = "Total Cost";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(38, 425);
			label8.Name = "label8";
			label8.Size = new Size(58, 15);
			label8.TabIndex = 13;
			label8.Text = "Total Fees";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(38, 458);
			label9.Name = "label9";
			label9.Size = new Size(85, 15);
			label9.TabIndex = 14;
			label9.Text = "Surplus/Deficit";
			// 
			// lblNumberOfGuest
			// 
			lblNumberOfGuest.BorderStyle = BorderStyle.Fixed3D;
			lblNumberOfGuest.Location = new Point(229, 359);
			lblNumberOfGuest.Name = "lblNumberOfGuest";
			lblNumberOfGuest.Size = new Size(100, 23);
			lblNumberOfGuest.TabIndex = 15;
			lblNumberOfGuest.Text = "Num Guest";
			lblNumberOfGuest.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblTotalCost
			// 
			lblTotalCost.BorderStyle = BorderStyle.Fixed3D;
			lblTotalCost.Location = new Point(229, 392);
			lblTotalCost.Name = "lblTotalCost";
			lblTotalCost.Size = new Size(100, 23);
			lblTotalCost.TabIndex = 16;
			lblTotalCost.Text = "Tot Cost";
			lblTotalCost.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblTotalFees
			// 
			lblTotalFees.BorderStyle = BorderStyle.Fixed3D;
			lblTotalFees.Location = new Point(229, 421);
			lblTotalFees.Name = "lblTotalFees";
			lblTotalFees.Size = new Size(100, 23);
			lblTotalFees.TabIndex = 17;
			lblTotalFees.Text = "Tot Fees";
			lblTotalFees.TextAlign = ContentAlignment.MiddleRight;
			// 
			// lblSurpDef
			// 
			lblSurpDef.BorderStyle = BorderStyle.Fixed3D;
			lblSurpDef.Location = new Point(229, 454);
			lblSurpDef.Name = "lblSurpDef";
			lblSurpDef.Size = new Size(100, 23);
			lblSurpDef.TabIndex = 18;
			lblSurpDef.Text = "Extra Money";
			lblSurpDef.TextAlign = ContentAlignment.MiddleRight;
			// 
			// listGuest
			// 
			listGuest.FormattingEnabled = true;
			listGuest.ItemHeight = 15;
			listGuest.Location = new Point(378, 53);
			listGuest.Name = "listGuest";
			listGuest.Size = new Size(341, 379);
			listGuest.TabIndex = 19;
			// 
			// btnChange
			// 
			btnChange.Location = new Point(409, 446);
			btnChange.Name = "btnChange";
			btnChange.Size = new Size(103, 38);
			btnChange.TabIndex = 20;
			btnChange.Text = "Change";
			btnChange.UseVisualStyleBackColor = true;
			btnChange.Click += btnChange_Click;
			// 
			// btnDetele
			// 
			btnDetele.ForeColor = Color.Red;
			btnDetele.Location = new Point(588, 446);
			btnDetele.Name = "btnDetele";
			btnDetele.Size = new Size(103, 38);
			btnDetele.TabIndex = 21;
			btnDetele.Text = "Delete";
			btnDetele.UseVisualStyleBackColor = true;
			btnDetele.Click += btnDetele_Click;
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new Point(514, 25);
			label10.Name = "label10";
			label10.Size = new Size(58, 15);
			label10.TabIndex = 22;
			label10.Text = "Guest List";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(741, 503);
			Controls.Add(label10);
			Controls.Add(btnDetele);
			Controls.Add(btnChange);
			Controls.Add(listGuest);
			Controls.Add(lblSurpDef);
			Controls.Add(lblTotalFees);
			Controls.Add(lblTotalCost);
			Controls.Add(lblNumberOfGuest);
			Controls.Add(label9);
			Controls.Add(label8);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(groupBox2);
			Controls.Add(grpNewParty);
			Name = "MainForm";
			Text = "Party Organizer";
			grpNewParty.ResumeLayout(false);
			grpNewParty.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox txtMaxNumGues;
		private TextBox txtCostPerPerson;
		private TextBox txtFeePerPerson;
		private GroupBox grpNewParty;
		private Button btnCreateList;
		private Label label4;
		private TextBox txtFirstName;
		private Label label5;
		private TextBox txtLastName;
		private GroupBox groupBox2;
		private Button btnAdd;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
		private Label lblNumberOfGuest;
		private Label lblTotalCost;
		private Label lblTotalFees;
		private Label lblSurpDef;
		private ListBox listGuest;
		private Button btnChange;
		private Button btnDetele;
		private Label label10;
	}
}