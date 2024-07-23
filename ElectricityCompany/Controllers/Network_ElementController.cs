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
    public class Network_ElementController : ControllerBase
    {


        private readonly IUnitOfWork unitOfWork;

        private readonly IMapper mapper;

        public Network_ElementController(IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            mapper = _mapper;
        }



        [HttpGet("{ID:int}")]
        public IActionResult GetByID(int ID)
        {
            Network_Element network_Element = unitOfWork.Network_Elements.GetById(ID);

            if (network_Element == null)
            {
                return NotFound();
            }
            else
            {
                try
                {
                    return Ok(
                        mapper.Map<Network_ElementDTO>
                        (network_Element)
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
                    mapper.Map<IEnumerable<Network_ElementDTO>>
                    (unitOfWork.Network_Elements.GetAll())
                    );
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }



        [HttpPost]
        public IActionResult Add(Network_ElementDTO network_ElementDTO)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    Network_Element network_Element =
                        unitOfWork.Network_Elements
                        .Add(mapper.Map<Network_Element>(network_ElementDTO));


                    unitOfWork.Complete();
                    return Ok(network_Element);

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
        public IActionResult Update(Network_ElementDTO network_ElementDTO, int ID)
        {

            if (ModelState.IsValid)
            {

                Network_Element oldNetwork_Element = unitOfWork.Network_Elements.GetById(ID);

                if (oldNetwork_Element != null)
                {
                    try
                    {
                        network_ElementDTO.Network_Element_Key = ID;
                        mapper.Map(network_ElementDTO, oldNetwork_Element);

                        Network_Element network_Element = unitOfWork.Network_Elements
                            .Update(oldNetwork_Element);

                        unitOfWork.Complete();

                        return Ok(network_Element);


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

            Network_Element network_Element = unitOfWork.Network_Elements.GetById(ID);

            if (network_Element != null)
            {
                try
                {

                    unitOfWork.Network_Elements.Delete(network_Element);

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
