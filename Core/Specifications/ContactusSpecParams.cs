namespace Core.Specifications
{
    public class ContactusSpecParams
    {
        private const int MaxPageSize = 50;
        public int PageIndex { get; set; } = 1;

        private int _pageSize = 6;
        public int PageSize 
        {
            get => _pageSize;
            set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
        }

        public string Sort { get; set; }
        private string _name;

        public bool? Display {get; set;}
        public string Name
        {
            get => _name;
            set => _name = value.ToLower();
        }
    }
}