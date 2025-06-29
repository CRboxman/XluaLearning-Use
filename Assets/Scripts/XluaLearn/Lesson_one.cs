using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XLua;

public class Lesson_one : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LuaEnv luaEnv=new LuaEnv();
        luaEnv.DoString("require('Lua/lua_one')");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
