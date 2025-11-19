namespace HarpEngine.Animation;

public class TextureAnimationManager<AnimationID> where AnimationID : Enum
{
	private Dictionary<AnimationID, TextureAnimation> animations = new();
	private AnimationID currentID;
	private float startTime;

	public void RegisterAnimation(TextureAnimation animation, AnimationID id)
	{
		animations.Add(id, animation);
	}

	public void SetAnimation(AnimationID id, float startTime)
	{
		currentID = id;
		TextureAnimation animation = animations[id];
		this.startTime = startTime;
	}

	public void Draw(Vector2 position, Vector2 direction, float frameTime, Color color)
	{
		TextureAnimation animation = animations[currentID];
		animation.Draw(position, direction, frameTime, color);
	}
}
