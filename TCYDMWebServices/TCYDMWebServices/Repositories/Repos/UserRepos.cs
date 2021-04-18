﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCYDMWebServices.Data;
using TCYDMWebServices.DTO;
using TCYDMWebServices.Models;
using TCYDMWebServices.Repositories.Abstracts;

namespace TCYDMWebServices.Repositories.Repos
{
    public class UserRepos : ITransactions<UserDTO>
    {
        private readonly DatabaseContext _db;
        public UserRepos(DatabaseContext database)
        {
            _db = database;
        }
        public bool Add(UserDTO obj)
        {
            try
            {
                _db.users.Add(new User { 
                CountryId = obj.CountryId,
                Surname = obj.Surname,
                Email = obj.Email,
                Name = obj.Name,
                Password= obj.Password,
                PhoneNumber = obj.PhoneNumber,
                RegionId = obj.RegionId,
                TCNo = obj.TCNo,
                BornYear = obj.BornYear,
                SexId = obj.SexId,
                PKey = obj.PKey,
                Token = Guid.NewGuid().ToString()
                
                });

                _db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(UserDTO obj)
        {
            try
            {
                _db.users.Remove(new User
                {
                    Id = obj.Id,
                    Email = obj.Email,
                    CountryId = obj.CountryId,
                    Name = obj.Name,
                    Password = obj.Password,
                    PhoneNumber = obj.PhoneNumber,
                    RegionId = obj.RegionId,
                    Surname = obj.Surname,
                    TCNo = obj.TCNo,
                    PKey = obj.PKey
                });

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public UserDTO Get(int Id)
        {
            UserDTO mappeduser = new UserDTO();
            try
            {
                User user = _db.users.FirstOrDefault(c => c.Id == Id);

                mappeduser.Name = user.Name;
                mappeduser.Password = user.Password;
                mappeduser.PhoneNumber = user.PhoneNumber;
                mappeduser.RegionId = user.RegionId;
                mappeduser.Surname = user.Surname;
                mappeduser.TCNo = user.TCNo;
                mappeduser.PKey = user.PKey;

                return mappeduser;

            }
            catch (Exception)
            {
                return mappeduser;
            }


        }

        public List<UserDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(UserDTO obj, int Id)
        {
            try
            {
                User user =_db.users.Find(Id);
                user.CountryId = obj.CountryId;
                user.Email = obj.Email;
                user.Name = obj.Name;
                user.TCNo = obj.TCNo;
                user.Surname = obj.Surname;
                user.PhoneNumber = obj.PhoneNumber;
                user.RegionId = obj.RegionId;
                user.BornYear = obj.BornYear;
                user.SexId = obj.SexId;
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
