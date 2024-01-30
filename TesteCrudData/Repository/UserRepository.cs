using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using TesteCrudModels.Models;
using Microsoft.EntityFrameworkCore;
using TesteCrudData.Interface;
using Microsoft.EntityFrameworkCore.Storage.Json;

namespace TesteCrudData.Repository
{
    public class UserRepository : IUserRepository
    {

        private readonly RepositoryContext _repositoryContext;

        public UserRepository(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public List<UserEntity> Get()
        {
            return _repositoryContext.Users.ToList();
        }
        public UserEntity GetById(int userId)
        {
            return _repositoryContext.Users.Where(x => x.Id == userId).Single();
        }
        public void Create(UserEntity user)
        {            
            _repositoryContext.Users.Add(user);
            _repositoryContext.SaveChanges();
        }
        public void Update(int userId,UserEntity user)
        {
          var userUpdated = _repositoryContext.Users.Where(x => x.Id == userId).Single();
            if (userUpdated != null)
                userUpdated = user;
            _repositoryContext.SaveChanges();
        }

        public void Delete(int userId)
        {
           _repositoryContext.Users.Where(x => x.Id == userId).ExecuteDelete();
           _repositoryContext.SaveChanges();

        }

        public UserEntity GetByCpf(string cpf)
        {
            return _repositoryContext.Users.Where(x => x.Cpf.Equals(cpf)).FirstOrDefault();
        }

        public void DeleteByCpf(string cpf)
        {
            _repositoryContext.Users.Where(x => x.Cpf.Equals(cpf)).ExecuteDelete();
            _repositoryContext.SaveChanges();
        }


        public void UpdateByCpf(string cpf, UserEntity user)
        {
            var userUpdated = _repositoryContext.Users.Where(x => x.Cpf == cpf).Single();
            user.Id = userUpdated.Id;
            _repositoryContext.Entry(userUpdated).CurrentValues.SetValues(user);

            _repositoryContext.SaveChanges();
        }

    }
}
