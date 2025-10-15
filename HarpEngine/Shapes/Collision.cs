namespace HarpEngine.Shapes;

public static class Collision
{
	public static bool PointInCircle(Vector2 pointPosition, Vector2 circlePosition, float radius)
	{
		float distance = Vector2.Distance(pointPosition, circlePosition);
		return distance < radius;
	}

	public static bool PointInCircleSquared(Vector2 pointPosition, Vector2 circlePosition, float radiusSquared)
	{
		float distanceSquared = Vector2.DistanceSquared(pointPosition, circlePosition);
		return distanceSquared < radiusSquared;
	}

	public static bool CircleOnCircle(Vector2 positionA, float radiusA, Vector2 positionB, float radiusB)
	{
		float distance = Vector2.Distance(positionA, positionB);
		return distance < radiusA + radiusB;
	}

	public static bool CircleOnCircleSquared(Vector2 positionA, float radiusSquaredA, Vector2 positionB, float radiusSquaredB)
	{
		float distanceSquared = Vector2.DistanceSquared(positionA, positionB);
		return distanceSquared < radiusSquaredA + radiusSquaredB;
	}

	public static bool CircleInCircle(Vector2 positionA, float radiusA, Vector2 positionB, float radiusB)
	{
		float distance = Vector2.Distance(positionA, positionB);
		return distance < radiusB - radiusA;
	}

	public static bool CircleInCircleSquared(Vector2 positionA, float radiusSquaredA, Vector2 positionB, float radiusSquaredB)
	{
		float distanceSquared = Vector2.DistanceSquared(positionA, positionB);
		return distanceSquared < radiusSquaredB - radiusSquaredA;
	}

	public static bool PointInRectangle(Vector2 pointPosition, Rectangle rectangle)
	{
		bool xCollides = pointPosition.X >= rectangle.X && pointPosition.X <= rectangle.X + rectangle.Width;
		bool yCollides = pointPosition.Y >= rectangle.Y && pointPosition.Y <= rectangle.Y + rectangle.Height;
		return xCollides && yCollides;
	}

	public static bool RectangleOnRectangle(Rectangle rectangleA, Rectangle rectangleB)
	{
		float rightEdgeA = rectangleA.X + rectangleA.Width;
		float bottomEdgeA = rectangleA.Y + rectangleA.Height;
		float rightEdgeB = rectangleB.X + rectangleB.Width;
		float bottomEdgeB = rectangleB.Y + rectangleB.Height;

		bool leftEdgePastRightEdge = rectangleA.X >= rightEdgeB;
		bool rightEdgeBeforeLeftEdge = rightEdgeA <= rectangleB.X;
		bool topEdgePastBottomEdge = rectangleA.Y >= bottomEdgeB;
		bool bottomEdgeBeforeTopEdge = bottomEdgeA <= rectangleB.Y;

		bool doesNotCollide = leftEdgePastRightEdge || rightEdgeBeforeLeftEdge || topEdgePastBottomEdge || bottomEdgeBeforeTopEdge;
		return !doesNotCollide;
	}

	public static bool CircleOnRectangle(Vector2 circlePosition, float circleRadius, Rectangle rectangle)
	{
		// Precalculate edges
		float rightEdge = rectangle.X + rectangle.Width;
		float bottomEdge = rectangle.Y + rectangle.Height;

		// Get left or right edge to check
		float xEdge;
		if (circlePosition.X < rectangle.X) xEdge = rectangle.X;
		else if (circlePosition.X > rightEdge) xEdge = rightEdge;
		else xEdge = circlePosition.X;

		// Get top or bottom edge to check
		float yEdge;
		if (circlePosition.Y < rectangle.Y) yEdge = rectangle.Y;
		else if (circlePosition.Y > bottomEdge) yEdge = bottomEdge;
		else yEdge = circlePosition.Y;

		// Get distance
		float xDistance = circlePosition.X - xEdge;
		float yDistance = circlePosition.Y - yEdge;
		float distance = float.Sqrt(xDistance * xDistance + yDistance * yDistance);

		// Check for collision
		return distance <= circleRadius;
	}

	public static bool PointOnLine(Vector2 pointPosition, Vector2 lineStartPosition, Vector2 lineEndPosition, float tolerance)
	{
		float lineLength = Vector2.Distance(lineStartPosition, lineEndPosition);
		float distanceToStart = Vector2.Distance(pointPosition, lineStartPosition);
		float distanceToEnd = Vector2.Distance(pointPosition, lineEndPosition);
		float distanceToBoth = distanceToStart + distanceToEnd;
		return distanceToBoth <= lineLength + tolerance;
	}
}
