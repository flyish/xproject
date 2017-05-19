﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_TweenAction : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"TweenAction");
		addMember(l,0,"MOVE_X");
		addMember(l,1,"MOVE_Y");
		addMember(l,2,"MOVE_Z");
		addMember(l,3,"MOVE_LOCAL_X");
		addMember(l,4,"MOVE_LOCAL_Y");
		addMember(l,5,"MOVE_LOCAL_Z");
		addMember(l,6,"MOVE_CURVED");
		addMember(l,7,"MOVE_CURVED_LOCAL");
		addMember(l,8,"MOVE_SPLINE");
		addMember(l,9,"MOVE_SPLINE_LOCAL");
		addMember(l,10,"SCALE_X");
		addMember(l,11,"SCALE_Y");
		addMember(l,12,"SCALE_Z");
		addMember(l,13,"ROTATE_X");
		addMember(l,14,"ROTATE_Y");
		addMember(l,15,"ROTATE_Z");
		addMember(l,16,"ROTATE_AROUND");
		addMember(l,17,"ROTATE_AROUND_LOCAL");
		addMember(l,18,"CANVAS_ROTATEAROUND");
		addMember(l,19,"CANVAS_ROTATEAROUND_LOCAL");
		addMember(l,20,"CANVAS_PLAYSPRITE");
		addMember(l,21,"ALPHA");
		addMember(l,22,"TEXT_ALPHA");
		addMember(l,23,"CANVAS_ALPHA");
		addMember(l,24,"CANVASGROUP_ALPHA");
		addMember(l,25,"ALPHA_VERTEX");
		addMember(l,26,"COLOR");
		addMember(l,27,"CALLBACK_COLOR");
		addMember(l,28,"TEXT_COLOR");
		addMember(l,29,"CANVAS_COLOR");
		addMember(l,30,"CANVAS_FILLAMOUNT");
		addMember(l,31,"CANVAS_MOVE_X");
		addMember(l,32,"CANVAS_MOVE_Y");
		addMember(l,33,"CANVAS_MOVE_Z");
		addMember(l,34,"CALLBACK");
		addMember(l,35,"MOVE");
		addMember(l,36,"MOVE_LOCAL");
		addMember(l,37,"MOVE_TO_TRANSFORM");
		addMember(l,38,"ROTATE");
		addMember(l,39,"ROTATE_LOCAL");
		addMember(l,40,"SCALE");
		addMember(l,41,"VALUE3");
		addMember(l,42,"GUI_MOVE");
		addMember(l,43,"GUI_MOVE_MARGIN");
		addMember(l,44,"GUI_SCALE");
		addMember(l,45,"GUI_ALPHA");
		addMember(l,46,"GUI_ROTATE");
		addMember(l,47,"DELAYED_SOUND");
		addMember(l,48,"CANVAS_MOVE");
		addMember(l,49,"CANVAS_SCALE");
		LuaDLL.lua_pop(l, 1);
	}
}
