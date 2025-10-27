namespace HarpEngine.Shapes;

public class RectangleShape : Entity, ITransform2D, IIntersectsWithPoint, IIntersectsWithCircle, IIntersectsWithRectangle, IIntersectsWithLine
{
	public Transform2D Transform { get; set; } = new();
	public Vector2 Origin = Vector2.Zero;
	public int Width;
	public int Height;
	public Color Color;
	public Rectangle Rectangle => new(Transform.WorldPosition, Width, Height);

	public RectangleShape(Scene scene, int width, int height, Color color) : base(scene)
	{
		Width = width;
		Height = height;
		Color = color;
	}

	public override void Draw()
	{
		Primitives.DrawRectangle(Rectangle, Origin, Transform.WorldRotation, Color);
	}

	public bool IntersectsWithPoint(Vector2 position) => Intersection.PointInRectangle(position, Rectangle);
	public bool IntersectsWithRectangle(Rectangle rectangle) => Intersection.RectangleOnRectangle(Rectangle, rectangle);
	public bool IntersectsWithCircle(Vector2 circlePosition, float circleRadius) => Intersection.CircleOnRectangle(circlePosition, circleRadius, Rectangle);
	public bool IntersectsWithLine(Vector2 lineStartPosition, Vector2 lineEndPosition) => Intersection.LineOnRectangle(lineStartPosition, lineEndPosition, Rectangle);
}
