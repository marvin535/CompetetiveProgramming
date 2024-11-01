public sealed class Singleton
{
	private static readonly Singleton instance = new Singleton();

	public Singleton()
	{
		
	}

	public static Singleton Instance => instance;
}