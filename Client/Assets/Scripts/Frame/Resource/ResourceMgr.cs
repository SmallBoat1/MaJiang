using UnityEngine;
using System.Collections.Generic;
using System.Reflection;

public class ResourceMgr
{
    private Dictionary<string,GameObject> m_assetChach;

    public ResourceMgr()
    {
        m_assetChach = new Dictionary<string,GameObject>();
    }

    public GameObject Load(string name){
        string path = "ui/prefab/"+name.ToLower();
        if(m_assetChach.ContainsKey(path))
            return m_assetChach[path];
        else
            return LoadAesst(path);
    }

    public GameObject LoadAesst(string path)
    {
        GameObject trans = Resources.Load<GameObject>(path);
        if(trans) 
        {
            if(!m_assetChach.ContainsKey(path))
                m_assetChach.Add(path,trans);
            return trans;
        }

        return trans;
    }
}
