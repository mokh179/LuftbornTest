using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace Luftborn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public DepartmentsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork=unitOfWork;
        }
        [HttpGet("AllDepartments")]
        public IActionResult GetAll()
         {
           if(!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(_unitOfWork.Departments.findAll(x=>x.Isdeleted==false));
        }

        [HttpGet("Department/{id}")]
        public IActionResult GetById(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(_unitOfWork.Departments.GetByID(id));
        }

        [HttpPost("AddDepartment")]
        public IActionResult AddDepartment(Department dept)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _unitOfWork.Departments.AddOne(dept);
            _unitOfWork.complete();
            return Ok();
        }

        [HttpPut("EditDepartment")]
        public IActionResult EditDepartment(Department dept)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _unitOfWork.Departments.Update(dept);
            _unitOfWork.complete();
            return Ok();
        }

       // [HttpDelete("Remove")]
       // I Use Post To send all Object to Delete and Put Can be used to make A SoftDelete 
       [HttpPost("Remove")]
        public IActionResult RemoveDepartment(Department dept)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            _unitOfWork.Departments.Delete(dept);
            _unitOfWork.complete();
            return Ok();
        }

    }
}
