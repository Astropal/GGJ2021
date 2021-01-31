using UnityEngine;
public class MenuDialog : MonoBehaviour
{
    public string PlayerName;
    public string NPCName;

    [TextArea(3, 10)]
    public string[] sentences;
}
