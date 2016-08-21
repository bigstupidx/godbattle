/*************************************************************************
 *  FileName: LuaService.cs
 *  Author: xClouder
 *  Create Time: 07/21/2016
 *  Description:
 *
 *************************************************************************/

using UnityEngine;
using System.Collections;
using uFrame.Kernel;
using SLua;

public class LuaService : SystemServiceMonoBehavior
{
	private LuaSvr l;

	public override IEnumerator SetupAsync ()
	{
		Debug.Log ("~~~ setup Lua Service");

		yield return base.SetupAsync ();

		l = new LuaSvr();
		bool _isLoaded = false;

		LuaState.loaderDelegate = LoadLuaFile;

		l.init (null, () => {
			_isLoaded = true;	
		});

		while (!_isLoaded)
			yield return null;


		//Init lua libs
		RunString("require \"core/Init\"");

		Debug.Log ("Lua Service setup completed.");

	}

	private byte[] LoadLuaFile(string name)
	{
		var path = name.IndexOf('/') < 0 ? "AssetBundles/lua/default/" + name : "AssetBundles/lua/" + name; 

		var asset = ResourceMgr.Get<TextAsset>(path);
		return asset.bytes;
	}

	public object RunFile(string name)
	{
		return l.luaState.doFile(name);
	}

	public object CallFunction(string funcName, params object[] args)
	{
		LuaFunction func = l.luaState.getFunction(funcName);

		if (func != null) {
			return func.call(args);
		}

		return null;
	}

	public object RunString(string code)
	{
		return l.luaState.doString(code);
	}
}