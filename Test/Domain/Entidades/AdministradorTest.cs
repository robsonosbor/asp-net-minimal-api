using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public sealed class AdministradorTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        //Arrange
        var adm = new Administrador();

        //Act
        adm.Id = 1;
        adm.Email = "test@teste.com";
        adm.Senha = "teste";
        adm.Perfil = "perfil";

        //Assert
        Assert.AreEqual(1, adm.Id);
        Assert.AreEqual("test@teste.com", adm.Email);
        Assert.AreEqual("teste", adm.Senha);
        Assert.AreEqual("perfil", adm.Perfil);
    }
}
