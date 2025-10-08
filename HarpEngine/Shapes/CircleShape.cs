namespace HarpEngine.Shapes;

public class CircleShape : Entity
{
	public Transform2D Transform = new();
	public float Radius;
	public Color Color;

	public CircleShape(Scene scene, float radius, Color color) : base(scene)
	{
		Radius = radius;
		Color = color;
	}

	public override void Draw()
	{
		Primitives.DrawCircle(Transform.WorldPosition, Radius, Color);
	}

	public bool CollidesWithPoint(Vector2 position) => Collision.PointInCircleSquared(position, Transform.WorldPosition, Radius * Radius);
	public bool CollidesWithCircle(Vector2 position, float radius) => Collision.CircleOnCircleSquared(Transform.WorldPosition, Radius * Radius, position, radius * radius);
	public bool CollidesWithCircle(CircleShape circleShape) => Collision.CircleOnCircleSquared(Transform.WorldPosition, Radius * Radius, circleShape.Transform.WorldPosition, circleShape.Radius * circleShape.Radius);
}
