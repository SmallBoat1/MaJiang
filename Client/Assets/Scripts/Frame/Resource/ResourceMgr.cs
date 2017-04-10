using UnityEngine;
using System.Collections.Generic;
using System.Reflection;

public class ResourceMgr
{
    private Dictionary<string,Transform> m_assetChach;

    public ResourceMgr()
    {
        m_assetChach = new Dictionary<string,Transform>();
    }

    public Transform LoadUI(string name){
        string path = "ui/prefab/"+name.ToLower();
        if(m_assetChach.ContainsKey(path))
            return m_assetChach[path];
        else
            return LoadAesst(path);
    }

    public Transform LoadAesst(string path)
    {
        Transform trans = Resources.Load<Transform>(path);
        if(trans) 
        {
            if(!m_assetChach.ContainsKey(path))
                m_assetChach.Add(path,trans);
            return trans;
        }

        return trans;
    }
}
