using Content.Shared.Clothing.Components;
using Content.Shared.Item.ItemToggle.Components;

namespace Content.Shared.Clothing.EntitySystems;
public sealed class ClothingTogglePrefixSystem : EntitySystem
{
    [Dependency] private readonly ClothingSystem _clothing = default!;

    public override void Initialize()
    {
        base.Initialize();

        SubscribeLocalEvent<ClothingTogglePrefixComponent, ComponentStartup>(OnStartupPrefix);
        SubscribeLocalEvent<ClothingTogglePrefixComponent, ItemToggledEvent>(OnUpdatePrefix);
    }

    private void OnStartupPrefix(EntityUid uid, ClothingTogglePrefixComponent comp, ref ComponentStartup args)
    {
        if (comp.DefaultPrefix != null) return;
        if (!TryComp<ClothingComponent>(uid, out var clothing)) return;

        comp.DefaultPrefix = clothing.EquippedPrefix;
    }

    private void OnUpdatePrefix(EntityUid uid, ClothingTogglePrefixComponent comp, ref ItemToggledEvent args)
    {
        var prefix = args.Activated ? comp.Prefix : comp.DefaultPrefix;
        _clothing.SetEquippedPrefix(uid, prefix);
    }
}
