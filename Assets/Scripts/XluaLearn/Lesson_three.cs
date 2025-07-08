using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson_three : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //ab包管理器主包更改/设置
        ABTest.Instance.mainBundleName = "PC"; // 设置主包的名字   
        //初始化lua解析器，并添加自定义的Lua重定向加载器
        LuaMgr.GetInstance().Init();
        //执行打好ab包的Lua文件                                     ---------ab包重定向加载       （改txt后缀！！！！）+（改lua管理器开始的包名）
        //也可执行放在自己定好的asset路径下的lua文件---------------自定义路径重定向加载        （改lua管理器开始的地址）
        LuaMgr.GetInstance().DoLuaFile("LuaMain");
        //得
        int i=LuaMgr.GetInstance().Global.Get<int>("a");
        print(i);
        //改
        LuaMgr.GetInstance().Global.Set("a", "AAA"); // 设置全局变量
        //得函数
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
