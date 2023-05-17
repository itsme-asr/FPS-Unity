using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interable : MonoBehaviour
{
    // msg displayed when a player looks at the object.
    public string promptMsg;
    public void baseInteract()
    {
        Interact();
    }
    protected virtual void Interact()
    {

    }
}
