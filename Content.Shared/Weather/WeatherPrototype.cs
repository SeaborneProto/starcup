using Content.Shared.Damage;  // DeltaV
using Content.Shared.Whitelist;  // DeltaV
using Robust.Shared.Audio;
using Robust.Shared.Prototypes;
using Robust.Shared.Utility;

namespace Content.Shared.Weather;

[Prototype]
public sealed partial class WeatherPrototype : IPrototype
{
    [IdDataField] public string ID { get; private set; } = default!;

    [ViewVariables(VVAccess.ReadWrite), DataField("sprite", required: true)]
    public SpriteSpecifier Sprite = default!;

    [ViewVariables(VVAccess.ReadWrite), DataField("color")]
    public Color? Color;

    /// <summary>
    /// Sound to play on the affected areas.
    /// </summary>
    [ViewVariables(VVAccess.ReadWrite), DataField("sound")]
    public SoundSpecifier? Sound;

    /// <summary>
    /// DeltaV: Damage you can take from being in this weather.
    /// Only applies when weather has fully set in.
    /// </summary>
    [DataField]
    public DamageSpecifier? Damage;

    /// <summary>
    /// DeltaV: Don't damage entities that match this blacklist.
    /// </summary>
    [DataField]
    public EntityWhitelist? DamageBlacklist;
}
