using Content.Shared.Clothing.EntitySystems;
using Robust.Shared.GameStates;

namespace Content.Shared.Clothing.Components;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
[Access(typeof(ClothingTogglePrefixSystem))]
public sealed partial class ClothingTogglePrefixComponent : Component
{
    [DataField]
    public string? Prefix;

    [DataField, AutoNetworkedField]
    public string? DefaultPrefix;
}
