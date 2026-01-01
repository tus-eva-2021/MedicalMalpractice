using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Create/ PlayerData")]
public class PlayerData : ScriptableObject 
{
    [SerializeField]
    public string playerName;
}
