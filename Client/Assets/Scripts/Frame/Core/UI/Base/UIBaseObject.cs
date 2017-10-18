/***********************************************
 * UI 界面对象类，用于解析存储界面实体,
 * 此类绑定界面类
 * 以减少界面操作时GC消耗
 ***********************************************/
using UnityEngine;
using System.Collections.Generic;

public class ViewObject
{
	public static string Name{get;set;}

	public virtual GameObject GameObject{get;set;}

    public virtual Transform Trans { get; set; }

    public Dictionary<string,UIComponet> NodeMap ;

	public ViewObject()
	{
        NodeMap = new Dictionary<string, UIComponet>();
        Init();
	}

    void Init()
    {
        if(!GameObject)
            UIInterface.LoadView(this);
        Name = GameObject.name;
        Trans = GameObject.transform;
        Open();
    }

    public T GetNode<T>(string name) where  T :Component
    {
        if (!NodeMap.ContainsKey(name))
        {
            Debug.LogErrorFormat("{0} can not find node {1}",GetType().Name,name);
            return null;
        }
        var node = NodeMap[name];
        return node.GetComponet<T>();
    }

    public T AddComponet<T>(string name) where T : Component
    {
        if (!NodeMap.ContainsKey(name))
        {
            Debug.LogErrorFormat("{0} can not find node {1}", GetType().Name, name);
            return null;
        }
        return NodeMap[name].AddComponet<T>();
    }

    public void Open()
    {
        GameObject.SetActive(true);
    }

    public void Close()
    {
        GameObject.SetActive(false);
    }

    public void Destroy()
    {

    }
}