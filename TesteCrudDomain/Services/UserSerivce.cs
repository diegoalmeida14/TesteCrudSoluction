using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteCrudData.Interface;
using TesteCrudData.Repository;
using TesteCrudDomain.Interface;
using TesteCrudModels.Models;

namespace TesteCrudDomain.Services
{
    public class UserSerivce: IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserSerivce(IUserRepository userRepository, IMapper mapper)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        
        }

        public List<UserView> Get()
        {
            var usersEntity = _userRepository.Get(); 
            
            return _mapper.Map<List<UserView>>(usersEntity);
        }
        public UserView GetById(int userId)
        {
            var userView = _userRepository.GetById(userId);
            return _mapper.Map<UserView>(userView);
        }
        public void Create(UserView userView)
        {
            var useExists = _userRepository.GetByCpf(userView.Cpf);
            if (useExists != null)
                throw new Exception("usuário já criado");
            var userEntity = _mapper.Map<UserEntity>(userView);
            _userRepository.Create(userEntity);
        }
        public void Delete(int userId)
        {
            _userRepository.Delete(userId);
        }
        public void Update(int userId, UserView userView)
        {
            var userEntity = _mapper.Map<UserEntity>(userView);
            _userRepository.Update(userId, userEntity);
        }
        public UserView GetByCpf(string cpf)
        { 
            var userView = _userRepository.GetByCpf(cpf);
            return _mapper.Map<UserView>(userView);
        }
        public void DeleteByCpf(string cpf)
        {
            _userRepository.DeleteByCpf(cpf);
        }
        public void UpdateByCpf(string cpf, UserView userView)
        {
            var userEntity = _mapper.Map<UserEntity>(userView);

            var useExists = _userRepository.GetByCpf(userView.Cpf);
            if (useExists != null && userEntity.Cpf != cpf)
                throw new Exception("não é possivel alterar para este cpf selecionado");

            _userRepository.UpdateByCpf(cpf, userEntity);
        }
    }
}
