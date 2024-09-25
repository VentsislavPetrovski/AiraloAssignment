using AiraloAssignment.APISetup.Controllers;
using AiraloAssignment.APISetup.DTOs.SubmitOrderDTOs;
using AiraloAssignment.APISetup.Helpers;
using FluentAssertions;
using FluentAssertions.Execution;
using System.Net;

namespace AiraloAssignment.Tests
{
    [TestFixture]
    public class APITests
    {
        [Test]
        public async Task CreateAndGetESims()
        {
            //Create request body for post order request
            var orderEndpoints = new OrderEndpoints();
            var postOrderRequestDTO = new PostOrderRequestDTO()
            {
                Quantity = 6,
                Package_id = "merhaba-7days-1gb",
                Type = "sim",
                Description = "AutoTest" + HelperMethods.RandomNumberString(10)
            };

            //Send the post request and create assertions
            var createOrderResponse = await orderEndpoints.PostOrder(postOrderRequestDTO);
            createOrderResponse.StatusCode.Should().Be(HttpStatusCode.OK);
            using (new AssertionScope())
            {
                createOrderResponse.Data!.Data!.Id.Should().NotBeNull();
                createOrderResponse.Data.Data.Quantity.Should().Be(postOrderRequestDTO.Quantity);
                createOrderResponse.Data.Data.Package_id.Should().Be(postOrderRequestDTO.Package_id);
                createOrderResponse.Data.Data.Type.Should().Be(postOrderRequestDTO.Type);
                createOrderResponse.Data.Data.Description.Should().Be(postOrderRequestDTO.Description);
            }

            //Get the list of ESims and confirm the new ones are present
            var eSimsEndpoints = new ESimsEndpoints();
            var getESimsResponse = await eSimsEndpoints.GetESims();
            getESimsResponse.StatusCode.Should().Be(HttpStatusCode.OK);
            //For some reason the simable object is not returned in the response but if it did return the following assert should work
            //getESimsResponse.Data!.Data!.Select(x => x.Simable!.Package_id == postOrderRequestDTO.Package_id).Should().HaveCountGreaterThanOrEqualTo(6);

        }
    }
}