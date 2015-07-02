using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class HiIAPManager
{
    [DllImport("__Internal")]
    private static extern void _Purchase(string id);
    [DllImport("__Internal")]
    private static extern void _Init();
    public static void Init()
    {
        _Init();
    }
    public static void Purchase(string id)
    {
        _Purchase(id);
    }
}
