using System;

namespace TemplateEngine.Docx
{
    public class TableDeleteContent : HiddenContent<TableDeleteContent>, IEquatable<TableDeleteContent>
    {
        public TableDeleteContent(string name)
        {
            Name = name;
        }

        public override bool Equals(IContentItem other)
        {
            if (!(other is TableDeleteContent)) return false;

            return Equals((TableDeleteContent)other);
        }

        public bool Equals(TableDeleteContent other)
        {
            if (other == null) return false;

            return Name.Equals(other.Name);
        }

        public override int GetHashCode()
        {
            return new { Name }.GetHashCode();
        }
    }
}
