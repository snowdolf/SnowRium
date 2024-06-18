using UnityEngine;

public enum UpgradeType
{
    Auto,
    Click,
    Delay,
    COUNT
}

[CreateAssetMenu(fileName = "Item", menuName = "New Item")]
public class ItemData : ScriptableObject
{
    [Header("Info")]
    public UpgradeType upgradeType;
    public int value;
    public float floatValue;
    public int cost;
}