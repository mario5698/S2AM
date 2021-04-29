using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XMLPRJ4
{
    public partial class XmlDocumentForm : Form
    {
        XmlDocument xDoc = new XmlDocument();
        string ruta = Application.StartupPath + "\\Recursos\\DataBank.xml";
        public XmlDocumentForm()
        {
            InitializeComponent();
        }

        private void XmlDocument_Load(object sender, EventArgs e)
        {
            getNodes();
            cleanTextbox();
        }

        private void cleanTextbox()
        {
            lbl_filationText.Text = "";
            lbl_LatText.Text = "";
            lbl_longText.Text = "";
            lbl_nativesText.Text = "";
            lbl_planetText.Text = "";
            lbl_SectorText.Text = "";
            lbl_routesText.Text = "";

            lsb_routes.Visible = false;

            lbl_filiation.Text = "";
            lbl_lat.Text = "";
            lbl_long.Text = "";
            lbl_natives.Text = "";
            lbl_planet.Text = "";
            lbl_sector.Text = "";
        }
        private void getNodes()
        {
            xDoc.Load(ruta);
            XmlNode root = xDoc.DocumentElement;
            cbb_Category.Items.Add(" ");
            cbb_Category.SelectedItem = " ";
            foreach (XmlNode item in root)
            {
                cbb_Category.Items.Add(item.Name);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            cleanAndRenameColumns();
            XmlNodeList planetList = xDoc.GetElementsByTagName("planet");
            
            string routeNode = " ";
            string category = cbb_Category.SelectedItem.ToString();
            string value = cbb_search.SelectedItem.ToString();

            if (category == "filiations" && (value != " "))
            {
                routeNode="/SpaceData/planets/planet[filiation='" + value + "']";
            }
            else if (category == "regions" && value != " ")
            {
                routeNode="/SpaceData/planets/planet[contains(sector, '" + value + "')]";
            } 
            else if (category == "planets" && value != " ")
            {
                routeNode = "/SpaceData/planets/planet[name='" + value + "']";
            }
            else
            {
                routeNode = "/SpaceData/planets/planet";
            }

            planetList = xDoc.SelectNodes(routeNode);

            foreach (XmlNode planet in planetList)
            {
                if (planet.HasChildNodes)
                {
                    List<string> planetData = new List<string>();
                    foreach (XmlNode node in planet.ChildNodes) planetData.Add(node.InnerText);
                    dgv_Data.Rows.Add(planetData[0], planetData[1], planetData[2], planetData[5]);
                }
            }
        }

        private void cleanAndRenameColumns()
        {
            dgv_Data.Rows.Clear();
            dgv_Data.Columns.Clear();
            dgv_Data.Columns.Add("name", "Name");
            dgv_Data.Columns.Add("sector", "Sector");
            dgv_Data.Columns.Add("filiation", "Filiation");
            dgv_Data.Columns.Add("natives", "Natives");
        }

        private void cbb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categorySelected = cbb_Category.SelectedItem.ToString();
            cbb_search.Items.Clear();
            cbb_search.Items.Add(" ");
            cbb_search.SelectedItem = " ";
            getValues(categorySelected);
        }

        private void getValues(string category)
        {
            if (category == "filiations")
            {
                getFiliation();
            }
            else if (category == "regions")
            {
                getRegions();
            }
            else if (category == "planets")
            {
                getPlanets();
            }
        }

        private void getFiliation()
        {
            XmlNodeList filiationsList = xDoc.GetElementsByTagName("description");
            foreach (XmlNode filiation in filiationsList)
            {
                cbb_search.Items.Add(filiation.InnerText);
            }
        }

        private void getRegions()
        {
            XmlNodeList regionsList = xDoc.GetElementsByTagName("nameRegion");
            foreach (XmlNode region in regionsList)
            {
                cbb_search.Items.Add(region.InnerText.Replace("-", " "));
            }
        }
        private void getPlanets()
        {
            XmlNodeList planetsList = xDoc.GetElementsByTagName("name");
            foreach (XmlNode planet in planetsList)
            {
                cbb_search.Items.Add(planet.InnerText);
            }
        }

        private void dgv_Data_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            string selectedPlanet = "";
            lsb_routes.Visible = true;

            if (dgv_Data.Rows[e.RowIndex].Cells[0].Value != null)
            {
                selectedPlanet = dgv_Data.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            lsb_routes.Items.Clear();

            XmlNodeList selectedPlanetChilds = xDoc.SelectNodes("/SpaceData/planets/planet[name=\"" + selectedPlanet + "\"]/*");
            List<string> selectedPlanetData = new List<string>();
            foreach (XmlNode node in selectedPlanetChilds)
            {
                selectedPlanetData.Add(node.InnerText);
            }

            string imagePath = Application.StartupPath + "\\Recursos" + "\\planetes\\" + selectedPlanet + ".png";
            if (!File.Exists(@imagePath))
            {
                imagePath = imagePath.Replace(".png", ".jpg");
            }

            pictureBox1.Image = Image.FromFile(@imagePath);

            lbl_filationText.Text = "Filiation";
            lbl_LatText.Text = "Latitude";
            lbl_longText.Text = "Longitude";
            lbl_nativesText.Text = "Natives";
            lbl_planetText.Text = "Planet";
            lbl_SectorText.Text = "Sector";

            lbl_filiation.Text = selectedPlanetData[2]; ;
            lbl_lat.Text = selectedPlanetChilds[3].SelectSingleNode("lat").InnerText;
            lbl_long.Text = selectedPlanetChilds[3].SelectSingleNode("long").InnerText;
            lbl_natives.Text = selectedPlanetData[5];
            lbl_planet.Text = selectedPlanet;
            lbl_sector.Text = selectedPlanetData[1];

            XmlNodeList routes = selectedPlanetChilds[4].ChildNodes;
            foreach (XmlNode route in routes) lsb_routes.Items.Add(route.InnerText);
        }
    }
}
