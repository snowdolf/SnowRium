using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class BackGround : MonoBehaviour, IPointerClickHandler
{
    public TextMeshProUGUI moneyText;
    public AudioClip clickClip;
    private Camera mainCamera;

    private void Start()
    {
        GameManager.Instance.updateMoneyText += UpdateMoneyText;
        AudioManager.Instance.PlayBackgroundMusic();
        mainCamera = Camera.main;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Left)
        {
            GameManager.Instance.ChangeMoney(GameManager.Instance.clickMoney);
            AudioManager.Instance.PlaySound(clickClip, 0.3f, 0.2f);

            ParticleSystem particleSystem = GameManager.Instance.EffectParticle;

            Vector3 worldPosition = mainCamera.ScreenToWorldPoint(new Vector3(eventData.position.x, eventData.position.y, mainCamera.nearClipPlane));

            particleSystem.transform.position = worldPosition;
            ParticleSystem.EmissionModule em = particleSystem.emission;
            em.SetBurst(0, new ParticleSystem.Burst(0, Mathf.Ceil(5)));
            ParticleSystem.MainModule mm = particleSystem.main;
            mm.startSpeedMultiplier = 10f;

            particleSystem.Play();
        }
    }

    private void UpdateMoneyText()
    {
        moneyText.text = $"Money : ${GameManager.Instance.totalMoney}";
    }
}