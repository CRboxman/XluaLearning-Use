using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

[Hotfix]
public class HotFix_1_try : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LuaMgr.GetInstance().Init();
        LuaMgr.GetInstance().DoLuaFile("LuaMain");

        print(Add(0, 1));

        Speak();
    }
    public int Add(int a,int b)
    {
        return a + b;
    }
    public static void Speak()
    {
        Debug.Log("Hello, this is a hotfix method!");
    }
}
