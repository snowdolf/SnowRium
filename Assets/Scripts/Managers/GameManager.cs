using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public int totalMoney;
    public int clickMoney = 10;

    public void ChangeMoney(int amount)
    {
        totalMoney += amount;
    }
}
