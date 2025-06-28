using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABTest 
{
    private static ABTest instance = new ABTest();
    public static ABTest Instance
    {
        get { return instance; }
    }
    private ABTest()
    {

    }
    private AssetBundle bundle=null;
    private AssetBundleManifest manifest=null;
    private Dictionary<string,AssetBundle> ABDic = new Dictionary<string,AssetBundle>();

    private string StrPath
    {
        get { return Application.streamingAssetsPath + "/";  }
    }
    /// <summary>
    /// ֱ�Ӷ�ȡ�����ܵ���ͬ������
    /// </summary>
    /// <param name="ABbao"></param>
    /// <param name="WenJian"></param>
    /// <returns></returns>
    public Object LoadRes(string ABbao,string WenJian)
    {
        //��Ϊ�ղ����       ����
        if (bundle == null)
        {
            bundle=AssetBundle.LoadFromFile(StrPath+ "First");
        }
        //�������������      �̶��ļ������������ȡ����
        manifest=bundle.LoadAsset<AssetBundleManifest>("AssetBundleManifest");
        string[] str = manifest.GetAllDependencies(ABbao);
        AssetBundle ab=null;
        for (int i = 0; i < str.Length; i++)
        {
            //����Ƿ���������     ������     ��û������ӵ�����ֵ䣬��ֹ�ظ�
            if (!ABDic.ContainsKey(str[i]))
            {
                 ab=AssetBundle.LoadFromFile(StrPath + str[i]);
                ABDic.Add(str[i], ab);
            }
        }
        //����Ƿ����������
        if (!ABDic.ContainsKey(ABbao))
        {
            ab = AssetBundle.LoadFromFile(StrPath + ABbao);
            ABDic.Add(ABbao, ab);
        }
        return ABDic[ABbao].LoadAsset(WenJian);
    }
    /// <summary>
    /// ָ��һ�����ͣ���ת����һ���̶ȼ�����ͬ������
    /// </summary>
    /// <param name="ABbao"></param>
    /// <param name="WenJian"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public Object LoadRes(string ABbao, string WenJian,System.Type type)
    {
        //��Ϊ�ղ����       ����
        if (bundle == null)
        {
            bundle = AssetBundle.LoadFromFile(StrPath + "First");
        }
        //�������������      �̶��ļ������������ȡ����
        manifest = bundle.LoadAsset<AssetBundleManifest>("AssetBundleManifest");
        string[] str = manifest.GetAllDependencies(ABbao);
        AssetBundle ab = null;
        for (int i = 0; i < str.Length; i++)
        {
            //����Ƿ���������     ������     ��û������ӵ�����ֵ䣬��ֹ�ظ�
            if (!ABDic.ContainsKey(str[i]))
            {
                ab = AssetBundle.LoadFromFile(StrPath + str[i]);
                ABDic.Add(str[i], ab);
            }
        }
        //����Ƿ����������
        if (!ABDic.ContainsKey(ABbao))
        {
            ab = AssetBundle.LoadFromFile(StrPath + ABbao);
            ABDic.Add(ABbao, ab);
        }
        return ABDic[ABbao].LoadAsset(WenJian,type);
    }
    /// <summary>
    /// ���÷��ͷ�ʽ
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="ABbao"></param>
    /// <param name="WenJian"></param>
    /// <returns></returns>
    public T LoadRes<T>(string ABbao, string WenJian) where T : Object 
    {
        //��Ϊ�ղ����       ����
        if (bundle == null)
        {
            bundle = AssetBundle.LoadFromFile(StrPath + "First");
        }
        //�������������      �̶��ļ������������ȡ����
        manifest = bundle.LoadAsset<AssetBundleManifest>("AssetBundleManifest");
        string[] str = manifest.GetAllDependencies(ABbao);
        AssetBundle ab = null;
        for (int i = 0; i < str.Length; i++)
        {
            //����Ƿ���������     ������     ��û������ӵ�����ֵ䣬��ֹ�ظ�
            if (!ABDic.ContainsKey(str[i]))
            {
                ab = AssetBundle.LoadFromFile(StrPath + str[i]);
                ABDic.Add(str[i], ab);
            }
        }
        //����Ƿ����������
        if (!ABDic.ContainsKey(ABbao))
        {
            ab = AssetBundle.LoadFromFile(StrPath + ABbao);
            ABDic.Add(ABbao, ab);
        }
        return ABDic[ABbao].LoadAsset<T>(WenJian);
    }
    public void RemoveRes(string ABbao)
    {
        ABDic[ABbao].Unload(false);
        ABDic.Remove(ABbao);
    }
    public void RemoveAllRes() 
    {
        AssetBundle.UnloadAllAssetBundles(false);
        ABDic.Clear();
        bundle=null;
        manifest=null;
    }
}
