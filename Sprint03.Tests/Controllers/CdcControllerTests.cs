using Xunit;
using Moq;
using Sprint03.Presentation.Controllers;
using Sprint03.Services;
using Sprint03.Dtos;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sprint03.Tests.Controllers
{
    public class CdcControllerTests
    {
        [Fact]
        public async Task Get_DeveRetornarDadosComSucesso()
        {
            // Arrange
            var mockService = new Mock<CdcApiService>(new HttpClient());
            var dadosFalsos = new List<CdcDentalDto>
            {
                new CdcDentalDto { Year = "2020", Indicator = "Teste 1", DataValue = "45.0" },
                new CdcDentalDto { Year = "2021", Indicator = "Teste 2", DataValue = "50.0" }
            };

            mockService.Setup(s => s.ObterDadosDentaisAsync()).ReturnsAsync(dadosFalsos);

            var controller = new CdcController(mockService.Object);

            // Act
            var resultado = await controller.Get();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(resultado.Result);
            var retorno = Assert.IsAssignableFrom<List<CdcDentalDto>>(okResult.Value);
            Assert.Equal(2, retorno.Count);
        }
    }
}
