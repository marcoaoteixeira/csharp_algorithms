namespace CSharp.Algorithms {
	public sealed class Fibonacci {
		public static int CalculateFor(int index) => (index > 2) ? Fibonacci(index - 1) + Fibonacci(index - 2) : 1;
	}
}