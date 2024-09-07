using Content.Shared.Item.ItemToggle;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared.Item.ItemToggle.Components;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
public sealed partial class ItemTogglePrefixComponent : Component
{
    [DataField]
    public string? Prefix;

    [DataField, AutoNetworkedField]
    public string? DefaultPrefix;
}
