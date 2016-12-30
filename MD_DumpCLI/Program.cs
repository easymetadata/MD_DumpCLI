using System;
using System.Linq;
using CommandLine;

namespace MD_DumpCLI
{
    class Program
    {
        static void Main(string[] args)
        {

            var result = CommandLine.Parser.Default.ParseArguments<Options>(args);
            if (!result.Errors.Any())
            {
                Console.WriteLine("Author:  David Dym");
                Console.WriteLine("License: Apache 2.0\n https://www.apache.org/licenses/");

                // Values are available here
                if (result.Value.Verbose) Console.WriteLine("\nFilename: {0}", result.Value.InputFile);
            }

            //Kickoff processing and collection of files!
            TikaMetaData.TikaExtractAll(result.Value.InputFile, result.Value.content);
        }
    }

    class Options
    {
        [Option('f', "file", Required = true,
          HelpText = "File to dump metadata.")]
        public string InputFile { get; set; }

        [Option('c', "Output content using Tika", Required = false,
            HelpText = "Output file or metadata.")]
        public bool content { get; set; }

        // omitting long name, default --verbose
        [Option(DefaultValue = true,
          HelpText = "Usage: MD_DumpCLI.exe -i \"filename.ext\" -c True ")]
        public bool Verbose { get; set; }
    }
}
