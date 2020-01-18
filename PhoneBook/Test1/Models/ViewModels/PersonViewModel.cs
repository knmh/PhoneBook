using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.Models.ViewModels
{
    public class PersonViewModel
    {

        #region [-Ctor-]
        public PersonViewModel()
        {
            Ref_PersonCrud = new DomainModels.POCO.PersonCrud();

        }
        #endregion
        #region [- Props -]
        public DomainModels.POCO.PersonCrud Ref_PersonCrud { get; set; }
        public DomainModels.DTO.EF.Person Person { get; private set; }


        #endregion
        #region [- FillGrid() -]
        public dynamic FillGrid()
        {
            return Ref_PersonCrud.SelectAll();

        }

        #endregion
        #region [-Save(fName, lName, phoneNumber, telNumber1, telNumber2, homeAddress)-]
        public void Save(string fName, string lName, string phoneNumber, string telNumber1, string telNumber2, string homeAddress)
        {
            Ref_PersonCrud.Insert(fName, lName, phoneNumber, telNumber1, telNumber2, homeAddress);
        }

        internal object Save(string text1, string text2, string text3, string text4, string text5)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region [-Edit(int id, string fName, string lName, string phoneNumber, string telNumber1, string telNumber2, string homeAddress)-]
        
        public void Edit(int id, string fName, string lName, string phoneNumber, string telNumber1, string telNumber2, string homeAddress)
        {
            Person = new DomainModels.DTO.EF.Person()
            {
                Id = id,
                FName = fName,
                LName = lName,
                PhoneNumber = phoneNumber,
                TelNumber1 = telNumber1,
                TelNumber2 = telNumber2,
                HomeAddress = homeAddress,
            };
            Ref_PersonCrud.Update(Person);
        }

        #endregion
        #region [-Delete(int id, string fName, string lName, string phoneNumber, string telNumber1, string telNumber2, string homeAddress)-]
        public void Delete(int id, string fName, string lName, string phoneNumber, string telNumber1, string telNumber2, string homeAddress)
        {
            Person = new DomainModels.DTO.EF.Person()
            {
                Id = id,
                FName = fName,
                LName = lName,
                PhoneNumber = phoneNumber,
                TelNumber1 = telNumber1,
                TelNumber2 = telNumber2,
                HomeAddress = homeAddress,
            };
            Ref_PersonCrud.Remove(Person);
        } 
        #endregion

       
    }


 }
    


