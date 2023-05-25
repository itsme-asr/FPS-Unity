using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interable : MonoBehaviour
{
    // msg displayed when a player looks at the object.
    public string promptMsg;
    public bool useEvents;
    public void baseInteract()
    {
        if (useEvents)
            GetComponent<InteractionEvent>().onInteract.Invoke();
        Interact();
    }
    protected virtual void Interact()
    {

    }
}
