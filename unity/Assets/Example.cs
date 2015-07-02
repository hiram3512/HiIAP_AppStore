using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Example : MonoBehaviour, IIAPListener
{
    /// <summary>
    /// purchase id, you will setting in itunesconnect console
    /// </summary>
    private string[] id = new string[] { "com.hiram.id1", "com.hiram.id2" };

    public void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 100, 40), "Init"))
        {
            HiIAPManager.Init();
        }
        if (GUI.Button(new Rect(0, 50, 100, 40), "purchase1"))
        {
            HiIAPManager.Purchase(id[0]);
            //recommend open a panel to forbid player multiply click,
            //and wait the purchase result.
            //forbidPanel.setActive(true);

        }
        if (GUI.Button(new Rect(0, 100, 100, 40), "purchase2"))
        {
            HiIAPManager.Purchase(id[1]);
            //recommend open a panel to forbid player multiply click,
            //and wait the purchase result.
            //forbidPanel.setActive(true);
        }
    }
    public void PurchaseSucceeded(string id)
    {
        //forbidPanel.setActive(false);
        if (id == this.id[0])
        {
            //buy virtual gold1 success, and add virtual gold 100;
            // gold+=100;  
        }
        else if (id == this.id[1])
        {
            //buy virtual gold1 success, and add virtual gold 200;
            // gold+=200; 
        }
    }
    public void PurchaseFailed(string id)
    {
        //purchase failed
        //forbidPanel.setActive(false);
    }

    public void OnEnable()
    {
        HiIAPListener.purchaseSuccessEvent += PurchaseSucceeded;
        HiIAPListener.purchaseFailedEvent += PurchaseFailed;
    }
    public void OnDisable()
    {
        HiIAPListener.purchaseSuccessEvent -= PurchaseSucceeded;
        HiIAPListener.purchaseFailedEvent -= PurchaseFailed;
    }
}
