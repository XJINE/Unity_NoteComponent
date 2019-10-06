using UnityEngine;

public class NoteComponent : MonoBehaviour
{
    [TextArea(10, 30)]
    public string note;

    protected virtual void Awake()
    {
        Destroy(this);
    }
}