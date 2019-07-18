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
    public partial class CustomerEditorForm : Form
    {
        private List<CountryItem> _countries;
        private List<ContactType> _contactTitles; 
        public CustomerEditorForm()
        {
            InitializeComponent();
        }

        public CustomerEditorForm(List<CountryItem> pCountries, List<ContactType> pContactTitles)
        {
            InitializeComponent();

            _countries = pCountries;
            _contactTitles = pContactTitles;
        }

        private void CustomerEditorForm_Load(object sender, EventArgs e)
        {
            CountryComboBox.DataSource = _countries;
        }

        private void CreateContact_Click(object sender, EventArgs e)
        {
            var f = new ContactForm(_contactTitles);
            if (f.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}
