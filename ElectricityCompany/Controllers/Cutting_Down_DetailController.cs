using AutoMapper;
using ElectricityCompany.Core.DTO.FTA;
using ElectricityCompany.Core.Interfaces;
using ElectricityCompany.Core.Model.FTA;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElectricityCompany.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Cutting_Down_DetailController : ControllerBase
    {

        private readonly IUnitOfWork unitOfWork;

        private readonly IMapper mapper;

        public Cutting_Down_DetailController(IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            mapper = _mapper;
        }



        [HttpGet("{ID:int}")]
        public IActionResult GetByID(int ID)
        {
            Cutting_Down_Detail cutting_Down_Detail = unitOfWork.Cutting_Down_Details.GetById(ID);

            if (cutting_Down_Detail == null)
            {
                return NotFound();
            }
            else
            {
                try
                {
                    return Ok(
                        mapper.Map<Cutting_Down_DetailDTO>
                        (cutting_Down_Detail)
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
                    mapper.Map<IEnumerable<Cutting_Down_DetailDTO>>
                    (unitOfWork.Cutting_Down_Details.GetAll())
                    );
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }



        [HttpPost]
        public IActionResult Add(Cutting_Down_DetailDTO cutting_Down_DetailDTO)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    Cutting_Down_Detail cutting_Down_Detail =
                        unitOfWork.Cutting_Down_Details
                        .Add(mapper.Map<Cutting_Down_Detail>(cutting_Down_DetailDTO));


                    unitOfWork.Complete();
                    return Ok(cutting_Down_Detail);

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
        public IActionResult Update(Cutting_Down_DetailDTO cutting_Down_DetailDTO, int ID)
        {

            if (ModelState.IsValid)
            {

                Cutting_Down_Detail oldCutting_Down_Detail = unitOfWork.Cutting_Down_Details.GetById(ID);

                if (oldCutting_Down_Detail != null)
                {
                    try
                    {
                        cutting_Down_DetailDTO.Cutting_Down_Detail_Key = ID;
                        mapper.Map(cutting_Down_DetailDTO, oldCutting_Down_Detail);

                        Cutting_Down_Detail cutting_Down_Detail = unitOfWork.Cutting_Down_Details
                            .Update(oldCutting_Down_Detail);

                        unitOfWork.Complete();

                        return Ok(cutting_Down_Detail);


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

            Cutting_Down_Detail cutting_Down_Detail = unitOfWork.Cutting_Down_Details.GetById(ID);

            if (cutting_Down_Detail != null)
            {
                try
                {

                    unitOfWork.Cutting_Down_Details.Delete(cutting_Down_Detail);

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
