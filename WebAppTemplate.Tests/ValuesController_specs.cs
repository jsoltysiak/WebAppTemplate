using WebAppTemplate.Controllers;
using Xunit;

namespace WebAppTemplate.Tests
{
    public class when_getting_value_by_id
    {
        [Fact]
        public void then_it_should_return_value()
        {
            var controller = new ValuesController();
            var result = controller.Get(1);
            Assert.Equal("value", result);
        }
    }
}
