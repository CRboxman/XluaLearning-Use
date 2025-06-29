using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson_four : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LuaMgr.GetInstance().Init();
        LuaMgr.GetInstance().DoLuaFile("LuaMain");
        Action action = LuaMgr.GetInstance().Global.Get<Action>("fun");
        action();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
