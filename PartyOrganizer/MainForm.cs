using System.Linq;

namespace PartyOrganizer
{
	public partial class MainForm : Form
	{
		private const int maxNumbers = 30;

		GuestInfo guestInfo = new GuestInfo();
		PartyInfo partyInfo = new PartyInfo();
		GuestManager guestManager = new GuestManager(maxNumbers);
		
		public MainForm()
		{
			InitializeComponent();
			//Begin my Code

			InitializeGUI();
		}

		private void InitializeGUI()
		{
			this.Text += " by Hasan Party Organizer Firm";
			lblNumberOfGuest.Text = string.Empty;
			lblTotalCost.Text = string.Empty;
			lblTotalFees.Text = string.Empty;
			lblSurpDef.Text = string.Empty;
			//lblNumberOfGuest.Text = "10"; // Checking reference has established or not.
			//lblTotalCost.Text = "10"; // Checking reference has established or not.
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			GuestInfo guestInfo = new GuestInfo();

			bool ok = ReadInput(ref guestInfo);
			if (ok)
			{
				guestManager.Add(guestInfo);
				UpdateGUI();
				CostCalculationGUI();
			}
		}

		private void UpdateGUI()
		{
			string[] infoString = guestManager.GetInfoString();

			if (infoString != null)
			{
				listGuest.Items.Clear();
				listGuest.Items.AddRange(infoString);
			}
			lblNumberOfGuest.Text = guestManager.NumOfGuest.ToString();
		}

		private void CostCalculationGUI()
		{
			lblTotalCost.Text = guestManager.TotalCost().ToString("f2");
			lblTotalFees.Text = guestManager.TotalFees().ToString("f2");
			lblSurpDef.Text = guestManager.SurDeficit().ToString("f2");
		}

		private bool ReadInput(ref GuestInfo guestInfo)
		{
			bool ok = true;

			if ((string.IsNullOrEmpty(txtFirstName.Text)) && (string.IsNullOrEmpty(txtLastName.Text)))
			{
				guestInfo.FirstName = "No First Name";
				guestInfo.LastName = "No Last Name";
			}
			else
			{
				guestInfo.FirstName = txtFirstName.Text;
				guestInfo.LastName = txtLastName.Text;
			}

			return ok;
		}

		private void btnChange_Click(object sender, EventArgs e)
		{
			int index = listGuest.SelectedIndex;

			if (index == -1)
			{
				MessageBox.Show("Select an item in the listbox");
				return;
			}

			GuestInfo guestInfo = new GuestInfo();

			if (guestInfo != null)
			{
				bool ok = ReadInput(ref guestInfo);
				guestManager.CheangeAt(index, guestInfo);
			}

			UpdateGUI();
		}

		private void btnDetele_Click(object sender, EventArgs e)
		{
			int index = listGuest.SelectedIndex;
			double cost = guestManager.costPerPerson;
			double fees = guestManager.feePerPerson;

			if (index == -1)
			{
				MessageBox.Show("Select an item in the listbox");
				return;
			}
            else if (cost == -1)
            {
				MessageBox.Show("Select an item in the listbox");
				return;
			}
			else if ( fees == -1)
            {
				MessageBox.Show("Select an item in the listbox");
				return;
			}
            guestManager.DeleteAt(index);
			//guestManager.DeletePerPersonCost(cost);
			UpdateGUI();
			CostCalculationGUI();
		}

		private void btnCreateList_Click(object sender, EventArgs e)
		{
			// Read input validation
			bool ok = ReadMaxNumberOfGuest();
			ok = ReadCostPerPerson();
			ok = ReadFeePerPeron();

			if (ok)
			{
				// After validating getting valid information and set to desire method.

				guestManager.SetNewPartyInfo();

				//partyInfo.SetMaxNumberOfGuest(maxGuestNumber);
				//partyInfo.SetCostPerPerson(costPerPerson);
				//partyInfo.SetFeePerPerson(feePerPerson);

			}
			//txtMaxNumGues.Text = partyInfo.MaxNumberOfGuest.ToString();
			//txtCostPerPerson.Text = partyInfo.CostPerPerson.ToString();
			//txtFeePerPerson.Text = partyInfo.FeePerPerson.ToString();
		}

		//Validating input information.
		private bool ReadMaxNumberOfGuest()
		{
			//double max = 0.0;

			bool ok = double.TryParse(txtMaxNumGues.Text, out guestManager.maxGuestNumber);
			if (!ok)
			{
				MessageBox.Show("Invalid Input of Max Number of Guest", "Error");
			}
			else
			{
				MessageBox.Show($"Party list with Space for {guestManager.maxGuestNumber} guests created!", "Success");
			}

			return ok;
		}

		//Validating input information.
		private bool ReadCostPerPerson()
		{
			//double cost = 0.0;

			bool ok = double.TryParse(txtCostPerPerson.Text, out guestManager.costPerPerson);
			if (!ok)
			{
				MessageBox.Show("Invalid Input of Cost Per Person", "Error");
			}

			return ok;
		}

		//Validating input information.
		private bool ReadFeePerPeron()
		{
			//double fee = 0.0;

			bool ok = double.TryParse(txtFeePerPerson.Text, out guestManager.feePerPerson);
			if (!ok)
			{
				MessageBox.Show("Invalid Input of Fee Per Person", "Error");
			}

			return ok;
		}
	}
}