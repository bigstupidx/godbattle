﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_NetworkService : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			NetworkService o;
			o=new NetworkService();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetupAsync(IntPtr l) {
		try {
			NetworkService self=(NetworkService)checkSelf(l);
			var ret=self.SetupAsync();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Send(IntPtr l) {
		try {
			NetworkService self=(NetworkService)checkSelf(l);
			Packet a1;
			checkType(l,2,out a1);
			self.Send(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_PacketHandler(IntPtr l) {
		try {
			NetworkService self=(NetworkService)checkSelf(l);
			NetworkService.PacketHandlerDelegate v;
			int op=LuaDelegation.checkDelegate(l,2,out v);
			if(op==0) self.PacketHandler=v;
			else if(op==1) self.PacketHandler+=v;
			else if(op==2) self.PacketHandler-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"NetworkService");
		addMember(l,SetupAsync);
		addMember(l,Send);
		addMember(l,"PacketHandler",null,set_PacketHandler,true);
		createTypeMetatable(l,constructor, typeof(NetworkService),typeof(uFrame.Kernel.SystemServiceMonoBehavior));
	}
}
