﻿#pragma checksum "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/FunctionsBlock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6a053bfeb65ba3e17885a8ae1523f28a3483258"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Microsoft.AspNetCore.Razor.Language.IntegrationTests.TestFiles.TestFiles_IntegrationTests_CodeGenerationIntegrationTest_FunctionsBlock_Runtime), @"default", @"/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/FunctionsBlock.cshtml")]
namespace Microsoft.AspNetCore.Razor.Language.IntegrationTests.TestFiles
{
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6a053bfeb65ba3e17885a8ae1523f28a3483258", @"/TestFiles/IntegrationTests/CodeGenerationIntegrationTest/FunctionsBlock.cshtml")]
    public class TestFiles_IntegrationTests_CodeGenerationIntegrationTest_FunctionsBlock_Runtime
    {
        #pragma warning disable 1998
        public async System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\nHere\'s a random number: ");
#nullable restore
#line (12,26)-(12,37) 6 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/FunctionsBlock.cshtml"
Write(RandomInt());

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "TestFiles/IntegrationTests/CodeGenerationIntegrationTest/FunctionsBlock.cshtml"
            
    Random _rand = new Random();
    private int RandomInt() {
        return _rand.Next();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
