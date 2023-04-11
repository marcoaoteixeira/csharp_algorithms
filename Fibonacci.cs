namespace CSharp.Algorithms {
	public sealed class Fibonacci {
		public static int CalculateFor(int index) => (index > 2) ? CalculateFor(index - 1) + CalculateFor(index - 2) : 1;
	}
}
