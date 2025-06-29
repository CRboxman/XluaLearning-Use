using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using XLua;

public class LuaMgr : BaseManager<LuaMgr>
{
    private LuaEnv luaEnv;
    public void Init()
    {
        if (luaEnv != null)
            return;
        luaEnv = new LuaEnv();
        luaEnv.AddLoader(MyLoader);
        luaEnv.AddLoader(MyLoaderAB);
    }
    /// <summary>
    /// 重定向asset文件夹下的lua文件的加载方式
    /// 
    /// </summary>
    /// <param name="filepath"></param>
    /// <returns></returns>
    private byte[] MyLoader(ref string filepath)
    {
        string path = Application.dataPath + "/Lua/" + filepath + ".lua";
        //Debug.Log(path);//  具体的文件的路径
        //Debug.Log(filepath);//    require的文件名
        if (File.Exists(path))
        {
            return File.ReadAllBytes(path);
        }
        else
        {
            Debug.LogError("自定义重定向没找到LUA文件： " + filepath);
        }
        return null;
    }
    /// <summary>
    /// 重定向AssetBundle文件夹下的lua文件的加载方式
    /// </summary>
    /// <param name="filepath"></param>
    /// <returns></returns>
    private byte[] MyLoaderAB(ref string filepath)
    {
        #region 传统方式
        //string path = Application.streamingAssetsPath + "/lua";
        //AssetBundle ab = AssetBundle.LoadFromFile(path);

        //TextAsset textAsset = ab.LoadAsset<TextAsset>(filepath + ".lua");
        //return textAsset.bytes;
        #endregion
        #region 使用自己写的AB包管理器
        TextAsset luaTextAsset = ABTest.Instance.LoadRes<TextAsset>("lua", filepath + ".lua");
        if (luaTextAsset != null)
            return luaTextAsset.bytes;
        else
            Debug.LogError("通过AB包重定向没找到LUA文件：" + filepath);
        return null;
        #endregion
    }
    public void DoString(string str)
    {
        if (luaEnv == null)
        {
            Debug.Log("未实例化解析器");
        }
        luaEnv.DoString(str);
    }
    public void Tick()
    {
        if (luaEnv != null)
        {
            luaEnv.Tick();
        }
        else
        {
            Debug.Log("未实例化解析器");
        }
    }
    public void Dispose()
    {
        if (luaEnv != null)
        {
            luaEnv.Dispose();
            luaEnv = null;
        }
        else
        {
            Debug.Log("未实例化解析器");
        }
    }
}
