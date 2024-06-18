using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class BackGround : MonoBehaviour, IPointerClickHandler
{
    public TextMeshProUGUI moneyText;
    public AudioClip clickClip;

    private void Start()
    {
        GameManager.Instance.updateMoneyText += UpdateMoneyText;
        AudioManager.Instance.PlayBackgroundMusic();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Left)
        {
            GameManager.Instance.ChangeMoney(GameManager.Instance.clickMoney);
            AudioManager.Instance.PlaySound(clickClip);
        }
    }

    private void UpdateMoneyText()
    {
        moneyText.text = $"Money : ${GameManager.Instance.totalMoney}";
    }
}