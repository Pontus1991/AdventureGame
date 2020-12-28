using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebbBibliotek.Models;

namespace WebbBibliotek.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly Context _context;

        public AuthRepository(Context context)
        {
            _context = context;
        }

     

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public async Task<ServiceResponse<int>> Register(User user, string password)
        {
            ServiceResponse<int> response = new ServiceResponse<int>();
            if (await UserExists(user.Username))
            {
                response.Success = false;
                response.Message = "User already exists.";
                return response;
            }
            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            response.Data = user.UserId;
            return response;
        }

        public Task<ServiceResponse<string>> Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UserExists(string username)
        {
            if (await _context.Users.AnyAsync(x => x.Username.ToLower() == username.ToLower()))
            {
                return true;
            }
            return false;
        }



        //public async Task<ServiceResponse<int>> Register(User user, string password)
        //{
        //    ServiceResponse<int> response = new ServiceResponse<int>();
        //    if (await UserExists(user.Username))
        //    {
        //        response.Success = false;
        //        response.Message = "User already exists.";
        //        return response;
        //    }
        //    CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);
        //    user.PasswordHash = passwordHash;
        //    user.PasswordSalt = passwordSalt;
        //    await _context.Users.AddAsync(user);
        //    await _context.SaveChangesAsync();
        //    response.Data = user.UserId;
        //    return response;
        //}

        //private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        //{
        //    using (var hmac = new System.Security.Cryptography.HMACSHA512())
        //    {
        //        passwordSalt = hmac.Key;
        //        passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
        //    }
        //}

        //public async Task<bool> UserExists(string username)
        //{
        //    if (await _context.Users.AnyAsync(x => x.Username.ToLower() == username.ToLower()))
        //    {
        //        return true;
        //    }
        //    return false;
        //}



        //Task<ServiceResponse<string>> IAuthRepository.Login(string username, string password)
        //{
        //    throw new NotImplementedException();
        //}
    }

}
