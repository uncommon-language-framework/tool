using System.Diagnostics;

namespace ULF.Tool.CompilerAbstraction;

public class CBCompilerHandle
{
	public readonly string Path;

	public CBCompilerHandle()
	{
		try
		{
			Process.Start("cbc", "--version");
		}
		catch (FileNotFoundException e)
		{
			throw new CompilerNotFoundException(e);
		}

		Path = "cbc";
	}

	public CBCompilerHandle(string path)
	{
		Path = path;
	}
}