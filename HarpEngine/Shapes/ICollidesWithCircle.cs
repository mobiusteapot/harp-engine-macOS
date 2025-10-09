namespace HarpEngine.Shapes
{
	public interface ICollidesWithCircle
	{
		public bool CollidesWithCircle(Vector2 position, float radius);
		public bool CollidesWithCircle(CircleShape circleShape);
	}
}
