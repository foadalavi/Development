namespace HouseHunting.Model
{
    public class House
    {
        public int Id { get; set; }
        public string City { get; set; }= string.Empty;
        public float Price { get; set; }
        public int Rooms { get; set; }
        public int LivingArea { get; set; }
        public int PlotArea { get; set; }
    }
}
