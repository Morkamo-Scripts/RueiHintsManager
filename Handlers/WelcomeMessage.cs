using Exiled.Events.EventArgs.Player;
using RueI.API;
using RueI.API.Elements;

namespace RueiHintsManager.Handlers;

public class WelcomeMessage
{
    public string Message { get; set; } = "<color=#FFD700>Добро пожаловать на сервер </color><color=#b0159c>Dark </color><color=#941083>Paradise.</color> \n <color=#FFD700>Для того что бы быть в курсе </color><color=#008B8B>новостей </color><color=#FFD700>сервера присоединяйся в наш </color>\n<color=#00FFFF>Discord </color> <color=red>ESC->[Server Info]</color>";
    public ushort VerticalPosition { get; set; } = 950;
    public float Duration { get; set; } = 20;
    
    public void OnPlayerConnected(VerifiedEventArgs ev)
    {
        RueDisplay.Get(ev.Player).Show(
            new Tag(),
            new BasicElement(VerticalPosition, Message),
            Duration);
    }
}