using System;
using System.Linq;
using Dal.models;
using Dal.pgDB;
using Microsoft.EntityFrameworkCore.Storage;

// using System.Web.Extensions;
// using json.net;

namespace Dal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Aia from Pradise!");

            // add user
            IRepository<User> userRepo = new PgRepository<User>();
            User usr = new User()
            {
                Name = "ayman",
                Email = "ayman@mail.com"
            };
            userRepo.Add(usr);
            Console.WriteLine(usr.Id);

            // add sighted user and link it with the created user recently
            IRepository<Sighted> sightedRepo = new PgRepository<Sighted>();
            Sighted sighted = new Sighted()
            {
                UserId = usr.Id
            };
            sightedRepo.Add(sighted);
            Console.WriteLine(sighted.UserId);

            // update user
            User savedUser = userRepo.Find().First(p => p.Id == usr.Id);
            savedUser.Phone = "01111111";
            savedUser.Gender = Convert.ToByte('b');
            userRepo.Update();
            
            // remove user
            User userToDelete = userRepo.Find().First(p => p.Id == usr.Id);
            userRepo.Delete(userToDelete);

            // todo: add vehicle type
            IRepository<VehicleType> VehicleTypeRepo = new PgRepository<VehicleType>();
            VehicleType vtr = new VehicleType()
            {
                Type = "Hatchback"
                
            };
            VehicleTypeRepo.Add(vtr);
            Console.WriteLine(vtr.Id);

            // todo: add a new user with the newely created vehicle type
            IRepository<User> userRepo2 = new PgRepository<User>();
            User user2 = new User()
            {
                Id = vtr.Id
            };
            userRepo2.Add(user2);
            Console.WriteLine(user2.Id);
            // todo: change vehicle type name
            VehicleType savedVehicleType = VehicleTypeRepo.Find().First(p => p.Id == vtr.Id);
            savedVehicleType.Type= "Convertible";
            VehicleTypeRepo.Update();
            // todo: remove the created vehicle 
            VehicleType vehicleToDelete = VehicleTypeRepo.Find().First(p => p.Id == vtr.Id);
            VehicleTypeRepo.Delete(vehicleToDelete);
        }
    }
}