using AutoMapper;
using ElectricityCompany.Core.DTO.STA;
using ElectricityCompany.Core.Interfaces;
using ElectricityCompany.Core.Model.STA;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElectricityCompany.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Problem_TypeController : ControllerBase
    {


        private readonly IUnitOfWork unitOfWork;

        private readonly IMapper mapper;

        public Problem_TypeController(IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            mapper = _mapper;
        }



        [HttpGet("{ID:int}")]
        public IActionResult GetByID(int ID)
        {
            Problem_Type problem_Type = unitOfWork.Problem_Types.GetById(ID);

            if (problem_Type == null)
            {
                return NotFound();
            }
            else
            {
                try
                {
                    return Ok(
                        mapper.Map<Problem_TypeDTO>
                        (problem_Type)
                        );
                }
                catch (Exception ex)
                {
                    return BadRequest(ex);
                }

            }
        }



        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(
                    mapper.Map<IEnumerable<Problem_TypeDTO>>
                    (unitOfWork.Problem_Types.GetAll())
                    );
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }



        [HttpPost]
        public IActionResult Add(Problem_TypeDTO problem_TypeDTO)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    Problem_Type problem_Type =
                        unitOfWork.Problem_Types
                        .Add(mapper.Map<Problem_Type>(problem_TypeDTO));


                    unitOfWork.Complete();
                    return Ok(problem_Type);

                }
                catch (Exception ex)
                {
                    return BadRequest(ex);
                }

            }
            else
            {
                return BadRequest(ModelState);
            }
        }


        [HttpPut("{ID:int}")]
        public IActionResult Update(Problem_TypeDTO problem_TypeDTO, int ID)
        {

            if (ModelState.IsValid)
            {

                Problem_Type oldProblem_Type = unitOfWork.Problem_Types.GetById(ID);

                if (oldProblem_Type != null)
                {
                    try
                    {
                        problem_TypeDTO.Problem_Type_Key = ID;
                        mapper.Map(problem_TypeDTO, oldProblem_Type);

                        Problem_Type problem_Type = unitOfWork.Problem_Types
                            .Update(oldProblem_Type);

                        unitOfWork.Complete();

                        return Ok(problem_Type);


                    }
                    catch (Exception ex)
                    {
                        return BadRequest(ex);
                    }

                }
                else
                {
                    return NotFound();
                }

            }
            else
            {
                return BadRequest(ModelState);
            }
        }


        [HttpDelete("{ID:int}")]
        public IActionResult Delete(int ID)
        {

            Problem_Type problem_Type = unitOfWork.Problem_Types.GetById(ID);

            if (problem_Type != null)
            {
                try
                {

                    unitOfWork.Problem_Types.Delete(problem_Type);

                    unitOfWork.Complete();

                    return Ok();
                }
                catch (Exception ex)
                {
                    return BadRequest(ex);
                }

            }
            else
            {
                return NotFound();
            }


        }



    }
}
