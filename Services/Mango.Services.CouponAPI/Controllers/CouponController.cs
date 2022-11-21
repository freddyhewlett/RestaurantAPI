using Mango.Services.CouponAPI.Models.Dto;
using Mango.Services.CouponAPI.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.CouponAPI.Controllers
{
    [ApiController]
    [Route("api/coupon")]
    public class CouponController : Controller
    {
        private readonly ICouponRepository _couponRepository;
        protected ResponseDto _responseDto;

        public CouponController(ICouponRepository couponRepository)
        {
            _couponRepository = couponRepository;
            _responseDto = new ResponseDto();
        }

        [HttpGet("{code}")]
        public async Task<object> GetDiscountForCode(string code)
        {
            try
            {
                CouponDto couponDto = await _couponRepository.GetCouponByCode(code);
                _responseDto.Result = couponDto;
            }
            catch (Exception ex)
            {
                _responseDto.IsSuccess = false;
                _responseDto.ErrorMessages = new List<string>() { ex.Message };
            }
            return _responseDto;
        }
    }
}
