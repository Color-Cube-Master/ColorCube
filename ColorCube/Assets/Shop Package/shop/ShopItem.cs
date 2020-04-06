using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="ShopItem")]
public class ShopItem : ScriptableObject
{
    public Sprite icon;
    public int Price;
    public State state;

    public void initItem()
    {
        state = State.Lockit;
    }
}

public enum State { Lockit,Unlock,UseIt}
