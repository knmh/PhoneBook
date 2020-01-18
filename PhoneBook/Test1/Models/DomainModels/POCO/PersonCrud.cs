using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test1.Models.DomainModels.DTO.EF;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;

namespace Test1.Models.DomainModels.POCO
{
  public  class PersonCrud
    {
        #region [-Ctor-]
        public PersonCrud()
        {

        }
        #endregion
        #region [-Prop-]
        public string ErrorMessage { get; private set; } 
        #endregion
        #region [-Tasks-]
        #region [-SelectAll()-]
        public List<DTO.EF.Person> SelectAll()
        {
            using (var context = new DTO.EF.Test1Entities1())
            {
                try
                {
                    var q = context.People.ToList();
                    return q;
                }
                catch (Exception ex)
                {
                    ErrorMessage = ex.Message + "==>" + ex.TargetSite;
                    throw;
                    //    ErrorMessage = ex.Message + "==>" + ex.TargetSite;
                    //    return ErrorMessage;
                }
                finally
                {
                    context.Dispose();
                }
            }

        }

        internal void Insert()
        {
            throw new NotImplementedException();
        }
        #endregion
        #region [-Insert-]
        /// <summary>
        /// Insert:ParameterBinding
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="telNumber1"></param>
        /// <param name="telNumber2"></param>
        /// <param name="homeAddress"></param>
        public void Insert(string fName, string lName, string phoneNumber, string telNumber1, string telNumber2, string homeAddress)
        {
            using (var context = new DTO.EF.Test1Entities1())
            {
                try
                {
                    var people = new DTO.EF.Person();

                    people.LName = lName;
                    people.FName = fName;
                    people.PhoneNumber = phoneNumber;
                    people.TelNumber1 = telNumber1;
                    people.TelNumber2 = telNumber2;
                    people.HomeAddress = homeAddress;
                    context.People.Add(people);
                    context.SaveChanges();
                }

                catch (DbEntityValidationException ex)
                {
                    Console.WriteLine(string.Format("DbEntityValidationException:{0}",ex.Message));
                    
                }

                catch (Exception ex)
                {
                    ErrorMessage = ex.Message + "==>" + ex.TargetSite;
                    throw;
                    //    ErrorMessage = ex.Message + "==>" + ex.TargetSite;
                    //    return ErrorMessage;
                }
                finally
                {
                    context.Dispose();
                }
            }

        }

        #endregion
        #region [-Update(Person Person)-]
        /// <summary>
        /// Update:Modelbinding
        /// </summary>
        /// <param name="Person"></param>
        public void Update(Person Person)
        {
            using (var context = new Test1Entities1())
            {
                try
                {

                    context.Entry(Person).State = EntityState.Modified;
                    context.SaveChanges();
                 

                }
                
                catch (DbUpdateConcurrencyException ex)
                {
   
                    Console.WriteLine(string.Format("DbUpdateConcurrencyError:{0}",ex.Message));
                   
                }
                catch  (Exception ex)
                {
                    ErrorMessage = ex.Message + "==>" + ex.TargetSite;
                    throw;
                    //    ErrorMessage = ex.Message + "==>" + ex.TargetSite;
                    //    return ErrorMessage;
                }
                finally
                {
                    context.Dispose();
                }
            }
        }
        #endregion
        #region [-Remove(Person Person)-]
        /// <summary>
        /// Update:Modelbinding
        /// </summary>
        /// <param name="Person"></param>
        public void Remove(Person Person)
        {
            using (var context = new Test1Entities1())
            {
                try
                {


                    context.Entry(Person).State = EntityState.Modified;
                    context.People.Remove(Person);
                    context.SaveChanges();

                }
                catch(DbUpdateConcurrencyException ex)
                {
                    Console.WriteLine(string.Format("DbUpdateConcurrencyError:{0}", ex.Message));
                }
                catch (Exception ex)
                {
                    ErrorMessage = ex.Message + "==>" + ex.TargetSite;
                    throw;
                    //    ErrorMessage = ex.Message + "==>" + ex.TargetSite;
                    //    return ErrorMessage;
                }
                finally
                {
                    context.Dispose();
                }
            }

        } 
        #endregion

        #endregion

    }
}
