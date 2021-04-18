using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCYDMWebServices.Data;
using TCYDMWebServices.DTO;
using TCYDMWebServices.Models;
using TCYDMWebServices.Repositories.Abstracts;

namespace TCYDMWebServices.Repositories.Repos
{
    public class WhoWeAreRepos:ITransactions<WhoWeAreDTO>
    {
        private readonly DatabaseContext _db;
        public WhoWeAreRepos(DatabaseContext db)
        {
            _db = db;
        }

        public bool Add(WhoWeAreDTO obj)
        {
            try
            {

                WhoWeAre data = new WhoWeAre
                {
                    Id = obj.Id,
                    Content = obj.Content,
                    LanguageId = obj.LanguageId
                };
                _db.whoweares.Add(data);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(WhoWeAreDTO obj)
        {
            try
            {
                WhoWeAre data = _db.whoweares.Find(obj.Id);
                _db.whoweares.Remove(data);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public WhoWeAreDTO Get(int Id)
        {
            try
            {
                WhoWeAre data = _db.whoweares.Find(Id);
                WhoWeAreDTO finaldata = new WhoWeAreDTO
                {
                    Id = data.Id,
                    Content = data.Content,
                    LanguageId = data.LanguageId
                };
                return finaldata;
            }
            catch (Exception)
            {
                return null;
            }

        }

        public List<WhoWeAreDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(WhoWeAreDTO obj, int Id)
        {
            try
            {
                WhoWeAre data = _db.whoweares.Find(Id);
                data.Content = obj.Content;
                data.LanguageId = obj.LanguageId;
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
