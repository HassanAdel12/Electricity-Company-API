using AutoMapper;
using ElectricityCompany.Core.DTO.STA;
using ElectricityCompany.Core.Interfaces;
using ElectricityCompany.Core.Model.STA;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ElectricityCompany.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Cutting_Down_AController : ControllerBase
    {

        private readonly IUnitOfWork unitOfWork;

        private readonly IMapper mapper;

        public Cutting_Down_AController(IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            mapper = _mapper;
        }



        [HttpGet("{ID:int}")]
        public IActionResult GetByID(int ID)
        {
            Cutting_Down_A cutting_Down_A = unitOfWork.Cutting_Down_As.GetById(ID);

            if (cutting_Down_A == null)
            {
                return NotFound();
            }
            else
            {
                try
                {
                    return Ok(
                        mapper.Map<Cutting_Down_ADTO>
                        (cutting_Down_A)
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
                    mapper.Map<IEnumerable<Cutting_Down_ADTO>>
                    (unitOfWork.Cutting_Down_As.GetAll())
                    );
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }



        [HttpPost]
        public IActionResult Add(Cutting_Down_ADTO cutting_Down_ADTO)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    Cutting_Down_A cutting_Down_A = 
                        unitOfWork.Cutting_Down_As
                        .Add(mapper.Map<Cutting_Down_A>(cutting_Down_ADTO));


                    unitOfWork.Complete();
                    return Ok(cutting_Down_A);

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
        public IActionResult Update(Cutting_Down_ADTO cutting_Down_ADTO, int ID)
        {

            if (ModelState.IsValid)
            {

                Cutting_Down_A oldCutting_Down_A = unitOfWork.Cutting_Down_As.GetById(ID);

                if (oldCutting_Down_A != null)
                {
                    try
                    {
                        cutting_Down_ADTO.Cutting_Down_A_Incident_ID = ID;
                        mapper.Map(cutting_Down_ADTO, oldCutting_Down_A);

                        Cutting_Down_A cutting_Down_A = unitOfWork.Cutting_Down_As
                            .Update(oldCutting_Down_A);

                        unitOfWork.Complete();

                        return Ok(cutting_Down_A);


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

            Cutting_Down_A oldCutting_Down_A = unitOfWork.Cutting_Down_As.GetById(ID);

            if (oldCutting_Down_A != null)
            {
                try
                {
                    oldCutting_Down_A.IsActive = false;
                    oldCutting_Down_A.EndDate = DateOnly.FromDateTime(DateTime.Now);

                    Cutting_Down_A cutting_Down_A = unitOfWork.Cutting_Down_As
                        .Update(oldCutting_Down_A);

                    unitOfWork.Complete();

                    return Ok(cutting_Down_A);


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

            IEnumerable<Cutting_Down_A> cutting_Down_As = unitOfWork.Cutting_Down_As.GetAll();

            
            try
            {

                foreach (var cutting_Down_A in cutting_Down_As)
                {

                    cutting_Down_A.IsActive = false;
                    cutting_Down_A.EndDate = DateOnly.FromDateTime(DateTime.Now);


                    unitOfWork.Cutting_Down_As
                    .Update(cutting_Down_A);

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

            Cutting_Down_A cutting_Down_A = unitOfWork.Cutting_Down_As.GetById(ID);

            if (cutting_Down_A != null)
            {
                try
                {

                    unitOfWork.Cutting_Down_As.Delete(cutting_Down_A);

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
