using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using NJsonSchema.CodeGeneration.TypeScript;
using NSwag;
using NSwag.CodeGeneration.OperationNameGenerators;
using NSwag.CodeGeneration.TypeScript;

namespace YkAbp.AngularClientGenerator
{
    class Program
    {
        private const string DefaultSwaggerSpecUrl = "http://localhost:21021/swagger/v1/swagger.json";

        private const string DefaultOutputFile = @"..\..\..\abp-alain\src\abp\services\clients.ts";

        static void Main(string[] args)
        {
            var outputFile = args.Length > 1 ? args[1] : DefaultOutputFile;
            Console.WriteLine($"客户端代理类输出地址为：{System.IO.Path.GetFullPath(outputFile)}");
            GenerateFile(args.Length > 0 ? args[0] : DefaultSwaggerSpecUrl, outputFile);
            Console.WriteLine("生成成功");
        }

        static void GenerateFile(string swaggerSpecUrl, string outputFile)
        {
            var document = SwaggerDocument.FromUrlAsync(swaggerSpecUrl).GetAwaiter().GetResult();

            var settings = new SwaggerToTypeScriptClientGeneratorSettings
            {
                ClassName = "{controller}Client",
                OperationNameGenerator = new MultipleClientsFromPathSegmentsOperationNameGenerator(),
                HttpClass = HttpClass.HttpClient,
                InjectionTokenType = InjectionTokenType.InjectionToken,
                ClientBaseClass = null,
                Template = TypeScriptTemplate.Angular
            };

            settings.TypeScriptGeneratorSettings.DateTimeType = TypeScriptDateTimeType.MomentJS;
            settings.TypeScriptGeneratorSettings.GenerateCloneMethod = true;
            settings.TypeScriptGeneratorSettings.ExtendedClasses = null;
            settings.CodeGeneratorSettings.TemplateDirectory = "Template";

            var generator = new SwaggerToTypeScriptClientGenerator(document, settings);
            var code = generator.GenerateFile();

            using (var writer = new StreamWriter(outputFile, false, Encoding.UTF8))
            {
                writer.Write(code);
            }
        }
    }
}
