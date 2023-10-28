public enum EffectType
{
    Buff,
    Debuff
}
public enum EffectStat
{
    None,
    Health,
    Speed,
    Melee,
    Range,
    Magic,
    All,
    SpeedAttack,
    Ability
}
public enum EffectScale
{
    None,
    Linear, 
    Exponential 
}
public enum Intention
{
    Self,
    Left,
    Right,
    Tank,
    End,
    Weakest,
    NeedRepair,
    NeedTriage,
    Team,
    OpposingTeam
}
public enum TriggerEvent
{
    BattleStart,
    RoundStart,  //ability stays on or turns back on at round start, if not countered, i.e. Blind
    TurnStart,   //ability applied at start of card turn, before card attack, and if card ability not countered i.e. Cleanse
    CardDeath,
    HealthDamaged,
    Giant,
    EvenRound,
}
public enum DurationEffect
{
    Temporary,  //Debuff or Buff goes away on death, countered, etc.
    Permanent   //Cripple is permanent, even if card that applied Cripple dies, no counter
}
public enum CastFrom
{
    Summoner,
    Ruleset,
    Monster
}

