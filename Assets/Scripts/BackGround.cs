using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class BackGround : MonoBehaviour, IPointerClickHandler
{
    public TextMeshProUGUI moneyText;

    private float autoDelay = 1f;
    private float totalTime = 0f;

    private void Update()
    {
        totalTime += Time.deltaTime;
        if (totalTime > autoDelay)
        {
            GameManager.Instance.totalMoney += GameManager.Instance.autoMoney;
            totalTime = 0f;
            UpdateMoneyText();
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Left)
        {
            GameManager.Instance.ChangeMoney(GameManager.Instance.clickMoney);
            UpdateMoneyText();
        }
    }

    private void UpdateMoneyText()
    {
        moneyText.text = $"Money : {GameManager.Instance.totalMoney}";
    }
}