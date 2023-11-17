using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyOrganizer
{
	public class PartyInfo
	{
		private double maxNumberOfGuest;
		private double costPerPerson;
		private double feePerPerson;

		public double GetMaxNumberOfGuest
		{
			get { return maxNumberOfGuest; }
		}

		public void SetMaxNumberOfGuest(double maxGuestNumber)
		{
			if (maxGuestNumber >= 0)
				this.maxNumberOfGuest = maxGuestNumber;
		}

		public double GetCostPerPerson
		{
			get { return costPerPerson; }
		}

		public void SetCostPerPerson(double costPerPerson)
		{
			if (costPerPerson >= 0)
				this.costPerPerson = costPerPerson;
		}

		public double GetFeePerPerson
		{
			get { return feePerPerson; }
		}

		public void SetFeePerPerson(double feePerPerson)
		{
			if (feePerPerson >= 0)
				this.feePerPerson = feePerPerson;
		}
	}

	//internal class PartyInfo
	//{
	//	private double maxNumberOfGuest;
	//	private double costPerPerson;
	//	private double feePerPerson;

	//	public double MaxNumberOfGuest
	//	{
	//		get { return maxNumberOfGuest; }
	//		set
	//		{
	//			maxNumberOfGuest = value;
	//		}
	//	}

	//	public double CostPerPerson
	//	{
	//		get { return costPerPerson; }
	//		set
	//		{
	//			costPerPerson = value;
	//		}
	//	}

	//	public double FeePerPerson
	//	{
	//		get { return feePerPerson; }
	//		set
	//		{
	//			feePerPerson = value;
	//		}
	//	}
	//}
}
