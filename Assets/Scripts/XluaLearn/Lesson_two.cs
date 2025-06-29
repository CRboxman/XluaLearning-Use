using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using XLua;

public class Lesson_two : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LuaEnv luaEnv = new LuaEnv();
        luaEnv.AddLoader(MyLoader);
        luaEnv.DoString("require('LuaMain')"); 
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private byte[] MyLoader(ref string filepath)
    {
        string path=Application.dataPath + "/Lua/" + filepath + ".lua";
        Debug.Log(path);//  ������ļ���·��
        Debug.Log(filepath);//    require���ļ���
        if (File.Exists(path))
        {
            return File.ReadAllBytes(path);
        }
        else
        {
            Debug.LogError("Lua file not found: " + filepath);
        }
            return null;
    }
}
