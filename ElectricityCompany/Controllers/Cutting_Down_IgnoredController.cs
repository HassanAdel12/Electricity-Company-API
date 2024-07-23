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
    public class Cutting_Down_IgnoredController : ControllerBase
    {

        private readonly IUnitOfWork unitOfWork;

        private readonly IMapper mapper;

        public Cutting_Down_IgnoredController(IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            mapper = _mapper;
        }



        [HttpGet("{ID:int}")]
        public IActionResult GetByID(int ID)
        {
            Cutting_Down_Ignored cutting_Down_Ignored = unitOfWork.Cutting_Down_Ignoreds.GetById(ID);

            if (cutting_Down_Ignored == null)
            {
                return NotFound();
            }
            else
            {
                try
                {
                    return Ok(
                        mapper.Map<Cutting_Down_IgnoredDTO>
                        (cutting_Down_Ignored)
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
                    mapper.Map<IEnumerable<Cutting_Down_IgnoredDTO>>
                    (unitOfWork.Cutting_Down_Ignoreds.GetAll())
                    );
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }



        [HttpPost]
        public IActionResult Add(Cutting_Down_IgnoredDTO cutting_Down_IgnoredDTO)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    Cutting_Down_Ignored cutting_Down_Ignored =
                        unitOfWork.Cutting_Down_Ignoreds
                        .Add(mapper.Map<Cutting_Down_Ignored>(cutting_Down_IgnoredDTO));


                    unitOfWork.Complete();
                    return Ok(cutting_Down_Ignored);

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
        public IActionResult Update(Cutting_Down_IgnoredDTO cutting_Down_IgnoredDTO, int ID)
        {

            if (ModelState.IsValid)
            {

                Cutting_Down_Ignored oldCutting_Down_Ignored = unitOfWork.Cutting_Down_Ignoreds.GetById(ID);

                if (oldCutting_Down_Ignored != null)
                {
                    try
                    {
                        cutting_Down_IgnoredDTO.Cutting_Down_Incident_ID = ID;
                        mapper.Map(cutting_Down_IgnoredDTO, oldCutting_Down_Ignored);

                        Cutting_Down_Ignored cutting_Down_Ignored = unitOfWork.Cutting_Down_Ignoreds
                            .Update(oldCutting_Down_Ignored);

                        unitOfWork.Complete();

                        return Ok(cutting_Down_Ignored);


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

            Cutting_Down_Ignored cutting_Down_Ignored = unitOfWork.Cutting_Down_Ignoreds.GetById(ID);

            if (cutting_Down_Ignored != null)
            {
                try
                {

                    unitOfWork.Cutting_Down_Ignoreds.Delete(cutting_Down_Ignored);

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
