namespace WorkSpace18._02._26.Models
{
    public class Automobile : Product
    {
        public string Color { get; set; }
        public int Volume { get; set; }
        public int Width { get; set; }
        public int Len { get; set; }
        public int Height { get; set; }
        public string Transmission { get; set; }
        public string Engine { get; set; }
        public string CarBody { get; set; }

        public override string ToString()
        {
            return $"Автомобиль {Brand}, цвет {Color}, двигатель {Engine}";
        }
    }
}
