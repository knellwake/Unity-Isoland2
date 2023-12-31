using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities;

public class Interactive : MonoBehaviour
{
    public ItemName requireItem;
    public bool isDone;

    public void CheckItem(ItemName itemName)
    {
        if (itemName == requireItem && !isDone)
        {
            isDone = true;
            //使用这个物品，
            OnClickedAction();
            //移除物品
            EventHandler.CallItemUsedEvent(itemName);
        }
    }

    /// <summary>
    /// 默认是正确的物品情况执行
    /// </summary>
    protected virtual void OnClickedAction()
    {
    }

    public virtual void EmptyClicked()
    {
        Debug.Log("空点");
    }
}
