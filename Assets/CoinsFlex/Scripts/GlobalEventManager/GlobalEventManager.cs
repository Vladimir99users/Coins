using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public static class GlobalEventManager
{
    public static OnTapOnScreen OnTap = new OnTapOnScreen();

    public static void SendMessageOntheTap()
    {
        OnTap?.Invoke();
    }
}

public class OnTapOnScreen : UnityEvent{}

