using System.Linq;
using System.Xml.Linq;

namespace TemplateEngine.Docx.Processors
{
    class ParagraphDeleteProcessor
    {
        public ProcessResult DeleteContent(XElement contentControl)
        {
            var processResult = ProcessResult.NotHandledResult;

            var par = contentControl.Elements(W.p).LastOrDefault();
            if (par != null)
                par.Remove();

            return processResult;
        }
    }
}
