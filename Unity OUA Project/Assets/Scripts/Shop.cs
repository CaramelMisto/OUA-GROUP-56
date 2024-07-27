using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txtCoins;

    private int coins=5000;

    [SerializeField] Image[] btns;
    [SerializeField] TextMeshProUGUI[] txts;

    int[] prices = new int[4] {0,999,1999,4999};
    bool[] owningChars;

    public void onBtn1Click() {
        SelectChar(0);
    }
    public void onBtn2Click() {
        SelectChar(1);
    }
    public void onBtn3Click() { 
        SelectChar(2);
    }
    public void onBtn4Click() {
        SelectChar(3);
    }

    bool SelectChar(int id)
    {
        if (owningChars[id] || coins > prices[id])
        {
            setStyle(id);
            return true;
        }
        return false;
    }

    void setStyle(int id)
    {
        if (btns.Length != txts.Length)
            return;

        for (int i = 0; i< btns.Length; i++)
        {
            if (id == i){
                btns[i].gameObject.SetActive(false);
                txts[i].gameObject.SetActive(true);
                continue;
            }
            btns[i].gameObject.SetActive(true);
            txts[i].gameObject.SetActive(false);
        }

    }

    private void Awake()
    {
        LoadShopSave();
    }

    void LoadShopSave()
    {
        owningChars = new bool[4] {true, false, false,false};
    }

}
