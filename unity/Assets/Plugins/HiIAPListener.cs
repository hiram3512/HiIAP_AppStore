using UnityEngine;
using System.Collections;
using System;

public class HiIAPListener : MonoBehaviour, IIAPListener
{
    public static event Action<string> purchaseSuccessEvent;
    public static event Action<string> purchaseFailedEvent;
    // Use this for initialization
    void Start()
    {
        gameObject.name = this.GetType().ToString();
        DontDestroyOnLoad(gameObject);
    }
    /// <summary>
    /// called from ios to notice purchase failed
    /// </summary>
    /// <param name="id"></param>
    public void PurchaseFailed(string id)
    {
        purchaseFailedEvent(id);
    }
    /// <summary>
    /// called from ios to notice unity purchase success
    /// </summary>
    /// <param name="id"></param>
    public void PurchaseSucceeded(string id)
    {
        purchaseSuccessEvent(id);
    }
}
public interface IIAPListener
{
    void PurchaseSucceeded(string id);
    void PurchaseFailed(string id);
}