using CommandLine;
using ULF.Tool.Args;
using ULF.Tool.ProjectUtils;

namespace ULF.Tool;

public class Program
{
	static int New(ULFToolNew args)
	{
		var proj = Project.Current();
		return 0;
	}

	static int Run(ULFToolRun args)
	{
		var proj = Project.Current();
		return 0;
	}

	static int Build(ULFToolBuild args)
	{
		var proj = Project.Current();
		return 0;
	}

	static int Main(string[] args)
	{
		return Parser.Default.ParseArguments<
			ULFToolNew, 
			ULFToolRun, 
			ULFToolBuild>(args)
			.MapResult<
				ULFToolNew,
				ULFToolRun,
				ULFToolBuild, int>(
				New, Run, Build,
				(IEnumerable<Error> errs) => 0
			);
	}
}
