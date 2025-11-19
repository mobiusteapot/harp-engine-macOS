# Texture Animation

Texture animation is pretty simple, and is done like so:

```csharp
Texture walkTexture = Texture.Load("sprites/player/walk.png");
TextureAnimation walkAnimation = new(walkTexture, 4, 16, 16, 0.2f);
```

```csharp
private override void OnDraw()
{
	walkAnimation.Draw(position, direction, Colors.White);
}
```