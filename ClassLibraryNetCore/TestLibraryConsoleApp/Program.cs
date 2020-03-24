using ClassLibraryNetCore;
using ClassLibraryNetCore.ManyToMany;
using ClassLibraryNetCore.ManyToMany_With_Suplimentar_Info;
using ClassLibraryNetCore.OneToMany;
using System;

namespace TestLibraryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //TryPersonsContext();
            TryOneToManyContext();
            //TryManyToManyContext();

            //Many To Many Relationship with  suplimentar info
           //TryDoctorPacientContext();
        }

        static void TryOneToManyContext()
        {
            using(var context = new OneToManyContext())
            {
                Customer customer1 = new Customer()
                {
                    City = "Iasi",
                    Name = "Marian"
                };

                Order order1 = new Order()
                {
                    Date = DateTime.Now,
                    TotalValue = 27.9m,
                    Customer = customer1
                };

                Order order2 = new Order()
                {
                    Date = DateTime.Now,
                    TotalValue = 99.9m,
                    Customer = customer1
                };

                context.Customers.Add(customer1);
                context.Orders.Add(order1);
                context.Orders.Add(order2);
                context.SaveChanges();

                foreach(var customer in context.Customers)
                {
                    Console.WriteLine($"Name: {customer.Name} City: {customer.City}");

                    foreach (var order in customer.Orders)
                        Console.WriteLine($"Date: {order.Date}, Value: {order.TotalValue}");
                }
            }
        }

        static void TryManyToManyContext()
        {
            using (var context = new ManyToManyContext())
            {
                Artist artist1 = new Artist()
                {
                    FirstName = "Mihai",
                    LastName = "Luca",
                };

                Album album1 = new Album
                {
                    Name = "Blue Flower",
                    Date = DateTime.Now
                };
                AlbumArtist albumArtist1 = new AlbumArtist
                {
                   Album = album1,
                   Artist = artist1
                };

                context.Artists.Add(artist1);
                context.Albums.Add(album1);
                context.AlbumArtists.Add(albumArtist1);
                context.SaveChanges();

                foreach(var artist in context.Artists)
                {
                    Console.WriteLine($"Name:{artist.FirstName} {artist.LastName}");

                    foreach (var albumArtist in artist.AlbumArtists)
                        Console.WriteLine($"Name: {albumArtist.Album.Name} Date: {albumArtist.Album.Date}");
                }
            } 
        }

        static void TryDoctorPacientContext()
        {
            using(var context = new DoctorPacientContext())
            {
                Doctor doctor = new Doctor()
                {
                    FirstName = "Alexandru",
                    LastName = "Popovici",
                    Specialty = "pediatrie"
                };

                Pacient pacient = new Pacient()
                {
                    FirstName = "Cristi",
                    LastName = "Oniga",
                    Age = 50
                };

                DoctorPacient doctorPacient = new DoctorPacient()
                {
                    StartDate = DateTime.Now,
                    Doctor = doctor,
                    Pacient = pacient
                };

                context.Doctors.Add(doctor);
                context.Pacients.Add(pacient);
                context.DoctorPacients.Add(doctorPacient);
                context.SaveChanges();

                foreach(var currentDoctor in context.Doctors)
                {
                    Console.WriteLine(doctor);
                    foreach (var currentDoctorPacient in currentDoctor.DoctorPacients)
                        Console.WriteLine(currentDoctorPacient.Pacient + $"Date: {currentDoctorPacient.StartDate}");
                }
            }
        }

        static void TryPersonsContext()
        {
            using (var context = new PersonsContext())
            {
                var person1 = new Person
                {
                    FirstName = "Alexandra",
                    MiddleName = "Ioana",
                    LastName = "Ghidersa",
                    TelephoneNumber = "0789369548"
                };
                var person2 = new Person
                {
                    FirstName = "Ana",
                    MiddleName = "Maria",
                    LastName = "Popescu",
                    TelephoneNumber = "0789309549"
                };
                context.People.AddRange(new Person[] { person1, person2 });
                context.SaveChanges();
                foreach (var person in context.People)
                {
                    Console.WriteLine(person);
                }
            }
        }
    }
}
