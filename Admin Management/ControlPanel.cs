using Hotel_management.ModelUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Management
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        public async void  PostReservation_ClickAsync(object sender, EventArgs e)
        {
            var Client = new HttpClient();
            Client.BaseAddress = new Uri("https://localhost:7161/");
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            
            string serv = "";
            if (comboBoxServices.SelectedItem == null)
            {
                serv = "0";
            }
            else
            {
                if (comboBoxServices.SelectedItem.ToString() == "Sauna")
                {
                    serv = "100";
                }
                else if (comboBoxServices.SelectedItem.ToString() == "Massage")
                {
                    serv = "300";
                }
                else if (comboBoxServices.SelectedItem.ToString() == "Breakfast")
                {
                    serv = "25";
                }
                else if (comboBoxServices.SelectedItem.ToString() == "Gym")
                {
                    serv = "150";
                }
                else if (comboBoxServices.SelectedItem.ToString() == "nothing")
                {
                    serv = "0";
                }
            }

            if (dateTimePickerIn.Text == null || comboBoxHotel.SelectedItem == null || textBoxAdults.Text == null || textBoxChild.Text == null || clientName.Text == null || comboBoxChamber.SelectedItem == null )
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
            else
            {
                RequestBodyAdmin res = new RequestBodyAdmin()
                {
                    checkin = dateTimePickerIn.Text,
                    checkout = dateTimePickerOut.Text,
                    hotel = comboBoxHotel.SelectedItem.ToString(),
                    adult = textBoxAdults.Text,
                    child = textBoxChild.Text,
                    client = clientName.Text,
                    chamber = comboBoxChamber.SelectedItem.ToString(),
                    services = serv,
                };

                HttpResponseMessage resp = await Client.PostAsJsonAsync("api/Clients/PostReservationAdmin", res);

                if (resp.IsSuccessStatusCode)
                {
                    MessageBox.Show("Réservation effectué !");
                }
                else
                {
                    MessageBox.Show("Veuillez remplir les champs correctement et vérifier si le client existe !");
                }
            }
        }
    }
}
