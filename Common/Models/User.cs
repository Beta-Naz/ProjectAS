namespace Common.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Player";
        public float Speed { get; set; } = 1f;
        public Map Map { get; set; }
        public Vector2 Position { get; set; } = new Vector2(0, 0);
        public Vector2 Rotation { get; set; } = new Vector2(0, 0);
    }
}
