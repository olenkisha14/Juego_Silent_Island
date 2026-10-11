using UnityEngine;

[CreateAssetMenu(fileName = "Post Dialogue Data", menuName = "Scriptable Objects/Dialogue/Post Dialogue Data")]

public class PostDialogueData : ScriptableObject
{
    [TextArea] public string[] postDialogueData = { };

}
