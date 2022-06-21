using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace googleMaps
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void stateLabel_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string street = streetTextBox.Text;
            string city = cityTextBox.Text;
            string state = stateTextBox.Text;
            string zipcode = zipTextBox.Text;

            try
            {
                StringBuilder queryData = new StringBuilder();
                queryData.Append("http://maps.google.com/maps?q=");

                if ( street != string.Empty)
                {
                    queryData.Append(street + "," + "+");
                }
                if (city != string.Empty)
                {
                    queryData.Append(city + "," + "+");
                }
                if (state != string.Empty)
                {
                    queryData.Append(state + "," + "+");
                }
                if (zipcode != string.Empty)
                {
                    queryData.Append(zipcode + "," + "+");
                }
                webBrowser1.Navigate(queryData.ToString());
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }
    }
}
