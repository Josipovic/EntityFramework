using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    //entity framework-object relational mapper
    //ORM-alat za spremanje podataka iz objekata domene u relacijske baze podataka(MSSQL)
    //na utomatiziran nacin,bez puno potrebe za programiranjem
    //nadogradnja na ADO-net
    //automatizira standardne CRUD operacije(create,read,update,delete)

        //nuget

        //upute za rad sa ef
        //sa nugetom skinut ef
        //dodati context klasu (MyContext)
        //naslijediti iz  klase DbContext
        //kreirati klase sa podacima koje zelimo spremati u bazu
        //dodati u kontekst klasu propertie
        //Dbset<klasa>naziv_propertia
    class Program
    {
        static void Main(string[] args)
        {

            OurContext db = new OurContext();

            foreach (var u in db.Ucenici) {

                Console.WriteLine(u.Id + " " + u.Ime + " " + u.Prezime + " " + 
                    u.Godine + " " + u.Email);
            }

            Console.Read();
        }
    }
}
