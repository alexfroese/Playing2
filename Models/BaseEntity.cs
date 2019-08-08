namespace Playing2.Models
{
    public abstract class BaseEntity
    {
        public int ID { get; private set; }

        public static bool operator ==(BaseEntity a, BaseEntity b)
        { return a.GetType() == b.GetType() && a.ID == b.ID; }

        public static bool operator !=(BaseEntity a, BaseEntity b)
        { return !(a.GetType() == b.GetType() && a.ID == b.ID); }

        public override bool Equals(object obj)
        {
            return GetType() == obj.GetType() && ID == (obj as BaseEntity).ID;
        }

        public override int GetHashCode()
        {
            return GetType().GetHashCode() ^ ID.GetHashCode();
        }
    }
}