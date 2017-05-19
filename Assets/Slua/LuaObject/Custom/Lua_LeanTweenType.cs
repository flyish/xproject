﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_LeanTweenType : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"LeanTweenType");
		addMember(l,0,"notUsed");
		addMember(l,1,"linear");
		addMember(l,2,"easeOutQuad");
		addMember(l,3,"easeInQuad");
		addMember(l,4,"easeInOutQuad");
		addMember(l,5,"easeInCubic");
		addMember(l,6,"easeOutCubic");
		addMember(l,7,"easeInOutCubic");
		addMember(l,8,"easeInQuart");
		addMember(l,9,"easeOutQuart");
		addMember(l,10,"easeInOutQuart");
		addMember(l,11,"easeInQuint");
		addMember(l,12,"easeOutQuint");
		addMember(l,13,"easeInOutQuint");
		addMember(l,14,"easeInSine");
		addMember(l,15,"easeOutSine");
		addMember(l,16,"easeInOutSine");
		addMember(l,17,"easeInExpo");
		addMember(l,18,"easeOutExpo");
		addMember(l,19,"easeInOutExpo");
		addMember(l,20,"easeInCirc");
		addMember(l,21,"easeOutCirc");
		addMember(l,22,"easeInOutCirc");
		addMember(l,23,"easeInBounce");
		addMember(l,24,"easeOutBounce");
		addMember(l,25,"easeInOutBounce");
		addMember(l,26,"easeInBack");
		addMember(l,27,"easeOutBack");
		addMember(l,28,"easeInOutBack");
		addMember(l,29,"easeInElastic");
		addMember(l,30,"easeOutElastic");
		addMember(l,31,"easeInOutElastic");
		addMember(l,32,"easeSpring");
		addMember(l,33,"easeShake");
		addMember(l,34,"punch");
		addMember(l,35,"once");
		addMember(l,36,"clamp");
		addMember(l,37,"pingPong");
		addMember(l,38,"animationCurve");
		LuaDLL.lua_pop(l, 1);
	}
}
