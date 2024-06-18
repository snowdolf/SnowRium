using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class BackGround : MonoBehaviour, IPointerClickHandler
{
    public TextMeshProUGUI moneyText;

    private void Start()
    {
        GameManager.Instance.updateMoneyText += UpdateMoneyText;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Left)
        {
            GameManager.Instance.ChangeMoney(GameManager.Instance.clickMoney);
        }
    }

    private void UpdateMoneyText()
    {
        moneyText.text = $"Money : ${GameManager.Instance.totalMoney}";
    }
}