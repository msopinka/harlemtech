using HarlemTech.DataAccess.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HarlemTech.DataAccess.Helpers
{
    public class HarlemXmlReader
    {
        public static HarlemPOI ParsePoi(string xml)
        {
            var result = new HarlemPOI();

            try
            {
                var doc = new XmlDocument();
                doc.LoadXml(xml);

                var node = doc.DocumentElement.SelectSingleNode("name");
                result.Name = node.InnerText;

                result.Id = doc.DocumentElement.Attributes["id"].Value;

                node = doc.DocumentElement.SelectSingleNode("logo");
                result.Logo = node.InnerText;

                node = doc.DocumentElement.SelectSingleNode("description");
                result.Description = node.InnerText;

                node = doc.DocumentElement.SelectSingleNode("address");
                result.Address = node.InnerText;

                node = doc.DocumentElement.SelectSingleNode("website");
                result.Website = node.InnerText;

                node = doc.DocumentElement.SelectSingleNode("poiType");
                result.Type = node.InnerText;

                node = doc.DocumentElement.SelectSingleNode("mapIt");
                if (!string.IsNullOrEmpty(node.InnerText))
                {
                    string[] split = node.InnerText.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                    if (split.Length == 2)
                    {
                        result.Latitude = double.Parse(split[0]);
                        result.Longitude = double.Parse(split[1]);
                    }
                }
            }
            catch(Exception ex)
            {
            }

            return result;
        }

        public static HarlemImage ParseImage(string xml)
        {
            var img = new HarlemImage();

            try
            {
                var doc = new XmlDocument();
                doc.LoadXml(xml);

                img.Id = doc.DocumentElement.Attributes["id"].Value;

                var node = doc.DocumentElement.SelectSingleNode("umbracoFile");
                img.Url = node.InnerText;
            }
            catch(Exception ex)
            {
            }

            return img;
        }
    }
}
