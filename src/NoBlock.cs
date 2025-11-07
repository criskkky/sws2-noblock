using SwiftlyS2.Shared.Plugins;
using SwiftlyS2.Shared;
using SwiftlyS2.Shared.Players;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.Misc;
using SwiftlyS2.Shared.GameEventDefinitions;
using SwiftlyS2.Shared.Scheduler;

namespace NoBlock;

public partial class NoBlock(ISwiftlyCore core) : BasePlugin(core)
{
  private readonly ISchedulerService _scheduler = core.Scheduler;
  private void SetNoBlock(IPlayer player, bool enable)
  {
    _scheduler.NextTick(() =>
    {
      var pawn = player.PlayerPawn;
      if (pawn == null)
      {
        return;
      }

      if (enable)
      {
        pawn.Collision.CollisionGroup = (byte)CollisionGroup.Debris;
      }
      else
      {
        pawn.Collision.CollisionGroup = (byte)CollisionGroup.Player;
      }
      pawn.CollisionRulesChanged();
    });
  }


  public override void Load(bool hotReload)
  {
    var players = Core.PlayerManager.GetAllPlayers();
    foreach (var player in players)
    {
      if (player != null && player.IsValid)
      {
        SetNoBlock(player, true);
      }
    }
  }

  public override void Unload()
  {
    var players = Core.PlayerManager.GetAllPlayers();
    foreach (var player in players)
    {
      if (player != null && player.IsValid)
      {
        SetNoBlock(player, false);
      }
    }
  }

  [GameEventHandler(HookMode.Post)]
  public HookResult OnPlayerSpawn(EventPlayerSpawn @event)
  {
    var player = Core.PlayerManager.GetPlayer(@event.UserId);
    if (player != null && player.IsValid)
    {
      SetNoBlock(player, true);
    }
    return HookResult.Continue;
  }
}
