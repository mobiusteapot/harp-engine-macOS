namespace HarpEngine.Shapes;

public class PointShape : Entity, IIntersectsWithCircle, IIntersectsWithRectangle, IIntersectsWithLine
{
	public Vector2 Position;
	public Color Color;

	public PointShape(Scene scene, Color color) : base(scene)
	{
		Color = color;
	}

	public override void Draw()
	{
		Primitives.DrawPixel(Position, Color);
	}

	public bool IntersectsWithCircle(Vector2 circlePosition, float circleRadius) => Intersection.PointInCircle(Position, circlePosition, circleRadius);
	public bool IntersectsWithRectangle(Rectangle rectangle) => Intersection.PointInRectangle(Position, rectangle);
	public bool IntersectsWithLine(Vector2 lineStartPosition, Vector2 lineEndPosition) => Intersection.PointOnLine(Position, lineStartPosition, lineEndPosition, 0.1f);
}
