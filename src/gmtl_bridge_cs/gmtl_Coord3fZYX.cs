/*************** <auto-copyright.pl BEGIN do not edit this line> **************
 *
 * VRJ.NET is (C) Copyright 2004 by Patrick Hartling
 *
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Library General Public
 * License as published by the Free Software Foundation; either
 * version 2 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Library General Public License for more details.
 *
 * You should have received a copy of the GNU Library General Public
 * License along with this library; if not, write to the
 * Free Software Foundation, Inc., 59 Temple Place - Suite 330,
 * Boston, MA 02111-1307, USA.
 *
 * -----------------------------------------------------------------
 * File:          $RCSfile$
 * Date modified: $Date$
 * Version:       $Revision$
 * -----------------------------------------------------------------
 *
 *************** <auto-copyright.pl END do not edit this line> ***************/

// Generated from Revision: 1.70 of RCSfile: class_cs.tmpl,v
using System;
using System.Runtime.InteropServices;
using System.Reflection;





namespace gmtl
{

public sealed class Coord3fZYX
{
   protected internal IntPtr mRawObject = IntPtr.Zero;
   protected bool mWeOwnMemory = false;
   protected class NoInitTag {}

   internal IntPtr RawObject
   {
      get { return mRawObject; }
   }

   // Constructors.
   protected Coord3fZYX(NoInitTag doInit)
   {
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_Coord_gmtl_Vec_float_3__gmtl_EulerAngle_float_gmtl_ZYX____Coord__();

   public Coord3fZYX()
   {
      mRawObject   = gmtl_Coord_gmtl_Vec_float_3__gmtl_EulerAngle_float_gmtl_ZYX____Coord__();
      mWeOwnMemory = true;
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_Coord_gmtl_Vec_float_3__gmtl_EulerAngle_float_gmtl_ZYX____Coord__gmtl_Coord3fZYX([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(gmtl.Coord3fZYXMarshaler))] gmtl.Coord3fZYX p0);

   public Coord3fZYX(gmtl.Coord3fZYX p0)
   {
      
      mRawObject   = gmtl_Coord_gmtl_Vec_float_3__gmtl_EulerAngle_float_gmtl_ZYX____Coord__gmtl_Coord3fZYX(p0);
      mWeOwnMemory = true;
      
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_Coord_gmtl_Vec_float_3__gmtl_EulerAngle_float_gmtl_ZYX____Coord__gmtl_Vec3f_gmtl_EulerAngleZYXf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(gmtl.Vec3fMarshaler))] gmtl.Vec3f p0,
	[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(gmtl.EulerAngleZYXfMarshaler))] gmtl.EulerAngleZYXf p1);

   public Coord3fZYX(gmtl.Vec3f p0, gmtl.EulerAngleZYXf p1)
   {
      
      
      mRawObject   = gmtl_Coord_gmtl_Vec_float_3__gmtl_EulerAngle_float_gmtl_ZYX____Coord__gmtl_Vec3f_gmtl_EulerAngleZYXf(p0, p1);
      mWeOwnMemory = true;
      
      
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_Coord_gmtl_Vec_float_3__gmtl_EulerAngle_float_gmtl_ZYX____Coord__float_float_float_float_float_float(float p0,
	float p1,
	float p2,
	float p3,
	float p4,
	float p5);

   public Coord3fZYX(float p0, float p1, float p2, float p3, float p4, float p5)
   {
      mRawObject   = gmtl_Coord_gmtl_Vec_float_3__gmtl_EulerAngle_float_gmtl_ZYX____Coord__float_float_float_float_float_float(p0, p1, p2, p3, p4, p5);
      mWeOwnMemory = true;
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_Coord_gmtl_Vec_float_3__gmtl_EulerAngle_float_gmtl_ZYX____Coord__float_float_float_float_float_float_float(float p0,
	float p1,
	float p2,
	float p3,
	float p4,
	float p5,
	float p6);

   public Coord3fZYX(float p0, float p1, float p2, float p3, float p4, float p5, float p6)
   {
      mRawObject   = gmtl_Coord_gmtl_Vec_float_3__gmtl_EulerAngle_float_gmtl_ZYX____Coord__float_float_float_float_float_float_float(p0, p1, p2, p3, p4, p5, p6);
      mWeOwnMemory = true;
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_Coord_gmtl_Vec_float_3__gmtl_EulerAngle_float_gmtl_ZYX____Coord__float_float_float_float_float_float_float_float(float p0,
	float p1,
	float p2,
	float p3,
	float p4,
	float p5,
	float p6,
	float p7);

   public Coord3fZYX(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7)
   {
      mRawObject   = gmtl_Coord_gmtl_Vec_float_3__gmtl_EulerAngle_float_gmtl_ZYX____Coord__float_float_float_float_float_float_float_float(p0, p1, p2, p3, p4, p5, p6, p7);
      mWeOwnMemory = true;
   }

   // Internal constructor needed for marshaling purposes.
   internal Coord3fZYX(IntPtr instPtr, bool ownMemory)
   {
      mRawObject   = instPtr;
      mWeOwnMemory = ownMemory;
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static void delete_gmtl_Coord3fZYX(IntPtr obj);

   // Destructor.
   ~Coord3fZYX()
   {
      if ( mWeOwnMemory && IntPtr.Zero != mRawObject )
      {
         delete_gmtl_Coord3fZYX(mRawObject);
         mWeOwnMemory = false;
         mRawObject   = IntPtr.Zero;
      }
   }

   // Operator overloads.

   // Converter operators.

   // Start of non-virtual methods.
   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   [return : MarshalAs(UnmanagedType.CustomMarshaler,
                       MarshalTypeRef = typeof(gmtl.Vec3fMarshaler))]
   private extern static gmtl.Vec3f gmtl_Coord_gmtl_Vec_float_3__gmtl_EulerAngle_float_gmtl_ZYX____getPos__(IntPtr obj);

   public  gmtl.Vec3f getPos()
   {
      gmtl.Vec3f result;
      result = gmtl_Coord_gmtl_Vec_float_3__gmtl_EulerAngle_float_gmtl_ZYX____getPos__(mRawObject);
      return result;
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   [return : MarshalAs(UnmanagedType.CustomMarshaler,
                       MarshalTypeRef = typeof(gmtl.EulerAngleZYXfMarshaler))]
   private extern static gmtl.EulerAngleZYXf gmtl_Coord_gmtl_Vec_float_3__gmtl_EulerAngle_float_gmtl_ZYX____getRot__(IntPtr obj);

   public  gmtl.EulerAngleZYXf getRot()
   {
      gmtl.EulerAngleZYXf result;
      result = gmtl_Coord_gmtl_Vec_float_3__gmtl_EulerAngle_float_gmtl_ZYX____getRot__(mRawObject);
      return result;
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   [return : MarshalAs(UnmanagedType.CustomMarshaler,
                       MarshalTypeRef = typeof(gmtl.Vec3fMarshaler))]
   private extern static gmtl.Vec3f gmtl_Coord_gmtl_Vec_float_3__gmtl_EulerAngle_float_gmtl_ZYX____pos__(IntPtr obj);

   public  gmtl.Vec3f pos()
   {
      gmtl.Vec3f result;
      result = gmtl_Coord_gmtl_Vec_float_3__gmtl_EulerAngle_float_gmtl_ZYX____pos__(mRawObject);
      return result;
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   [return : MarshalAs(UnmanagedType.CustomMarshaler,
                       MarshalTypeRef = typeof(gmtl.EulerAngleZYXfMarshaler))]
   private extern static gmtl.EulerAngleZYXf gmtl_Coord_gmtl_Vec_float_3__gmtl_EulerAngle_float_gmtl_ZYX____rot__(IntPtr obj);

   public  gmtl.EulerAngleZYXf rot()
   {
      gmtl.EulerAngleZYXf result;
      result = gmtl_Coord_gmtl_Vec_float_3__gmtl_EulerAngle_float_gmtl_ZYX____rot__(mRawObject);
      return result;
   }

   // End of non-virtual methods.

   // Start of virtual methods.
   // End of virtual methods.

   // Nested enumeration gmtl.Coord<gmtl.Vec<float,3>,gmtl.EulerAngle<float,gmtl.ZYX> >.Params.
   public enum Params
   {
      RotSize = 3, PosSize = 3
   };


} // class gmtl.Coord3fZYX

/// <summary>
/// Custom marshaler for gmtl.Coord3fZYX.  Use this with P/Invoke
/// calls when a C# object of this type needs to be passed to native code or
/// vice versa.  Essentially, this marshaler hides the existence of mRawObject.
/// </summary>
public class Coord3fZYXMarshaler : ICustomMarshaler
{
   public void CleanUpManagedData(Object obj)
   {
   }

   public void CleanUpNativeData(IntPtr nativeData)
   {
   }

   public int GetNativeDataSize()
   {
      return -1;
   }

   // Marshaling for managed data being passed to C++.
   public IntPtr MarshalManagedToNative(Object obj)
   {
      return ((gmtl.Coord3fZYX) obj).mRawObject;
   }

   // Marshaling for native memory coming from C++.
   public Object MarshalNativeToManaged(IntPtr nativeObj)
   {
      return new gmtl.Coord3fZYX(nativeObj, false);
   }

   public static ICustomMarshaler GetInstance(string cookie)
   {
      return mInstance;
   }

   private static Coord3fZYXMarshaler mInstance = new Coord3fZYXMarshaler();
}


} // namespace gmtl