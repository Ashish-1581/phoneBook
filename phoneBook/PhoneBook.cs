using System;
namespace phoneBook
{
	public class PhoneBook
	{
		private List<Contact> _contacts { get; set; } = new List<Contact>();

		private void DisplayContactDetails(Contact contact)
		{
            Console.WriteLine($"contact:{contact.Name},{contact.Number}");
        }

        private void DisplayContactsDetails(List<Contact>contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }

        public void AddContact(Contact contact)
		{
			_contacts.Add(contact);
		}

		public void DisplayContact(string number)
		{
			var contact = _contacts.FirstOrDefault(c => c.Number == number);
			if(contact==null)
			{
				Console.WriteLine("Contact not found");
			}
			else
			{
				DisplayContactDetails(contact);
			}
		}


		public void DisplayAllContact()
		{
			DisplayContactsDetails(_contacts);
		}

		public void DisplayMatchingContacts(string searchPhrase)
		{
			var matchingContacts = _contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();

            DisplayContactsDetails(matchingContacts);
        }
	}
}

