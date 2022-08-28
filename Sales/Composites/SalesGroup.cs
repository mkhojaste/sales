namespace Sales
{
    public class SalesGroup : SalesUnit
    {
        public List<SalesUnit> Units { get; private set; }
        private string _name = string.Empty;
        public SalesGroup(List<SalesUnit> units)
        {
            Units = units;
        }
        public SalesGroup(params SalesUnit[] units):this(units?.ToList()) { }
        
        public string GroupName { get; set; }
        public override void PayCommission(int amount)
        {
            var eachShare = amount / Units.Count;
            Units.ForEach(unit => unit.PayCommission(eachShare));
        }
    }
}
