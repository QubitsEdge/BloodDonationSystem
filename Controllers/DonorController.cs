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
        private readonly DonorRepository _donorRepository;

        public DonorController()
        {
            _donorRepository = new DonorRepository();
        }


        [HttpGet("{id}", Name = "GetById")]
        public ActionResult<Donor> GetById(Guid id)
        {
            Donor donor = _donorRepository.GetByGuid(id);
            return donor;
        }

        [HttpGet]
        public ActionResult<List<Donor>> GetAll()
        {
            return _donorRepository.GetAll();
        }

        [HttpPost]
        public void Add(Donor donor)
        {
            _donorRepository.AddDonor(donor);
        }

       /* [HttpGet("{id}")]
        public ActionResult<Donor> Edit(Guid id)
        {
            if (ModelState.IsValid)
            {
                Donor donorToUpdate = _donorRepository.GetByGuid(id);
                RedirectToAction("EditDonor", donorToUpdate);
            }

            return NotFound();
        }*/

        [HttpPut]
        public void EditDonor(Donor donor)
        {
            Console.WriteLine(donor.DonorID);
            _donorRepository.UpdateDonor(donor);
        }

        [HttpDelete("{id}")]
        public void DeleteDonor(Guid id)
        {
            Donor donorToDelete = _donorRepository.GetByGuid(id);
            _donorRepository.RemoveDonor(donorToDelete);
        }

        [HttpGet("bloodgroup/{BloodGroup}", Name = "GetByBloodGroup")]
        public ActionResult<List<Donor>> GetDonorsByBloodGroup(string BloodGroup)
        {
            List<Donor> donorsList = _donorRepository.GetDonorsByBloodGroup(BloodGroup);
            return donorsList;
        }
    }
}
