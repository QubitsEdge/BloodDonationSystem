using BloodDonationSystem.Model;
using BloodDonationSystem.Repository;
using BloodDonationSystem.UnitOfWorkPatterns;
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
        
        
        //private readonly DonarRepository _donorRepository;

        public DonorController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet("{id}")]
        public ActionResult<Donar> GetById(Guid id)
        {
            Donar donor = _unitOfWork.Donar.GetByGuid(id);
            return donor;
        }

        [HttpGet]
        public ActionResult<List<Donar>> GetAll()
        {
            return _unitOfWork.Donar.GetAll();
        }

        [HttpPost]
        public void Add(Donar donar)
        {
            _unitOfWork.Donar.AddDonor(donar);
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
            _unitOfWork.Donar.UpdateDonor(donar);
        }

        [HttpDelete("{id}")]
        public void DeleteDonor(Guid id)
        {
            Donar donorToDelete = _unitOfWork.Donar.GetByGuid(id);
            _unitOfWork.Donar.RemoveDonor(donorToDelete);
        }

        [HttpGet("bloodgroup/{BloodGroup}", Name = "GetByBloodGroup")]
        public ActionResult<List<Donar>> GetDonarByBloodGroup(string BloodGroup)
        {
            List<Donar> donarList = _unitOfWork.Donar.GetDonarByBloodGroup(BloodGroup);
            return donarList;
        }
    }
}
