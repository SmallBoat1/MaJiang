/********************************************************
*UIInterface UI界面Api,提供静态方法
*********************************************************/
using UnityEngine;
using System.Collections.Generic;

public class UIInterface {

    // 构造函数
    public UIInterface()
    {

    }

    // 析构函数
    ~UIInterface(){

    }

    // 初始化界面对象
    public static void LoadView<T>(T obj) where T : ViewObject
    {
        if(obj.GameObject) 
        {
            return;
        }
        string name = typeof(T).Name;
        //  加载界面prefab
       obj.GameObject = GameControllor.ResourceMgr.LoadUI(name);
    }

    private void ParseView<T>(T view) where T : ViewObject
    {

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