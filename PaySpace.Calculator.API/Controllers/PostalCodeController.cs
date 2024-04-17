

using Microsoft.AspNetCore.Mvc;
using PaySpace.Calculator.Data.Models;
using PaySpace.Calculator.Services.Abstractions;

namespace PaySpace.Calculator.Web.Controllers;
public class PostalCodeController(IPostalCodeService postalCodeService, ILogger<PostalCodeController> logger) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<PostalCode>>> PostalCodes()
    {
        try
        {
            var postalCodes = await postalCodeService.GetPostalCodesAsync();

            return this.Ok(postalCodes);
        }
        catch (Exception e)
        {
            logger.LogError(e, e.Message);

            return this.BadRequest(e.Message);
        }
    }
}