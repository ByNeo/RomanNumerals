using RomanNumerals.Core.Model;
using RomanNumerals.Core.Operation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace RomanNumerals.API.Controllers
{
    public class RomanNumeralsController : ApiController
    {
        #region [Fields]

        private RomanNums roman;

        #endregion


        #region [Constructors]

        public RomanNumeralsController()
        {
            roman = new RomanNums();
        }

        #endregion


        [HttpGet]
        public Result<string> Converter(int number)
        {
            var result = new Result<string>();
            try
            {
                result.Data = roman.Parse(number);
                result.IsSuccessful = true;
            }
            catch (Exception ex)
            {
                result.IsSuccessful = false;
                result.Message = ex.Message;
            }


            return result;
        }
    }
}