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

public sealed class AxisAngled
   : gmtl.VecBase_double_4
{
   // Constructors.
   protected AxisAngled(NoInitTag doInit)
      : base(doInit)
   {
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_AxisAngle_double__AxisAngle__();

   public AxisAngled()
      : base(new NoInitTag())   // Do not initialize mRawObject in base class
   {
      mRawObject   = gmtl_AxisAngle_double__AxisAngle__();
      mWeOwnMemory = true;
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_AxisAngle_double__AxisAngle__gmtl_AxisAngled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(gmtl.AxisAngledMarshaler))] gmtl.AxisAngled p0);

   public AxisAngled(gmtl.AxisAngled p0)
      : base(new NoInitTag())   // Do not initialize mRawObject in base class
   {
      
      mRawObject   = gmtl_AxisAngle_double__AxisAngle__gmtl_AxisAngled(p0);
      mWeOwnMemory = true;
      
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_AxisAngle_double__AxisAngle__double_double_double_double(ref double p0,
	ref double p1,
	ref double p2,
	ref double p3);

   public AxisAngled(ref double p0, ref double p1, ref double p2, ref double p3)
      : base(new NoInitTag())   // Do not initialize mRawObject in base class
   {
      
      
      
      
      mRawObject   = gmtl_AxisAngle_double__AxisAngle__double_double_double_double(ref p0, ref p1, ref p2, ref p3);
      mWeOwnMemory = true;
      
      
      
      
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_AxisAngle_double__AxisAngle__double_gmtl_Vec3d(ref double p0,
	[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(gmtl.Vec3dMarshaler))] gmtl.Vec3d p1);

   public AxisAngled(ref double p0, gmtl.Vec3d p1)
      : base(new NoInitTag())   // Do not initialize mRawObject in base class
   {
      
      
      mRawObject   = gmtl_AxisAngle_double__AxisAngle__double_gmtl_Vec3d(ref p0, p1);
      mWeOwnMemory = true;
      
      
   }

   // Internal constructor needed for marshaling purposes.
   internal AxisAngled(IntPtr instPtr, bool ownMemory)
      : base(new NoInitTag())
   {
      mRawObject   = instPtr;
      mWeOwnMemory = ownMemory;
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static void delete_gmtl_AxisAngled(IntPtr obj);

   // Destructor.
   ~AxisAngled()
   {
      if ( mWeOwnMemory && IntPtr.Zero != mRawObject )
      {
         delete_gmtl_AxisAngled(mRawObject);
         mWeOwnMemory = false;
         mRawObject   = IntPtr.Zero;
      }
   }

   // Operator overloads.

   // Converter operators.

   // Start of non-virtual methods.
   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static void gmtl_AxisAngle_double__set__double_double_double_double(IntPtr obj,
	ref double p0,
	ref double p1,
	ref double p2,
	ref double p3);

   public new void set(ref double p0, ref double p1, ref double p2, ref double p3)
   {
      
      
      
      
      gmtl_AxisAngle_double__set__double_double_double_double(mRawObject, ref p0, ref p1, ref p2, ref p3);
      
      
      
      
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static void gmtl_AxisAngle_double__set__double_gmtl_Vec3d(IntPtr obj,
	ref double p0,
	[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(gmtl.Vec3dMarshaler))] gmtl.Vec3d p1);

   public  void set(ref double p0, gmtl.Vec3d p1)
   {
      
      
      gmtl_AxisAngle_double__set__double_gmtl_Vec3d(mRawObject, ref p0, p1);
      
      
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static void gmtl_AxisAngle_double__setAxis__gmtl_Vec3d(IntPtr obj,
	[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(gmtl.Vec3dMarshaler))] gmtl.Vec3d p0);

   public  void setAxis(gmtl.Vec3d p0)
   {
      
      gmtl_AxisAngle_double__setAxis__gmtl_Vec3d(mRawObject, p0);
      
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static void gmtl_AxisAngle_double__setAngle__double(IntPtr obj,
	ref double p0);

   public  void setAngle(ref double p0)
   {
      
      gmtl_AxisAngle_double__setAngle__double(mRawObject, ref p0);
      
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   [return : MarshalAs(UnmanagedType.CustomMarshaler,
                       MarshalTypeRef = typeof(gmtl.Vec3dMarshaler))]
   private extern static gmtl.Vec3d gmtl_AxisAngle_double__getAxis__(IntPtr obj);

   public  gmtl.Vec3d getAxis()
   {
      gmtl.Vec3d result;
      result = gmtl_AxisAngle_double__getAxis__(mRawObject);
      return result;
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static double gmtl_AxisAngle_double__getAngle__(IntPtr obj);

   public  double getAngle()
   {
      double result;
      result = gmtl_AxisAngle_double__getAngle__(mRawObject);
      return result;
   }

   // End of non-virtual methods.

   // Start of virtual methods.
   // End of virtual methods.

   // Nested enumeration gmtl.AxisAngle<double>.Params.
   public enum Params
   {
      Size = 4
   };


} // class gmtl.AxisAngled

/// <summary>
/// Custom marshaler for gmtl.AxisAngled.  Use this with P/Invoke
/// calls when a C# object of this type needs to be passed to native code or
/// vice versa.  Essentially, this marshaler hides the existence of mRawObject.
/// </summary>
public class AxisAngledMarshaler : ICustomMarshaler
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
      return ((gmtl.AxisAngled) obj).mRawObject;
   }

   // Marshaling for native memory coming from C++.
   public Object MarshalNativeToManaged(IntPtr nativeObj)
   {
      return new gmtl.AxisAngled(nativeObj, false);
   }

   public static ICustomMarshaler GetInstance(string cookie)
   {
      return mInstance;
   }

   private static AxisAngledMarshaler mInstance = new AxisAngledMarshaler();
}


} // namespace gmtl