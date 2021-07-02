using Svg;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Countries
{
    public partial class Countries : Form
    {
        private List<Country> countries;
        public Countries()
        {
            try 
            {
                InitializeComponent();
                countries = (new JsonParser()).GetCoiuntries($"https://restcountries.eu/rest/v2/all?fields=name;capital;flag;population;region;");
                cbCountries.DataSource = countries;
            }
            catch 
            {
                MessageBox.Show("Failed to load data. There may be network problems.");
                Environment.Exit(0);
            }
        }

        private void cbCountries_SelectedValueChanged(object sender, EventArgs e)
        {
            var country = countries.Where(x => x.Name.Contains(cbCountries.Text)).FirstOrDefault();
            lInfo.Text = "Capital city: " + country?.Capital + Environment.NewLine + "Population: " + country?.Population + Environment.NewLine + "Region: " + country?.Region;
            
            pbFlag.Image = SvgToBitmap(country?.Flag);
            pbFlag.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private Bitmap SvgToBitmap(string text)
        {
            try
            {
                using (var stream = new MemoryStream(Encoding.UTF8.GetBytes((new WebClient()).DownloadString(text))))
                     return SvgDocument.Open<SvgDocument>(stream, null).Draw();
            }
            catch { return null; }
        }
    }
}
