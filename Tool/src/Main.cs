using CommandLine;
using ULF.Tool.Args;

namespace ULF.Tool
{
	public class Program
	{
		public static int Main(string[] args)
		{
			return Parser.Default.ParseArguments<
				ULFToolBuild, 
				ULFToolNew, 
				ULFToolRun>(args)
				.MapResult(
					(ULFToolBuild args) => 0,
					(ULFToolNew args) => 0,
					(ULFToolRun args) => 0,
					(IEnumerable<Error> errs) => 0
				);
		}
	}
}