using BloodDonationSystem.Model;
using BloodDonationSystem.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace BloodDonationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonorController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public DonorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }



        /*private readonly DonorRepository _donorRepository;

        public DonorController()
        {
            _donorRepository = new DonorRepository();
        }*/


        [HttpGet("{id}", Name = "GetById")]
        public ActionResult<Donor> GetById(Guid id)
        {
            Donor donor = _unitOfWork.donorRepository.GetByGuid(id);
            return donor;
        }

        [HttpGet]
        public ActionResult<List<Donor>> GetAllDonors()
        {
            return _unitOfWork.donorRepository.GetAllDonors();
        }

        [HttpPost]
        public void AddDonor(Donor donor)
        {
            _unitOfWork.donorRepository.AddDonor(donor);
        }

        [HttpPut]
        public void EditDonor(Donor donor)
        {
            Console.WriteLine(donor.DonorID);
            _unitOfWork.donorRepository.UpdateDonor(donor);
        }

        [HttpDelete("{id}")]
        public void DeleteDonor(Guid id)
        {
            Donor donorToDelete = _unitOfWork.donorRepository.GetByGuid(id);
            _unitOfWork.donorRepository.RemoveDonor(donorToDelete);
        }

        [HttpGet("bloodgroup/{BloodGroup}", Name = "GetByBloodGroup")]
        public ActionResult<List<Donor>> GetDonorsByBloodGroup(string BloodGroup)
        {
            List<Donor> donorsList = _unitOfWork.donorRepository.GetDonorsByBloodGroup(BloodGroup);
            return donorsList;
        }
    }
}
