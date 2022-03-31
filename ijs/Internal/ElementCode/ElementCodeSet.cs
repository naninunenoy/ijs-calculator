namespace ijs.Internal;

internal class ElementCodeSet : IEquatable<ElementCodeSet> {
    SingleElementCode SingleElementCode { get; }
    PairElementCode PairElementCode { get; }
    IceDanceElementCode IceDanceElementCode { get; }

    ElementCodeSet() {
        SingleElementCode = SingleElementCode.Undefined;
        PairElementCode = PairElementCode.Undefined;
        IceDanceElementCode = IceDanceElementCode.Undefined;
    }

    internal ElementCodeSet(SingleElementCode code) : this() {
        SingleElementCode = code;
    }

    internal ElementCodeSet(PairElementCode code) : this() {
        PairElementCode = code;
    }

    internal ElementCodeSet(IceDanceElementCode code) : this() {
        IceDanceElementCode = code;
    }
    
    public override string ToString() {
        if (SingleElementCode is not SingleElementCode.Undefined) {
            return SingleElementCode.ToString().TrimStart('_');
        }
        if (PairElementCode is not PairElementCode.Undefined) {
            return PairElementCode.ToString().TrimStart('_');
        }
        if (IceDanceElementCode is not IceDanceElementCode.Undefined) {
            return IceDanceElementCode.ToString().TrimStart('_').Replace("kp", "");
        }
        return "Undefined";
    }

    public bool Equals(ElementCodeSet? other) {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return PairElementCode == other.PairElementCode && 
               IceDanceElementCode == other.IceDanceElementCode &&
               SingleElementCode == other.SingleElementCode;
    }

    public override bool Equals(object? obj) {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((ElementCodeSet)obj);
    }

    public override int GetHashCode() {
        return HashCode.Combine((int)PairElementCode, (int)IceDanceElementCode, (int)SingleElementCode);
    }
}
