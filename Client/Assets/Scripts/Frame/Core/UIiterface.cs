/********************************************************
*UIinterface UI界面Api,提供静态方法
*********************************************************/
using UnityEngine;
using UnityEngineInternal;
using System.Collections.Generic;

public class UIinterface {

    // 构造函数
    public UIinterface()
    {

    }

    // 析构函数
    ~UIinterface(){

    }

    // 初始化界面对象
    public static void InitViewObject<T>(T obj) where T : UIBaseObject
    {
        if(obj.GameObject) 
        {
            return;
        }
        string name = typeof(T).Name;
        //  加载界面prefab
       obj.GameObject = GameControllor.ResourceMgr.LoadUI(name).gameObject;
    }

    // 解析界面节点
    public static bool ParsePrefab(Transform root,ref Dictionary<string,Transform> dic)
    {
        if(!root) return false;
        string name = GetFullName(root);
        if(root.childCount == 0) 
        {
            dic.Add(name,root);
            return true;            
        }

        for(int i = 0;i < root.childCount;i++)
        {
            ParsePrefab(root.GetChild(i),ref dic);
        }
        return true;
    }

    // 获取界面完整路径
    public static string GetFullName(Transform tran)
    { 
        string name = tran.name;
        if(!tran.parent) return name;
       name = name +"/" + GetFullName(tran.parent);
       return name;
    }

}