using Content.Shared.Eui;
using Content.Shared.Roles;
using Robust.Shared.Player;
using Robust.Shared.Serialization;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom.Prototype;

namespace Content.Shared._Starlight.NewLife;

[NetSerializable, Serializable]
public sealed class NewLifeEuiState : EuiStateBase
{
    public HashSet<int> UsedSlots { get; set; } = [];
}
[NetSerializable, Serializable]
public sealed class NewLifeOpenedEvent : EntityEventArgs
{
}
