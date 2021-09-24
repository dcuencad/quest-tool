using UnityEngine;

[CreateAssetMenu(fileName ="Quest", menuName ="Quest/Data")]
public class QuestData : ScriptableObject
{

    public bool Completed { get => _completed; set => _completed = value; }

    public string Description { get => _description; }

    public string Title { get => _title; }

    [SerializeField]
    private string _title;

    [SerializeField]
    private string _description;

    [SerializeField]
    private bool _completed;

}
