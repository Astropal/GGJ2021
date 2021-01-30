using UnityEngine;
 [System.Serializable]
public class MenuDialog
{

    public string PlayerName;
    public string NPCName;

    [TextArea(3, 10)]
    public string[] sentences;
}
