namespace HarpEngine.Shapes;

public interface IIntersectsWithCircle
{
	public bool IntersectsWithCircle(Vector2 circlePosition, float circleRadius);
	public bool IntersectsWithCircle(CircleShape circleShape);
}
