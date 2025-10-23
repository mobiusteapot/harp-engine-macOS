namespace HarpEngine.Shapes;

public class PointShape : Entity, IIntersectsWithCircle, IIntersectsWithRectangle
{
	public Vector2 Position;
	public Color Color;

	public PointShape(Scene scene, Color color) : base(scene)
	{
		Color = color;
	}

	public bool IntersectsWithCircle(Vector2 circlePosition, float circleRadius) => Intersection.PointInCircle(Position, circlePosition, circleRadius);
	public bool IntersectsWithCircle(CircleShape circleShape) => Intersection.PointInCircle(Position, circleShape.Transform.WorldPosition, circleShape.Radius);
	public bool IntersectsWithRectangle(Rectangle rectangle) => Intersection.PointInRectangle(Position, rectangle);
	public bool IntersectsWithRectangle(RectangleShape rectangleShape) => Intersection.PointInRectangle(Position, rectangleShape.Rectangle);

	public override void Draw()
	{
		Primitives.DrawPixel(Position, Color);
	}
}
