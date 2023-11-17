using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyOrganizer
{
	internal class GuestInfo
	{
		/// <summary>
		/// Taking Guest information
		/// Fixing getter and setter
		/// </summary>
		private string firstName;
		private string lastName;

		public string FirstName
		{
			get { return firstName; }
			set
			{
				
				if(!string.IsNullOrEmpty(value))
				firstName = value;
			}
		}

		public string LastName
		{
			get { return lastName; }
			set
			{
				
				if (!string.IsNullOrEmpty(value))
					lastName = value;
			}
		}

		//Delivered space between firstName and LastName.
		public override string ToString()
		{
			string textOut = $"{firstName,-20}{lastName,-20}";
			return textOut;
		}

	}
}
