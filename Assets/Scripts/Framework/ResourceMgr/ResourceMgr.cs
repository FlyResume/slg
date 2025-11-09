using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace QZGFramework
{
    public class ResourceMgr : Singleton<ResourceMgr>
    {
        public void LoadAssets(string name, Transform parent = null)
        {
            Addressables.LoadAssetAsync<GameObject>(name).Completed += (obj) =>
            {
                GameObject a = GameObject.Instantiate(obj.Result, parent);
                // if(obj.Result.gameObject.layer == 5)
                // {
                //     GameMgr.Instance.UIManager.panelDic.Add(name,a);
                // }
            };
        }
    }
}