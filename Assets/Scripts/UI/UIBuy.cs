using UnityEngine;

public class UIBuy : MonoBehaviour
{
    public ItemData[] itemDatas;

    public ItemSlot[] slots;
    public Transform slotPanel;

    private void Start()
    {
        slots = new ItemSlot[slotPanel.childCount];

        for(int i = 0; i < slots.Length; i++)
        {
            slots[i] = slotPanel.GetChild(i).GetComponent<ItemSlot>();
            slots[i].itemData = itemDatas[i];
            slots[i].Set();
        }
    }
}
