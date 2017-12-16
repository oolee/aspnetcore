using Microsoft.AspNetCore.Mvc.Razor.Extensions;
using Microsoft.AspNetCore.Razor.Language;

namespace RazorPagesContacts {
    public class CustomTemplateEngine : MvcRazorTemplateEngine {
        public CustomTemplateEngine(RazorEngine engine,RazorProject project):base(engine,project) {        }
        public override RazorCSharpDocument GenerateCode(RazorCodeDocument codeDocument) {
            var csharpDocument= base.GenerateCode(codeDocument);

            var generatedCode = csharpDocument.GeneratedCode;

            return csharpDocument;
        }
    }
}


namespace RazorPagesContacts.Pages.xyzx {

}