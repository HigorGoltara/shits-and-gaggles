using Robust.Shared.Serialization;
using Content.Shared.DoAfter;

namespace Content.Shared._EinsteinEngines.Cocoon
{
    [Serializable, NetSerializable]
    public sealed partial class CocoonDoAfterEvent : SimpleDoAfterEvent
    {
    }

    [Serializable, NetSerializable]
    public sealed partial class UnCocoonDoAfterEvent : SimpleDoAfterEvent
    {
    }
}
