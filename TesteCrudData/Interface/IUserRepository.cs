using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteCrudData.Repository;
using TesteCrudModels.Models;

namespace TesteCrudData.Interface
{
    public interface IUserRepository
    {
        public List<UserEntity> Get();
        public UserEntity GetById(int userId);
        public void Create(UserEntity user);
        public void Update(int userId, UserEntity user);
        public void Delete(int userId);
        public UserEntity GetByCpf(string cpf);
        public void DeleteByCpf(string cpf);
        public void UpdateByCpf(string cpf, UserEntity user);
    }
}
