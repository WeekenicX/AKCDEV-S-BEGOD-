using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ALogs", menuName = "AKCDEV_GAME/ALogs")]
public class ALogs : ScriptableObject
{

    public ALog[] logs;
}
[System.Serializable]
public class ALog
{
    public string title;
    public int priority;
    public string description;
    public string tips;
    public ALogPart[] parts;


   


}
[System.Serializable]
public class ALogPart
{
    public string title;
    public int priority;
    public string description;
}

