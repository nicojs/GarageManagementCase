using Xunit;

namespace GarageManagementCase.Tests
{
    public class KlantRepositoryTest
    {
        [Fact]
        public void AddKlant_EmptyRepo_ShouldAddKlant()
        {
            var repo = new KlantRepository();
            var klant = new Klant("Jan", "Lange", new Adres("Koestraat", 1, "Rivierenland", "1234AB"), "123456789", "JanL@gmail.com");
            repo.AddKlant(klant);
            Assert.Contains(klant, repo.AllKlanten);
        }
    }
}