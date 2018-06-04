namespace JsonTransform
{
    using System;
    using System.IO;
    using Microsoft.VisualStudio.Jdt;
    using PowerArgs;

    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var parsed = Args.Parse<JsonTransformArguments>(args);
                //Console.WriteLine("You entered string '{0}' and int '{1}'", parsed.StringArg, parsed.IntArg);
                var logger = new ConsoleJsonTransformationLogger();
                var transform = new JsonTransformation(parsed.TransformFile, logger);

                if (File.Exists(parsed.DestinationFile))
                    File.Delete(parsed.DestinationFile);
                    
                //File.Copy(parsed.SourceFile, parsed.DestinationFile);
                var result = transform.Apply(parsed.SourceFile);
                using (var destFile = File.OpenWrite(parsed.DestinationFile))
                    result.CopyTo(destFile);

                Console.WriteLine($"Transform completed successfully into {parsed.DestinationFile}");
            }
            catch (ArgException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ArgUsage.GenerateUsageFromTemplate<JsonTransformArguments>());
            }

         
            
        }
    }

    public class JsonTransformArguments
    {

        [ArgRequired]
        [ArgExistingFile]
        [ArgDescription("Source")]
        [ArgShortcut("s")]
        public string SourceFile { get; set; }

        [ArgRequired]
        [ArgExistingFile]
        [ArgDescription("Transform")]
        [ArgShortcut("t")]
        public string TransformFile { get; set; }

        [ArgRequired]
        [ArgDescription("Destination")]
        [ArgShortcut("d")]
        public string DestinationFile { get; set; }

        //// This argument is required and if not specified the user will 
        //// be prompted.
        //[ArgRequired(PromptIfMissing = true)]

        //public string StringArg { get; set; }

        //// This argument is not required, but if specified must be >= 0 and <= 60
        //[ArgRange(0, 60)]
        //public int IntArg { get; set; }
    }
}
