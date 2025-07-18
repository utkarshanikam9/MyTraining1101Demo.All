using MyTraining1101Demo.EntityFrameworkCore;
using MyTraining1101Demo.Phone;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTraining1101Demo.Migrations.Seed.Host
{
    public class InitialPeopleAndPhoneCreator
    {
        private readonly MyTraining1101DemoDbContext _context;

        public InitialPeopleAndPhoneCreator(MyTraining1101DemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            //var douglas = _context.Persons.FirstOrDefault(p => p.EmailAddress == "douglas.adams@fortytwo.com");
            //if (douglas == null)
            //{
            //    _context.Persons.Add(
            //        new Person
            //        {
            //            Name = "Douglas",
            //            Surname = "Adams",
            //            EmailAddress = "douglas.adams@fortytwo.com",
            //            PersonPhones = new List<PersonPhone>
            //                        {
            //                        new PersonPhone {Type = PhoneType.Home, Number = "1112242"},
            //                        new PersonPhone {Type = PhoneType.Mobile, Number = "2223342"}
            //                        }
            //        });
            //}

            //var asimov = _context.Persons.FirstOrDefault(p => p.EmailAddress == "isaac.asimov@foundation.org");
            //if (asimov == null)
            //{
            //    _context.Persons.Add(
            //        new Person
            //        {
            //            Name = "Isaac",
            //            Surname = "Asimov",
            //            EmailAddress = "isaac.asimov@foundation.org",
            //            PersonPhones = new List<PersonPhone>
            //                        {
            //                        new PersonPhone {Type = PhoneType.Home, Number = "8889977"}
            //                        }
            //        });
            //}

            var radin = _context.Persons.FirstOrDefault(p => p.EmailAddress == "radin.asimov@foundation.org");
            if (radin == null)
            {
                _context.Persons.Add(
                    new Person
                    {
                        Name = "joko",
                        Surname = "radin",
                        EmailAddress = "radin.asimov@foundation.org",
                        PersonPhones = new List<PersonPhone>
                                    {
                                    new PersonPhone {Type = PhoneType.Home, Number = "3439977"}
                                    }
                    });
            }
        }
    }
}