﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_LTSpline : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			LTSpline o;
			UnityEngine.Vector3[] a1;
			checkArray(l,2,out a1);
			o=new LTSpline(a1);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int map(IntPtr l) {
		try {
			LTSpline self=(LTSpline)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			var ret=self.map(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int interp(IntPtr l) {
		try {
			LTSpline self=(LTSpline)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			var ret=self.interp(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int point(IntPtr l) {
		try {
			LTSpline self=(LTSpline)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			var ret=self.point(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int place2d(IntPtr l) {
		try {
			LTSpline self=(LTSpline)checkSelf(l);
			UnityEngine.Transform a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.place2d(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int placeLocal2d(IntPtr l) {
		try {
			LTSpline self=(LTSpline)checkSelf(l);
			UnityEngine.Transform a1;
			checkType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			self.placeLocal2d(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int place(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				LTSpline self=(LTSpline)checkSelf(l);
				UnityEngine.Transform a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.place(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				LTSpline self=(LTSpline)checkSelf(l);
				UnityEngine.Transform a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,4,out a3);
				self.place(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function place to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int placeLocal(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==3){
				LTSpline self=(LTSpline)checkSelf(l);
				UnityEngine.Transform a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				self.placeLocal(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==4){
				LTSpline self=(LTSpline)checkSelf(l);
				UnityEngine.Transform a1;
				checkType(l,2,out a1);
				System.Single a2;
				checkType(l,3,out a2);
				UnityEngine.Vector3 a3;
				checkType(l,4,out a3);
				self.placeLocal(a1,a2,a3);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function placeLocal to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int gizmoDraw(IntPtr l) {
		try {
			LTSpline self=(LTSpline)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.gizmoDraw(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_DISTANCE_COUNT(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,LTSpline.DISTANCE_COUNT);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_DISTANCE_COUNT(IntPtr l) {
		try {
			System.Int32 v;
			checkType(l,2,out v);
			LTSpline.DISTANCE_COUNT=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_SUBLINE_COUNT(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,LTSpline.SUBLINE_COUNT);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_SUBLINE_COUNT(IntPtr l) {
		try {
			System.Int32 v;
			checkType(l,2,out v);
			LTSpline.SUBLINE_COUNT=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_pts(IntPtr l) {
		try {
			LTSpline self=(LTSpline)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.pts);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_pts(IntPtr l) {
		try {
			LTSpline self=(LTSpline)checkSelf(l);
			UnityEngine.Vector3[] v;
			checkArray(l,2,out v);
			self.pts=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_ptsAdj(IntPtr l) {
		try {
			LTSpline self=(LTSpline)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.ptsAdj);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_ptsAdj(IntPtr l) {
		try {
			LTSpline self=(LTSpline)checkSelf(l);
			UnityEngine.Vector3[] v;
			checkArray(l,2,out v);
			self.ptsAdj=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_ptsAdjLength(IntPtr l) {
		try {
			LTSpline self=(LTSpline)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.ptsAdjLength);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_ptsAdjLength(IntPtr l) {
		try {
			LTSpline self=(LTSpline)checkSelf(l);
			System.Int32 v;
			checkType(l,2,out v);
			self.ptsAdjLength=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_orientToPath(IntPtr l) {
		try {
			LTSpline self=(LTSpline)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.orientToPath);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_orientToPath(IntPtr l) {
		try {
			LTSpline self=(LTSpline)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.orientToPath=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_orientToPath2d(IntPtr l) {
		try {
			LTSpline self=(LTSpline)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.orientToPath2d);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_orientToPath2d(IntPtr l) {
		try {
			LTSpline self=(LTSpline)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.orientToPath2d=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"LTSpline");
		addMember(l,map);
		addMember(l,interp);
		addMember(l,point);
		addMember(l,place2d);
		addMember(l,placeLocal2d);
		addMember(l,place);
		addMember(l,placeLocal);
		addMember(l,gizmoDraw);
		addMember(l,"DISTANCE_COUNT",get_DISTANCE_COUNT,set_DISTANCE_COUNT,false);
		addMember(l,"SUBLINE_COUNT",get_SUBLINE_COUNT,set_SUBLINE_COUNT,false);
		addMember(l,"pts",get_pts,set_pts,true);
		addMember(l,"ptsAdj",get_ptsAdj,set_ptsAdj,true);
		addMember(l,"ptsAdjLength",get_ptsAdjLength,set_ptsAdjLength,true);
		addMember(l,"orientToPath",get_orientToPath,set_orientToPath,true);
		addMember(l,"orientToPath2d",get_orientToPath2d,set_orientToPath2d,true);
		createTypeMetatable(l,constructor, typeof(LTSpline));
	}
}
