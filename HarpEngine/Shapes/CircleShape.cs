namespace HarpEngine.Shapes;

public class CircleShape : Entity, IIntersectsWithPoint, IIntersectsWithCircle, IIntersectsWithRectangle
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

	public bool IntersectsWithPoint(Vector2 position) => Intersection.PointInCircle(position, Transform.WorldPosition, Radius);

	public bool IntersectsWithCircle(Vector2 position, float radius) => Intersection.CircleOnCircle(Transform.WorldPosition, Radius, position, radius);
	public bool IntersectsWithCircle(CircleShape circleShape) => Intersection.CircleOnCircle(Transform.WorldPosition, Radius, circleShape.Transform.WorldPosition, circleShape.Radius);

	public bool IntersectsWithRectangle(Rectangle rectangle) => Intersection.CircleOnRectangle(Transform.WorldPosition, Radius, rectangle);
	public bool IntersectsWithRectangle(RectangleShape rectangleShape) => Intersection.CircleOnRectangle(Transform.WorldPosition, Radius, rectangleShape.Rectangle);
}
