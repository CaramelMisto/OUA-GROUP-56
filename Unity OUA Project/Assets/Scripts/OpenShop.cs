using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenShop : MonoBehaviour
{
    public void GoShopBtn()
    {
        SceneManager.LoadScene("ShopScene");
    }
    public void GoHomeBtn()
    {
        SceneManager.LoadScene("EntryScene");
    }
}
