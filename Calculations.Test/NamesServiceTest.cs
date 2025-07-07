using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations.Test
{
    public class NamesServiceTest
    {
        [Fact]
        [Trait("Owner", "Daniel")]
        [Trait("Category", "NameService")]
        public void MakeFullName_GivenFirstNameAndLastName_StartWithFirstName()
        {
            //arrange
            var namesService = new NamesService();

            //act
            var res = namesService.MakeFullName("daniel","Vega");

            //assert
            Assert.StartsWith("Daniel Vega",res,StringComparison.CurrentCultureIgnoreCase);
        }

        [Fact]
        [Trait("Owner", "Daniel")]
        [Trait("Category", "NameService")]
        public void MakeFullName_GivenFirstNameAndLastName_ContainsFirstName()
        {
            //arrange
            var namesService = new NamesService();

            //act
            var res = namesService.MakeFullName("daniel", "vega");

            //assert
            Assert.Contains("Daniel Vega",res,StringComparison.CurrentCultureIgnoreCase);
        }

        [Fact]
        [Trait("Owner", "Daniel")]
        [Trait("Category", "NameService")]
        public void MakeFullName_GivenFirstNameAndLastName_RegexTest()
        {
            //arrange
            var namesService = new NamesService();

            //act
            var res = namesService.MakeFullName("Daniel", "Vega");

            //assert
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", res);
        }
    }
}
