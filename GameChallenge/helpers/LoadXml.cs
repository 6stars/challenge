using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GameChallenge.helpers
{
    public static class GameFileHelper
    {

        public static void LoadXml(string fileName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlNodeList players = doc.SelectNodes("/root/players/player");
            foreach (XmlNode player in players)
            {
                string name = player.Attributes["name"].Value;
                foreach (XmlNode tile in player.ChildNodes)
                {
                    string code = tile.Attributes["terrain"].Value;
                    int cost = Int32.Parse(tile.Attributes["cost"].Value);
                }
            }
            XmlNodeList rows = doc.SelectNodes("/root/map/row");
            foreach (XmlNode row in rows)
            {
                string mapTiles = row.InnerText;
            }
        }
    }
}
