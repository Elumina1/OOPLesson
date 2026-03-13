namespace WorkSpace18._02._26.Models
{
    /// <summary>
    /// мобильный телефон
    /// </summary>
    public class SmartPhone : Product
    {
        public string Color { get; set; }
        public int Memory { get; set; }
        public int MPCamera { get; set; }
        public string OperatingSystem { get; set; }
        public string CPU { get; set; }
    }
}
