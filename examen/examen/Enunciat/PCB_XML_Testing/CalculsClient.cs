using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PCB_XML_Testing
{
    class CalculsClient
    {
        XmlDocument doc = new XmlDocument();
        string filePath = "Vendes.xml";

        public CalculsClient()
        {
            doc.Load(filePath);
        }

        //Aquesta funció calcula el menor de un array de int
        private int valorMenor(int[] num)
        {
            int menor1;
            int pos;
            menor1 = num[0];
            pos = 0;
            for (int f = 1; f < 5; f++)
            {
                if (num[f] < menor1)
                {
                    menor1 = num[f];
                    pos = f;
                }
            }
            return menor1;
        }

        // cal recorrer totes les vendes i cada cop que la venda (posició dins la llista) 
        // sigui múltiple de 10 es comprova si la venda és del client escollit
        // si és així, s'acumula el import

        public int CalculaPremis(int client)
        {
            int contador = 1;
            int premi = 0;
            int cliente = 0;
            doc.Load(filePath);
            XmlNodeList selectedPlanetChilds = doc.SelectNodes("/VendesClient/Vendes/Venda");//[Client=\"" + client + "\"]/*");
            foreach (XmlNode item in selectedPlanetChilds)
            {
                XmlNode total = item.SelectSingleNode("Total");
                XmlNode clientes = item.SelectSingleNode("Client");
                cliente =Int32.Parse(clientes.InnerText);
                if (cliente == client)
                {
                    if (contador % 10 == 0)
                    {
                        premi += int.Parse(total.InnerText);
                    }
                }
                
                contador++;
            }
            return premi;
        }

        // es recorren les vendes del client seleccionat i es fan paquets de 5 en cinc.
        // Per a cada paquet complet de 5, es mira quin és el import menor.
        // Si l'import menor és menor o igual que 25 s'acumula directament el import, 
        // si el import és major de 25, s'acumula 25

        public int CalculaFidelitat(int client)
        {
            int contador = 0;
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            XmlNodeList selectedPlanetChilds = doc.SelectNodes("/VendesClient/Vendes/Venda[Client=\"" + client + "\"]/*");
            int[] precios = new int[5];
            int premifidelitat = 0;
            int totalPremi = 0;
            foreach (XmlNode node in selectedPlanetChilds)
            {
                if (contador < 5)
                {
                    if (node.LocalName == "Total")
                    {
                        if (int.Parse(node.InnerText) > 0)
                        {
                            precios[contador] = int.Parse(node.InnerText);
                            contador++;
                        }
                    }
                }
                else
                {
                    premifidelitat = valorMenor(precios);
                    if (premifidelitat >= 25)
                    {
                        totalPremi += 25;
                    }
                    else
                    {
                        totalPremi += premifidelitat;
                    }
                    contador = 0;
                }
            }
            return totalPremi;
        }

        // A partir de les dades passades en la List<int> es crea l'element ResumClient
        // i s'afegeix al final de l'element Vendes en el mateix fitxer vendes.xml

        public void GravaDades(List<int> valors)
        {
            XmlNodeList selectedPlanetChilds = doc.SelectNodes("/VendesClient");
            XmlNode root = doc.SelectSingleNode("VendesClient");
            XmlElement resum = doc.CreateElement("ResumClient"); ;
            XmlElement id = doc.CreateElement("IdClient");
            XmlElement totalClient = doc.CreateElement("TotalClient");
            XmlElement premiRegal = doc.CreateElement("PremiRegal");
            XmlElement premiFidelitat = doc.CreateElement("PremiFidelitat");
            int[] valores = valors.ToArray();
            id.InnerText = valores[0].ToString();
            totalClient.InnerText = valores[1].ToString();
            premiRegal.InnerText = valores[2].ToString();
            premiFidelitat.InnerText = valores[3].ToString();

            resum.AppendChild(id);
            resum.AppendChild(totalClient);
            resum.AppendChild(premiRegal);
            resum.AppendChild(premiFidelitat);
            root.AppendChild(resum);

            doc.Save(filePath);
        }

        // es recorren les vendes del client seleccionat i es van acumulant totes.

        public int CalculaTotal(int client)
        {
            int contadorPrecio = 0;
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            XmlNodeList selectedPlanetChilds = doc.SelectNodes("/VendesClient/Vendes/Venda[Client=\"" + client + "\"]/*");

            foreach (XmlNode node in selectedPlanetChilds)
            {
                if (node.LocalName == "Total")
                {
                    contadorPrecio += int.Parse(node.InnerText);
                }
            }
            return contadorPrecio;
        }
    }
}
