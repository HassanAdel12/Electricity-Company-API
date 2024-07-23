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
    public class Cutting_Down_BController : ControllerBase
    {

        private readonly IUnitOfWork unitOfWork;

        private readonly IMapper mapper;

        public Cutting_Down_BController(IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            mapper = _mapper;
        }



        [HttpGet("{ID:int}")]
        public IActionResult GetByID(int ID)
        {
            Cutting_Down_B cutting_Down_B = unitOfWork.Cutting_Down_Bs.GetById(ID);

            if (cutting_Down_B == null)
            {
                return NotFound();
            }
            else
            {
                try
                {
                    return Ok(
                        mapper.Map<Cutting_Down_BDTO>
                        (cutting_Down_B)
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
                    mapper.Map<IEnumerable<Cutting_Down_BDTO>>
                    (unitOfWork.Cutting_Down_Bs.GetAll())
                    );
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }



        [HttpPost]
        public IActionResult Add(Cutting_Down_BDTO cutting_Down_BDTO)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    Cutting_Down_B cutting_Down_B =
                        unitOfWork.Cutting_Down_Bs
                        .Add(mapper.Map<Cutting_Down_B>(cutting_Down_BDTO));


                    unitOfWork.Complete();
                    return Ok(cutting_Down_B);

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
        public IActionResult Update(Cutting_Down_BDTO cutting_Down_BDTO, int ID)
        {

            if (ModelState.IsValid)
            {

                Cutting_Down_B oldCutting_Down_B = unitOfWork.Cutting_Down_Bs.GetById(ID);

                if (oldCutting_Down_B != null)
                {
                    try
                    {
                        cutting_Down_BDTO.Cutting_Down_B_Incident_ID = ID;
                        mapper.Map(cutting_Down_BDTO, oldCutting_Down_B);

                        Cutting_Down_B cutting_Down_B = unitOfWork.Cutting_Down_Bs
                            .Update(oldCutting_Down_B);

                        unitOfWork.Complete();

                        return Ok(cutting_Down_B);


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


        [HttpPut("{ID:int}")]
        public IActionResult CloseByID(int ID)
        {

            Cutting_Down_B oldCutting_Down_B = unitOfWork.Cutting_Down_Bs.GetById(ID);

            if (oldCutting_Down_B != null)
            {
                try
                {
                    oldCutting_Down_B.IsActive = false;
                    oldCutting_Down_B.EndDate = DateOnly.FromDateTime(DateTime.Now);

                    Cutting_Down_B cutting_Down_B = unitOfWork.Cutting_Down_Bs
                        .Update(oldCutting_Down_B);

                    unitOfWork.Complete();

                    return Ok(cutting_Down_B);


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



        [HttpPut]
        public IActionResult CloseAll()
        {

            IEnumerable<Cutting_Down_B> cutting_Down_Bs = unitOfWork.Cutting_Down_Bs.GetAll();


            try
            {

                foreach (var cutting_Down_B in cutting_Down_Bs)
                {

                    cutting_Down_B.IsActive = false;
                    cutting_Down_B.EndDate = DateOnly.FromDateTime(DateTime.Now);

                    unitOfWork.Cutting_Down_Bs
                    .Update(cutting_Down_B);

                }


                unitOfWork.Complete();

                return Ok();


            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }



        }




        [HttpDelete("{ID:int}")]
        public IActionResult Delete(int ID)
        {

            Cutting_Down_B cutting_Down_B = unitOfWork.Cutting_Down_Bs.GetById(ID);

            if (cutting_Down_B != null)
            {
                try
                {

                    unitOfWork.Cutting_Down_Bs.Delete(cutting_Down_B);

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
