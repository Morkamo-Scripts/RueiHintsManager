using Exiled.Events.EventArgs.Player;
using PlayerRoles;
using RueI.API;
using RueI.API.Elements;

namespace RueiHintsManager.Handlers;

public class ProximityChatHint
{
    public string Message { get; set; } = "<size=25><color=#ffbb00>Для переключения разговора с людьми или SCP используйте бинд на общий чат.\nНастройка в </color><color=red>SERVER SPECIFIC</color></size>";
    public ushort VerticalPosition { get; set; } = 170;
    public float Duration { get; set; } = 7;
    
    public void OnPlayerSpawned(SpawnedEventArgs ev)
    {
        if (!ev.Player.IsScp || ev.Player.Role.Type == RoleTypeId.Scp0492 
                             || ev.Player.Role.Type == RoleTypeId.ZombieFlamingo
                             || ev.Player.Role.Type == RoleTypeId.Scp079)
            return;
        
        RueDisplay.Get(ev.Player).Show(
            new Tag(),
            new BasicElement(VerticalPosition, Message),
            Duration);
    }
}