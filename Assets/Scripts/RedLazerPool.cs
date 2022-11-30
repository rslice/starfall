using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedLazerPool : GameObjectPool
{
    protected override void OnTakeFromPool(GameObject obj)
    {
        base.OnTakeFromPool(obj);
        obj.GetComponent<RedLazerTrailFade>().color.a = 100;
    }
}