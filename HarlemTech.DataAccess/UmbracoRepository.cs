using HarlemTech.DataAccess.DB;
using HarlemTech.DataAccess.Helpers;
using HarlemTech.DataAccess.Interfaces;
using HarlemTech.DataAccess.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarlemTech.DataAccess
{
    public class UmbracoRepository : IUmbracoRepository
    {
        private string _connectionString;
        public UmbracoRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<List<HarlemPOI>> GetAllPOIs()
        {
            var results = new List<HarlemPOI>();

            try
            {
                await Task.Factory.StartNew(() =>
                {
                    using (var db = new DatabaseDataContext(_connectionString))
                    {
                        var data = db.cmsContentXmls.Where(c => c.xml.StartsWith("<Poi")).Select(c => c.xml);
                        foreach (string xml in data)
                        {
                            var poi = HarlemXmlReader.ParsePoi(xml);
                            results.Add(poi);
                        }
                    }
                });
            }
            catch(Exception ex)
            {
            }

            return results.OrderBy(p => p.Name).ToList();
        }

        public async Task<List<HarlemImage>> GetAllImageData()
        {
            var results = new List<HarlemImage>();

            try
            {
                await Task.Factory.StartNew(() =>
                {
                    using(var db = new DatabaseDataContext(_connectionString))
                    {
                        var data = db.cmsContentXmls.Where(c => c.xml.StartsWith("<Image")).Select(c => c.xml);
                        foreach(string xml in data)
                        {
                            var img = HarlemXmlReader.ParseImage(xml);
                            results.Add(img);
                        }
                    }
                });
            }
            catch(Exception ex)
            {
            }

            return results;
        }
    }
}
