namespace Sales.Builder
{
    public class SalesGroupBuilder
    {
        private SalesGroup _salesGroup = null;
        public SalesGroupBuilder()
        {

        }
        public SalesGroupBuilder GroupNamed(string name)
        {
            _salesGroup ??= new SalesGroup();
            _salesGroup.GroupName = name;
            return this;
        }
        public SalesGroupBuilder WithMembers(Action<SalesUnitBuilder> salesUnit)
        {
            var builder = new SalesUnitBuilder();
            salesUnit(builder);

            (this._salesGroup ??= new SalesGroup()).Units.Add(builder.Build());
            return this;
        }
        public SalesGroup Build()
        {
            return _salesGroup;
        }
    }
}
