namespace ULF.Tool.ProjectUtils;

public readonly struct Project
{
	public readonly string Name;
	public readonly string[] CompilationTargets;
	public readonly string[] SourceFiles;
	public readonly string[] FrameworkTargets;
	public readonly string[] ProjectReferences;
	public readonly string[] PackageReferences;
	public readonly string[] OutputType;
	public readonly string Template;

	public Project(string directory)
	{

	}

	public static Project Current()
	{
		return new Project(Directory.GetCurrentDirectory());
	}
}