using TMPro;
using UnityEngine;

public class ItemSlot : MonoBehaviour
{
    public ItemData itemData;
    public TextMeshProUGUI descText;
    public TextMeshProUGUI costText;

    public void Set()
    {
        string upgradeTypeStr = itemData.upgradeType switch
        {
            UpgradeType.Auto => "Auto Money",
            UpgradeType.Click => "Click Money",
            UpgradeType.Delay => "Delay Time",
            _ => ""
        };

        descText.text = itemData.upgradeType switch
        {
            UpgradeType.Delay => $"- {itemData.floatValue}\n\n" + upgradeTypeStr,
            _ => $"+ {itemData.value}\n\n" + upgradeTypeStr
        };

        costText.text = $"${itemData.cost}";
    }

    public void OnClickButton()
    {
        if(itemData.cost <= GameManager.Instance.totalMoney)
        {
            switch (itemData.upgradeType)
            {
                case UpgradeType.Auto:
                    GameManager.Instance.autoMoney += itemData.value;
                    break;
                case UpgradeType.Click:
                    GameManager.Instance.clickMoney += itemData.value;
                    break;
                case UpgradeType.Delay:
                    if (GameManager.Instance.autoDelay > 0.1f) GameManager.Instance.autoDelay -= itemData.floatValue;
                    else return;
                    break;
                default:
                    break;
            }
            GameManager.Instance.ChangeMoney(-itemData.cost);
        }
    }
}
