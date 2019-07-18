using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthWindDataLibrary;

namespace ReadEditCustomerWithSpecialClass.Forms
{
    public partial class ContactForm : Form
    {
        private List<ContactType> _contactTitles;
        public ContactForm()
        {
            InitializeComponent();
        }

        public ContactForm(List<ContactType> pContactTitles)
        {
            InitializeComponent();

            _contactTitles = pContactTitles;
            Shown += ContactForm_Shown;
        }

        private void ContactForm_Shown(object sender, EventArgs e)
        {
            ContactTypeComboBox.DataSource = _contactTitles;
        }
    }
}
