using Sprint03.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint03.Tests.Services
{
    public class CdcApiServiceTests
    {
        [Fact]
        public async Task ObterDadosDentaisAsync_DeveRetornarListaComDados()
        {
            // Arrange
            var httpClient = new HttpClient();
            var service = new CdcApiService(httpClient);

            // Act
            var resultado = await service.ObterDadosDentaisAsync();

            // Assert
            Assert.NotNull(resultado);
            Assert.NotEmpty(resultado); // Pode falhar se a API estiver fora do ar
        }
    }
}