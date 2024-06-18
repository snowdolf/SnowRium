using System;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public int totalMoney = 0;
    public int clickMoney = 10;
    public int autoMoney = 5;

    public float autoDelay = 1f;
    private float totalTime = 0f;

    public Action updateMoneyText;
    public ParticleSystem EffectParticle;

    private void Start()
    {
        EffectParticle = GameObject.FindGameObjectWithTag("Particle").GetComponent<ParticleSystem>();
    }

    private void Update()
    {
        totalTime += Time.deltaTime;
        if (totalTime > autoDelay)
        {
            totalMoney += autoMoney;
            totalTime -= autoDelay;
            updateMoneyText?.Invoke();
        }
    }

    public void ChangeMoney(int amount)
    {
        totalMoney += amount;
        updateMoneyText?.Invoke();
    }
}
