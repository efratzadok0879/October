using Svg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;


namespace Countries_WinFormToAPI
{
    public partial class Form1 : Form
    {
        //in order to use HttpClient you have to install Microsoft.AspNet.WebApi.Client
        //run on Tools->Nuget Package Manager->Package Manager Console, this command:
        //Install-Package Microsoft.AspNet.WebApi.Client
        static HttpClient client = new HttpClient();
        List<Country> countries;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string url = "https://restcountries.eu/rest/v2/all?fields=name;nativeName;capital;population;flag";
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                countries = await response.Content.ReadAsAsync<List<Country>>();
            }
            countries.ForEach(country =>
            {
                countriesCB.Items.Add(country.name);
            });

        }

        private void countriesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex > 0)
            {
                //enter details of selected country in resultLbl
                string selectedCountryName = (sender as ComboBox).SelectedItem.ToString();
                Country selectedCountry = countries.First(country => country.name.Equals(selectedCountryName));
                resultLbl.Text = selectedCountry.ToString();

                //draw flag of selected country

                //1.download svg file
                string svgFileName = selectedCountry.flag;
                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile(svgFileName, "flag.svg");
                }

                //2.convert svg to png
                //in order to convert the image you have to use package Svg
                //run on Tools->Nuget Package Manager->Package Manager Console, this command:
                //Install-Package Svg
                var svgDocument = SvgDocument.Open("flag.svg");
                var bitmap = svgDocument.Draw();

                //3.resize image
                int width = 100;
                int height = 100 / bitmap.Width * bitmap.Height;
                bitmap = svgDocument.Draw(width, height);

                //4.show image in pictureBox
                pictureBox1.Image = bitmap;



            }
        }

    }
}

