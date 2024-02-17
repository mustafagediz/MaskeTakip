using System;
using Business.Abstract;
using Entities.Concrete;
//Sonar Cube
namespace Business.Concrete
{
	public class PttManager: ISupplierService
	{
		private IApplicantService _applicantService;

		public PttManager(IApplicantService applicantService)//Constructor
		{
			_applicantService = applicantService;
		}

		public void GiveMask(Person person)
		{
			if (_applicantService.CheckPerson(person))
			{
				Console.WriteLine(person.FirstName + " için maske verildi");
			}
			else
			{
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ");
            }
        }
	}
}

