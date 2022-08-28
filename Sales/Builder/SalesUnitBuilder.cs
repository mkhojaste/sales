namespace Sales.Builder
{
    public class SalesUnitBuilder
    {
        private SalesUnit? _salesUnit = null;
        private List<SalesUnit> salesUnits = new List<SalesUnit>();
        public SalesUnitBuilder WithUnit(SalesUnit salesUnit)
        {
            _salesUnit = salesUnit;
            salesUnits.Add(_salesUnit);
            return this;
        }

        public SalesUnit? Build()
        {
            return salesUnits.Count==1?_salesUnit:new SalesGroup(salesUnits);
        }

        public SalesUnitBuilder WithGroup(Action<SalesGroupBuilder> salesGroupUnit)
        {
            var builder = new SalesGroupBuilder();
            salesGroupUnit(builder);
            _salesUnit = builder.Build();
            salesUnits.Add(_salesUnit);
            return this;
        }
        
    }
}
