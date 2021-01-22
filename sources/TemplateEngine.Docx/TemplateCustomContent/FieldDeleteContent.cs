using System;

namespace TemplateEngine.Docx
{
    public class FieldDeleteContent : HiddenContent<FieldDeleteContent>, IEquatable<FieldDeleteContent>
    {
        public FieldDeleteContent(string name)
        {
            Name = name;
        }

        public bool Equals(FieldDeleteContent other)
        {
            if (other == null) return false;

            return Name.Equals(other.Name);
        }

        public override int GetHashCode()
        {
            return new { Name }.GetHashCode();
        }

        public override bool Equals(IContentItem other)
        {
            if (!(other is FieldDeleteContent)) return false;

            return Equals((FieldDeleteContent)other);
        }
    }
}
