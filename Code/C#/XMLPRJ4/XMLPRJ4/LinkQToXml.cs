using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XMLPRJ4
{
    public partial class LinkQToXml : Form
    {
        Dictionary<String, int> dictSpaceship = new Dictionary<string, int>();
        XElement data = null;
        public LinkQToXml()
        {
            InitializeComponent();
        }
        private void getTreeView()
        {

            int id = 0;
            XElement options = XElement.Load(Application.StartupPath + "\\Recursos\\Info.xml");
            treeView1.BeginUpdate();
            treeView1.Nodes.Add("SpaceShips");
            treeView1.EndUpdate();

            foreach (XElement item in options.Descendants("textOption"))
            {
                string spaceshipName = item.Value.ToString();
                treeView1.Nodes[0].Nodes.Add(spaceshipName);
                dictSpaceship.Add(spaceshipName, id);
                id++;
            }
            treeView1.EndUpdate();

        }
        private void btn_CarregarDades_Click(object sender, EventArgs e)
        {
            getTreeView();

        }

        private void InfoOption(int id = 2, string campo = "textOption", string identificador = "idOption", string padre = "InfoOption")
        {
            XElement doc = null;
            doc = XElement.Load(Application.StartupPath + "\\Recursos\\Info.xml");

            string alu = (from a in doc.Descendants(padre)
                          where (int)a.Element(identificador) == id
                          select a.Element(campo).Value).SingleOrDefault();
            MessageBox.Show(alu);

        }

        private void treeView1_TabIndexChanged(object sender, EventArgs e)
        {
            int id = dictSpaceship[treeView1.SelectedNode.ToString()];
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

            foreach (var item in dictSpaceship)
            {
                string nameSpaceships = item.Key;
                string searchkey = treeView1.SelectedNode.Text;
                if (nameSpaceships == searchkey)
                {
                    panel1.Visible = true;
                    getDescription(item.Value);
                    getimage(item.Value);
                    getData(item.Value);
                    foreach (Control ctr in panel1.Controls)
                    {
                        if (ctr.GetType() == typeof(Label))
                        {
                            if ((ctr.Tag.ToString() != null) && (ctr.Tag.ToString() != "icon"))
                            {
                                getInfoData(ctr, ctr.Tag.ToString());
                            }
                        }
                    }
                }
            }
        }

        private void getInfoData(Control lbl, string campo)
        {
            XElement doc = null;
            doc = data;

            foreach (XElement xEle in doc.Descendants(campo))
            {
                lbl.ForeColor = Color.Blue;
                lbl.Text = xEle.Value;
            }
        }

        private void getData(int id)
        {
            XElement doc = null;
            doc = XElement.Load(Application.StartupPath + "\\Recursos\\Info.xml");

            XElement alu = (from a in doc.Descendants("InfoDetail")
                            where (int)a.Element("idInfoDetail") == id
                            select a.Element("Data")).SingleOrDefault();
            data = alu;
        }

        private void getDescription(int id)
        {
            string identificador_texto = "idInfoDetail", padre_texto = "InfoDetail";
            lbl_Spaceship.ForeColor = Color.Blue;
            lbl_Spaceship.AutoSize = false;
            lbl_Spaceship.Font = new Font("Arial", 10, FontStyle.Regular);

            lbl_Spaceship.Text = XML(id, lbl_Spaceship.Tag.ToString(), identificador_texto, padre_texto);
        }

        private void getimage(int id)
        {
            string identificador = "idOption", padre = "InfoOption";
            string image;
            foreach (Control ctr in panel1.Controls)
            {
                if (ctr.GetType() == typeof(PictureBox))
                {
                    if (ctr.Tag.ToString() == "image")
                    {
                        image = XML(id, "icon", identificador, padre);
                        ((PictureBox)ctr).Image = Image.FromFile(Application.StartupPath + "\\Recursos\\Ships\\" + image);
                    }
                }
            }
        }

        private string XML(int id, string campo, string identificador, string padre)
        {
            XElement doc = null;
            doc = XElement.Load(Application.StartupPath + "\\Recursos\\Info.xml");

            string alu = (from a in doc.Descendants(padre)
                          where (int)a.Element(identificador) == id
                          select a.Element(campo).Value).SingleOrDefault();
            return alu;
        }
    }
}
