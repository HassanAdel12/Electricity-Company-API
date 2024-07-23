using AutoMapper;
using ElectricityCompany.Core.DTO.FTA;
using ElectricityCompany.Core.DTO.STA;
using ElectricityCompany.Core.Interfaces;
using ElectricityCompany.Core.Model.FTA;
using ElectricityCompany.Core.Model.STA;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElectricityCompany.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ChannelController : ControllerBase
    {

        private readonly IUnitOfWork unitOfWork;

        private readonly IMapper mapper;

        public ChannelController(IUnitOfWork _unitOfWork, IMapper _mapper)
        {
            unitOfWork = _unitOfWork;
            mapper = _mapper;
        }



        [HttpGet("{ID:int}")]
        public IActionResult GetByID(int ID)
        {
            Channel channel = unitOfWork.Channels.GetById(ID);

            if (channel == null)
            {
                return NotFound();
            }
            else
            {
                try
                {
                    return Ok(
                        mapper.Map<ChannelDTO>
                        (channel)
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
                    mapper.Map<IEnumerable<ChannelDTO>>
                    (unitOfWork.Channels.GetAll())
                    );
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }



        [HttpPost]
        public IActionResult Add(ChannelDTO channelDTO)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    Channel channel =
                        unitOfWork.Channels
                        .Add(mapper.Map<Channel>(channelDTO));


                    unitOfWork.Complete();
                    return Ok(channel);

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
        public IActionResult Update(ChannelDTO channelDTO, int ID)
        {

            if (ModelState.IsValid)
            {

                Channel oldChannel = unitOfWork.Channels.GetById(ID);

                if (oldChannel != null)
                {
                    try
                    {
                        channelDTO.Channel_Key = ID;
                        mapper.Map(channelDTO, oldChannel);

                        Channel channel = unitOfWork.Channels
                            .Update(oldChannel);

                        unitOfWork.Complete();

                        return Ok(channel);


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

            Channel channel = unitOfWork.Channels.GetById(ID);

            if (channel != null)
            {
                try
                {

                    unitOfWork.Channels.Delete(channel);

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
