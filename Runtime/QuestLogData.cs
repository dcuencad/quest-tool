using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QuestLog", menuName = "Quest/Log")]
public class QuestLogData : ScriptableObject
{
    [SerializeField]
    private List<QuestData> _questList;
}
