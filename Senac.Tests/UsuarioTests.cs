using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Senac.Tests

{
    [TestClass]
    public class UnitTest1

    {
        [TestMethod]
        [DataTestMethod]        
        [DataRow("")]        
        [DataRow(null)]        
        [DataRow(" ")]

        // public void Login_EmailSenhaCorretos(){
            public void VerificarNome_RetornoFalso(string value){

            Usuario usuario = new Usuario();

            // var resultado = usuario.Login("marcelo.petri@prof.sc.senac.br", "123456");

            var resultado = usuario.VerificarNome(value);
            // Assert.AreEqual("Usuário logado", resultado);
            // Assert.AreEqual("E-mail ou senha incorretos", resultado);
            //Assert.AreEqual("Preencha todos os dados!", resultado);

            Assert.IsFalse(resultado);

        }
    }
}