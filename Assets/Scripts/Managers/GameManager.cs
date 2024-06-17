using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public int totalMoney;
    public int clickMoney = 10;
    public int autoMoney = 5;

    public void ChangeMoney(int amount)
    {
        totalMoney += amount;
    }
}
