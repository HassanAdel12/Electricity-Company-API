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
    public class Cutting_Down_HeaderController : ControllerBase
    {

        private readonly IUnitOfWork unitOfWork;

        private readonly IMapper mapper;

        public Cutting_Down_HeaderController(IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            mapper = _mapper;
        }



        [HttpGet("{ID:int}")]
        public IActionResult GetByID(int ID)
        {
            Cutting_Down_Header cutting_Down_Header = unitOfWork.Cutting_Down_Headers.GetById(ID);

            if (cutting_Down_Header == null)
            {
                return NotFound();
            }
            else
            {
                try
                {
                    return Ok(
                        mapper.Map<Cutting_Down_HeaderDTO>
                        (cutting_Down_Header)
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
                    mapper.Map<IEnumerable<Cutting_Down_HeaderDTO>>
                    (unitOfWork.Cutting_Down_Headers.GetAll())
                    );
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }



        [HttpPost]
        public IActionResult Add(Cutting_Down_HeaderDTO cutting_Down_HeaderDTO)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    Cutting_Down_Header cutting_Down_Header =
                        unitOfWork.Cutting_Down_Headers
                        .Add(mapper.Map<Cutting_Down_Header>(cutting_Down_HeaderDTO));


                    unitOfWork.Complete();
                    return Ok(cutting_Down_Header);

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
        public IActionResult Update(Cutting_Down_HeaderDTO cutting_Down_HeaderDTO, int ID)
        {

            if (ModelState.IsValid)
            {

                Cutting_Down_Header oldCutting_Down_Header = unitOfWork.Cutting_Down_Headers.GetById(ID);

                if (oldCutting_Down_Header != null)
                {
                    try
                    {
                        cutting_Down_HeaderDTO.Cutting_Down_Key = ID;
                        mapper.Map(cutting_Down_HeaderDTO, oldCutting_Down_Header);

                        Cutting_Down_Header cutting_Down_Header = unitOfWork.Cutting_Down_Headers
                            .Update(oldCutting_Down_Header);

                        unitOfWork.Complete();

                        return Ok(cutting_Down_Header);


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

            Cutting_Down_Header cutting_Down_Header = unitOfWork.Cutting_Down_Headers.GetById(ID);

            if (cutting_Down_Header != null)
            {
                try
                {

                    unitOfWork.Cutting_Down_Headers.Delete(cutting_Down_Header);

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
