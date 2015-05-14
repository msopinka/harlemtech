using HarlemTech.DataAccess.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarlemTech.DataAccess.Interfaces
{
    public interface IUmbracoRepository
    {
        Task<List<HarlemPOI>> GetAllPOIs();
        Task<List<HarlemImage>> GetAllImageData();
    }
}
