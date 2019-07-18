using System;
using System.Linq;
using System.Windows.Forms;
using NorthWindDataLibrary;
using NorthWindDataLibrary.Classes;

namespace ReadEditCustomerWithSpecialClass.Forms
{
    public partial class ContactSelectionForm : Form
    {
        public Contact Contact;
        private int? _contactIdentifier;
        // ReSharper disable once PossibleInvalidOperationException
        public int ContactIdentifier => _contactIdentifier.Value;
        public ContactSelectionForm()
        {
            InitializeComponent();
        }
        public ContactSelectionForm(int? pContactIdentifier)
        {
            InitializeComponent();
            _contactIdentifier = pContactIdentifier;
            Shown += ContactSelectionForm_Shown;
        }
        /// <summary>
        /// Load all contacts, select current contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactSelectionForm_Shown(object sender, EventArgs e)
        {
            var ops = new Operations();
            var contacts = ops.GetContacts();

            var currentContact = contacts
                .FirstOrDefault(c => c.ContactId == _contactIdentifier);

            var index = contacts.IndexOf(currentContact);

            listBox1.DataSource = contacts
                .Select(contact => 
                    new ContactListBox()
                    {
                        ContactId = contact.ContactId,
                        Name = $"{contact.FirstName} {contact.LastName}"
                    }).ToList();

            listBox1.SelectedIndex = index;
        }
        /// <summary>
        /// Set contact identifier back to calling form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectButton_Click(object sender, EventArgs e)
        {
            var selected = (ContactListBox) listBox1.SelectedItem;
            _contactIdentifier = selected.ContactId;
            DialogResult = DialogResult.OK;
        }
    }
}
