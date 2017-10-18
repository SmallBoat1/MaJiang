using UnityEngine;
using System.Collections.Generic;

public class ResourceMgr
{
    private Dictionary<string, GameObject> m_assetChach;
    private Dictionary<string, int> m_assetRefrensCount;

    public ResourceMgr()
    {
        m_assetChach = new Dictionary<string, GameObject>();
        m_assetRefrensCount = new Dictionary<string, int>();
    }

    public GameObject LoadUI(string name) {
        if (m_assetChach.ContainsKey(name.ToLower()))
            return m_assetChach[name.ToLower()];
        else
            return LoadAesst("ui/prefab/", name);
    }

    public GameObject LoadAesst(string path, string name)
    {
        GameObject trans = Resources.Load<GameObject>(path);
        if (trans)
        {
            if (!m_assetChach.ContainsKey(path))
                m_assetChach.Add(path, trans);
            return trans;
        }

        return trans;
    }

    public void AddRefrens(string resName)
    {
        if (m_assetRefrensCount.ContainsKey(resName))
            m_assetRefrensCount[resName]++;
        else
            m_assetRefrensCount[resName] = 1;
    }

    /// <summary>
    /// 减引用计数
    /// </summary>
    /// <param name="resName"></param>
    public void ReduceRefrens(string resName)
    {
        if (!m_assetRefrensCount.ContainsKey(resName) || m_assetRefrensCount[resName] <= 1)
        {

        }
       

    }

    /// <summary>
    /// 卸载资源
    /// </summary>
    /// <param name="path"></param>
    /// <param name="name"></param>
    public void UnLoadResource(string path,string name)
    {

    }
}
