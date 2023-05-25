using UnityEditor;
[CustomEditor(typeof(Interable), true)]
public class InteractableEditor : Editor
{
    public override void OnInspectorGUI()
    {
        Interable interactable = (Interable)target;
        if (target.GetType() == typeof(EventsOnlyInteractable))
        {
            interactable.promptMsg = EditorGUILayout.TextField("Prompt Message", interactable.promptMsg);
            EditorGUILayout.HelpBox("EventOnlyInteract can Only use UnityEvents.", MessageType.Info);
            if (interactable.GetComponent<InteractionEvent>() == null)
            {
                interactable.useEvents = true;
            }
        }
        else
        {

            base.OnInspectorGUI();
            if (interactable.useEvents)
            {
                if (interactable.GetComponent<InteractionEvent>() == null)
                    interactable.gameObject.AddComponent<InteractionEvent>();
            }
            else
            {
                if (interactable.GetComponent<InteractionEvent>() != null)
                    DestroyImmediate(interactable.GetComponent<InteractionEvent>());
            }
        }
    }
}
