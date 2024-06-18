using UnityEngine;

public class UIMain : MonoBehaviour
{
    public GameObject buyWindow;

    private void Start()
    {
        buyWindow.SetActive(false);
    }

    public void OnBuyButton()
    {
        Toggle(buyWindow);
    }

    private void Toggle(GameObject go)
    {
        go.SetActive(!go.activeInHierarchy);
    }
}
