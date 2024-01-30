using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteCrudModels.Models;

namespace TesteCrudDomain.Interface
{
    public interface IUserService
    {
        public List<UserView> Get();
        public UserView GetById(int userId);
        public UserView GetByCpf(string cpf);
        public void Create(UserView user);
        public void Update(int userId, UserView user);
        public void Delete(int userId);
        public void DeleteByCpf(string cpf);
        public void UpdateByCpf(string cpf, UserView user);
    }
}
