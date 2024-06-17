using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class BackGround : MonoBehaviour, IPointerClickHandler
{
    public TextMeshProUGUI moneyText;

    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Left)
        {
            GameManager.Instance.ChangeMoney(GameManager.Instance.clickMoney);
            moneyText.text = $"Money : {GameManager.Instance.totalMoney}";
        }
    }
}