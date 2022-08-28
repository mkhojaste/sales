using Sales.Builder;
using Xunit;

namespace Sales.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            SalesUnit? node = new SalesUnitBuilder()
                .WithUnit(new SalesAgent())
                .WithGroup(unit =>
                    unit.GroupNamed("x")
                        .WithMembers(sales =>
                            sales
                            .WithUnit(new SalesAgent())))
                .Build();
            Assert.NotEqual(node, null);
        }
    }
}