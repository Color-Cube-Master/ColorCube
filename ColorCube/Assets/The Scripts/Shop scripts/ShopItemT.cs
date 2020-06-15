using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="ShopItemT")]
public class ShopItemT : ScriptableObject
{
    public Sprite icon2;
    public int Price2;
    public TheState state2;

    public void initItem2()
    {
        state2 = TheState.Lockit2;
    }
}

public enum TheState { Lockit2,Unlock2,UseIt2}
