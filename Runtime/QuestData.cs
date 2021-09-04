using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Quest", menuName ="Quest/Data")]
public class QuestData : ScriptableObject
{
    [SerializeField]
    private string _title;

    [SerializeField]
    private string _description;

    [SerializeField]
    private bool _complete;
}
