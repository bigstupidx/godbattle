using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_HumanBodyBones : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.HumanBodyBones");
		addMember(l,0,"Hips");
		addMember(l,1,"LeftUpperLeg");
		addMember(l,2,"RightUpperLeg");
		addMember(l,3,"LeftLowerLeg");
		addMember(l,4,"RightLowerLeg");
		addMember(l,5,"LeftFoot");
		addMember(l,6,"RightFoot");
		addMember(l,7,"Spine");
		addMember(l,8,"Chest");
		addMember(l,9,"Neck");
		addMember(l,10,"Head");
		addMember(l,11,"LeftShoulder");
		addMember(l,12,"RightShoulder");
		addMember(l,13,"LeftUpperArm");
		addMember(l,14,"RightUpperArm");
		addMember(l,15,"LeftLowerArm");
		addMember(l,16,"RightLowerArm");
		addMember(l,17,"LeftHand");
		addMember(l,18,"RightHand");
		addMember(l,19,"LeftToes");
		addMember(l,20,"RightToes");
		addMember(l,21,"LeftEye");
		addMember(l,22,"RightEye");
		addMember(l,23,"Jaw");
		addMember(l,24,"LeftThumbProximal");
		addMember(l,25,"LeftThumbIntermediate");
		addMember(l,26,"LeftThumbDistal");
		addMember(l,27,"LeftIndexProximal");
		addMember(l,28,"LeftIndexIntermediate");
		addMember(l,29,"LeftIndexDistal");
		addMember(l,30,"LeftMiddleProximal");
		addMember(l,31,"LeftMiddleIntermediate");
		addMember(l,32,"LeftMiddleDistal");
		addMember(l,33,"LeftRingProximal");
		addMember(l,34,"LeftRingIntermediate");
		addMember(l,35,"LeftRingDistal");
		addMember(l,36,"LeftLittleProximal");
		addMember(l,37,"LeftLittleIntermediate");
		addMember(l,38,"LeftLittleDistal");
		addMember(l,39,"RightThumbProximal");
		addMember(l,40,"RightThumbIntermediate");
		addMember(l,41,"RightThumbDistal");
		addMember(l,42,"RightIndexProximal");
		addMember(l,43,"RightIndexIntermediate");
		addMember(l,44,"RightIndexDistal");
		addMember(l,45,"RightMiddleProximal");
		addMember(l,46,"RightMiddleIntermediate");
		addMember(l,47,"RightMiddleDistal");
		addMember(l,48,"RightRingProximal");
		addMember(l,49,"RightRingIntermediate");
		addMember(l,50,"RightRingDistal");
		addMember(l,51,"RightLittleProximal");
		addMember(l,52,"RightLittleIntermediate");
		addMember(l,53,"RightLittleDistal");
		addMember(l,54,"LastBone");
		LuaDLL.lua_pop(l, 1);
	}
}