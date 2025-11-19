# Curves

The `Curves` class has a large range of curves to choose from, and because they are delegates, you can even design your own. Here's an example of one of the simplest curves:

```csharp
public static float Cubic(float x)
{
	return x * x * x;
}
```