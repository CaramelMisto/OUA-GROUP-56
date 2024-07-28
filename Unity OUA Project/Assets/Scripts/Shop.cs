using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GameManager{
    public class Shop : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI txtCoins;

        [SerializeField] Image[] btns;
        [SerializeField] TextMeshProUGUI[] txts;

        int[] prices = new int[4] { 0, 999, 1999, 4999 };
        bool[] owningChars;

        public void onBtn1Click()
        {
            SelectChar(0);
        }
        public void onBtn2Click()
        {
            SelectChar(1);
        }
        public void onBtn3Click()
        {
            SelectChar(2);
        }
        public void onBtn4Click()
        {
            SelectChar(3);
        }

        bool SelectChar(int id)
        {
            if (owningChars[id])
            {
                setStyle(id);
                Savings.savedObject.selectedChar = id;
                return true;
            }
            else if (Savings.savedObject.coins  > prices[id])
            {
                Savings.savedObject.coins -= prices[id];
                txtCoins.text = Savings.savedObject.coins.ToString();
                owningChars[id] = true;
                Savings.savedObject.owningChars = owningChars;
                setStyle(id);
                Savings.savedObject.selectedChar = id;
                return true;
            }
            return false;
        }

        void setStyle(int id)
        {
            if (btns.Length != txts.Length)
                return;

            for (int i = 0; i < btns.Length; i++)
            {
                if (id == i)
                {
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
            SetButtonTexts();
        }

        void LoadShopSave()
        {
            txtCoins.text = Savings.savedObject.coins.ToString();
            owningChars = Savings.savedObject.owningChars;
            SelectChar(Savings.savedObject.selectedChar);
        }

        void OnDestroy()
        {
            Savings.Save();
        }

        void SetButtonTexts()
        {
            for (int i = 0; i < btns.Length; i++)
            {
                if (owningChars[i])
                {
                    btns[i].GetComponentInChildren<TextMeshProUGUI>().text="Select";
                }
            }
        }

    }
}