using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson_three : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ABTest.Instance.mainBundleName = "PC"; // 设置主包的名字   
        LuaMgr.GetInstance().Init();
        LuaMgr.GetInstance().DoLuaFile("LuaMain");

        int i=LuaMgr.GetInstance().Global.Get<int>("a");
        print(i);

        LuaMgr.GetInstance().Global.Set("a", "AAA"); // 设置全局变量
        string iw = LuaMgr.GetInstance().Global.Get<string>("a");
        print(iw);
        //如果要搞其他主包，进行以下操作
        //ABTest.Instance.RemoveRes("这个AB包的名字"); // 移除加载的资源，这两个看情况选一个就行
        //ABTest.Instance.RemoveAllRes(); // 移除所有加载的资源，这两个看情况选一个
        //ABTest.Instance.mainBundleName = "PC"; // 设置主包的名字   
        //LuaMgr.GetInstance().Init();
        //LuaMgr.GetInstance().DoLuaFile("LuaMain");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
