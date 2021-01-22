using System.Collections.Generic;
using System.Xml.Linq;
using TemplateEngine.Docx.Errors;

namespace TemplateEngine.Docx.Processors
{
    class FieldsDeleteProcessor : IProcessor
    {
        public ProcessResult FillContent(XElement contentControl, IEnumerable<IContentItem> items)
        {
            var processResult = ProcessResult.NotHandledResult;

            foreach (var contentItem in items)
            {
                processResult.Merge(DelContent(contentControl, contentItem));
            }


            return processResult;
        }

        private ProcessResult DelContent(XElement contentControl, IContentItem item)
        {
            var processResult = ProcessResult.NotHandledResult;
            if (!(item is FieldDeleteContent))
            {
                processResult = ProcessResult.NotHandledResult;
                return processResult;
            }
            var field = item as FieldDeleteContent;
            // If there isn't a field with that name, add an error to the error string,
            // and continue with next field.
            if (contentControl == null)
            {
                processResult.AddError(new ContentControlNotFoundError(field));
                return processResult;
            }
            contentControl.Remove();
            processResult.AddItemToHandled(item);

            return processResult;
        }

        public IProcessor SetRemoveContentControls(bool isNeedToRemove)
        {
            return null;
        }
    }
}
