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
        private readonly DonarRepository _donorRepository;

        public DonorController()
        {
            _donorRepository = new DonarRepository();
        }


        [HttpGet("{id}")]
        public ActionResult<Donar> GetById(Guid id)
        {
            Donar donor = _donorRepository.GetByGuid(id);
            return donor;
        }

        [HttpGet]
        public ActionResult<List<Donar>> GetAll()
        {
            return _donorRepository.GetAll();
        }

        [HttpPost]
        public void Add(Donar donar)
        {
            _donorRepository.AddDonor(donar);
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
        public void EditDonor(Donar donar)
        {
            Console.WriteLine(donar.DonarId);
            _donorRepository.UpdateDonor(donar);
        }

        [HttpDelete("{id}")]
        public void DeleteDonor(Guid id)
        {
            Donar donorToDelete = _donorRepository.GetByGuid(id);
            _donorRepository.RemoveDonor(donorToDelete);
        }

        [HttpGet("bloodgroup/{BloodGroup}", Name = "GetByBloodGroup")]
        public ActionResult<List<Donar>> GetDonarByBloodGroup(string BloodGroup)
        {
            List<Donar> donarList = _donorRepository.GetDonarByBloodGroup(BloodGroup);
            return donarList;
        }
    }
}
