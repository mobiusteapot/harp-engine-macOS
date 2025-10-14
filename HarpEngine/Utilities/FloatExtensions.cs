namespace HarpEngine.Utilities;

public static class FloatExtensions
{
	public static int GetRounded(this float value)
	{
		return (int)float.Round(value);
	}

	public static int GetFloored(this float value)
	{
		return (int)float.Floor(value);
	}

	public static int GetCeiled(this float value)
	{
		return (int)float.Ceiling(value);
	}
}
