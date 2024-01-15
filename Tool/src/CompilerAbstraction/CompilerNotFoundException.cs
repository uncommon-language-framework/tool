namespace ULF.Tool.CompilerAbstraction;

public class CompilerNotFoundException : FileNotFoundException
{
	public CompilerNotFoundException() : base() { }
	public CompilerNotFoundException(string message) : base(message) { }
	public CompilerNotFoundException(Exception cause) : base(string.Empty, cause) {}
}