using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyOrganizer
{
	internal class GuestManager
	{

		PartyInfo partyInfo = new PartyInfo();
		private GuestInfo[] guestList;
		//public int numOfGuest = 0;
		public int numOfGuest;
		public double maxGuestNumber;
		public double costPerPerson;
		public double feePerPerson;

		public int NumOfGuest
		{
			get { return numOfGuest; }
		}

		public GuestManager (int maxNumbers)
		{
			guestList = new GuestInfo[maxNumbers];
		}

		//Collecting number of guest
		//public bool Add(GuestInfo guestInfo)
		//{
		//	bool ok = true;
		//	if((numOfGuest < guestList.Length) && (guestInfo != null))
		//	{
		//		guestList[numOfGuest++] = guestInfo;
		//	}
		//	else
		//	{
		//		ok = false;
		//	}
		//	return ok;
		//}

		public bool Add(GuestInfo guestInfo)
		{
			bool ok = true;
			if ((numOfGuest < guestList.Length) && (guestInfo != null) && (numOfGuest! < maxGuestNumber))
			{
				guestList[numOfGuest++] = guestInfo;
				//MessageBox.Show("Desired Guested has been registered.");
			}
			//if (numOfGuest! < maxGuestNumber)
			//{
			//	MessageBox.Show("Desired Guested has been registered.");
			//}
			else
			{
				MessageBox.Show($"Max Number of Guests has been Registered. You have registered {maxGuestNumber} number guest.", "Error");
				//ok = false;
			}
			return ok;
		}

		//Added Guest fullName OR taking information from the GuestInfo Class.
		public bool Add(string firstName, string lastName)
		{
			bool ok = false;
			if (numOfGuest < guestList.Length)
			{
				GuestInfo guestInfo = new GuestInfo();
				guestInfo.FirstName = firstName;
				guestInfo.LastName = lastName;

				guestList[numOfGuest++] = guestInfo; // First check then add.

				numOfGuest++;
				ok = true;
			}
			return ok;
		}

		//Method represented guest information from guestlist
		public string[] GetInfoString()
		{
			string[] infoString = new string[numOfGuest];

			for (int i = 0; i < numOfGuest; i++)
			{
				infoString[i] = guestList[i].ToString();
			}
			return infoString;
		}


		//Checking information, are det exit or not.
		public bool CheckIndex(int index)
		{
			bool ok = (index >= 0) && (index < guestList.Length);

			return ok;
		}

		//public bool CheckCost(double cost)
		//{
		//	bool ok = (cost >= 0) && (cost < costPerPerson);

		//	return ok;
		//}



		//Creating Change input information.
		public void CheangeAt(int index, GuestInfo guestInfo)
		{
			if (CheckIndex(index))
			{
				guestList[index] = guestInfo;
			}
		}

		//Creating Delete input information.
		public void DeleteAt(int index)
		{
			if (CheckIndex(index))
			{
				guestList[index] = null;
				numOfGuest--;

				for (int i = index + 1; i < guestList.Length; i++)
				{
					guestList[i - 1] = guestList[i];
				}
			}
		}

		//public void DeletePerPersonCost(double cost)
		//{
		//	if (CheckCost(cost))
		//	{
		//		costPerPerson = 0;
		//		//costPerPerson--;

		//		for (double i = cost; i < costPerPerson; i++)
		//		{
		//			costPerPerson--;
		//		}
		//	}
		//}

		public double TotalCost()
		{
			double totalCost = NumOfGuest * costPerPerson;
			//lblTotalCost.Text += totalCost;
			//lblTotalCost.Text = totalCost.ToString("f2");
			//return totalCost;

			return totalCost;
		}

		//getting total fees.
		public double TotalFees()
		{
			double totalFees = NumOfGuest * feePerPerson;
			return totalFees;
		}

		//public double SurDeficit()
		//{
		//	double totalSurDeficit = costPerPerson - feePerPerson;
		//	return totalSurDeficit;
		//}

		//public double SurDeficit()
		//{
		//	double totalSurDeficit = SetCostPerPerson - SetFeePerPerson;
		//	return totalSurDeficit;
		//}

		// Calculating showing surplus / dificit.
		public double SurDeficit()
		{
			double totalSurDeficit = TotalCost() - TotalFees();

			return totalSurDeficit;

			//return TotalCost() - TotalFees();
		}

		public void SetNewPartyInfo()
		{
			partyInfo.SetMaxNumberOfGuest(maxGuestNumber);
			partyInfo.SetCostPerPerson(costPerPerson);
			partyInfo.SetFeePerPerson(feePerPerson);
		}

		public string ReadMaxNumberToString()
		{
			return maxGuestNumber.ToString();
		}
	}
}
