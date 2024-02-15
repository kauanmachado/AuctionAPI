using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NLWAuction.API.Communication.Requests;
using NLWAuction.API.Filters;
using NLWAuction.API.Services;
using NLWAuction.API.UseCases.Offers.CreateOffer;

namespace NLWAuction.API.Controllers;

[ServiceFilter(typeof(AuthenticationUserAttribute))]
public class OfferController : NLWAuctionBaseController
{
    [HttpPost]
    [Route("{itemId}")]
    public IActionResult CreateOffer(
        [FromRoute] int itemId,
        [FromBody] RequestCreateOfferJson request,
        [FromServices] CreateOfferUseCase UseCase
        )
    {
        var id = UseCase.Execute(itemId, request);
        return Created(string.Empty, id);
    }
}
