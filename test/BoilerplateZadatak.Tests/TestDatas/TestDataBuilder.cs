using BoilerplateZadatak.EntityFrameworkCore;

namespace BoilerplateZadatak.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly BoilerplateZadatakDbContext _context;

        public TestDataBuilder(BoilerplateZadatakDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}