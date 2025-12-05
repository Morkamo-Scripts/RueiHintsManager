using Exiled.Events.EventArgs.Player;
using RueI.API;
using RueI.API.Elements;

namespace RueiHintsManager.Handlers;

public class ServerBadge
{
    public string Message { get; set; } = "<b>[R<color=#0000cd>U</color><color=#ff0000>S</color>] <color=#8137CE>Dark Paradise </color><color=#FF96DE> | Classic</color></b>";
    public ushort VerticalPosition { get; set; } = 25;
    
    public void OnPlayerConnected(VerifiedEventArgs ev)
    {
        RueDisplay.Get(ev.Player).Show(
            new Tag(),
            new BasicElement(VerticalPosition, Message));
    }
}