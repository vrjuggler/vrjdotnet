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

// Generated from $Revision$ of $RCSfile$
using System;
using System.Runtime.InteropServices;
using System.Reflection;





namespace gmtl
{

public class Vec3f
   : gmtl.VecBase_float_3
{
   // Constructors.
   protected Vec3f(NoInitTag doInit)
      : base(doInit)
   {
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_Vec_float_3__Vec__();

   public Vec3f()
      : base(new NoInitTag())   // Do not initialize mRawObject in base class
   {
      mRawObject   = gmtl_Vec_float_3__Vec__();
      mWeOwnMemory = true;
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_Vec_float_3__Vec__gmtl_Vec3f([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(gmtl.Vec3fMarshaler))] gmtl.Vec3f p0);

   public Vec3f(gmtl.Vec3f p0)
      : base(new NoInitTag())   // Do not initialize mRawObject in base class
   {
      
      mRawObject   = gmtl_Vec_float_3__Vec__gmtl_Vec3f(p0);
      mWeOwnMemory = true;
      
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_Vec_float_3__Vec__gmtl_VecBase_float_3([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(gmtl.VecBase_float_3Marshaler))] gmtl.VecBase_float_3 p0);

   public Vec3f(gmtl.VecBase_float_3 p0)
      : base(new NoInitTag())   // Do not initialize mRawObject in base class
   {
      
      mRawObject   = gmtl_Vec_float_3__Vec__gmtl_VecBase_float_3(p0);
      mWeOwnMemory = true;
      
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_Vec_float_3__Vec__float_float(ref float p0,
	ref float p1);

   public Vec3f(ref float p0, ref float p1)
      : base(new NoInitTag())   // Do not initialize mRawObject in base class
   {
      
      
      mRawObject   = gmtl_Vec_float_3__Vec__float_float(ref p0, ref p1);
      mWeOwnMemory = true;
      
      
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_Vec_float_3__Vec__float_float_float(ref float p0,
	ref float p1,
	ref float p2);

   public Vec3f(ref float p0, ref float p1, ref float p2)
      : base(new NoInitTag())   // Do not initialize mRawObject in base class
   {
      
      
      
      mRawObject   = gmtl_Vec_float_3__Vec__float_float_float(ref p0, ref p1, ref p2);
      mWeOwnMemory = true;
      
      
      
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_Vec_float_3__Vec__float_float_float_float(ref float p0,
	ref float p1,
	ref float p2,
	ref float p3);

   public Vec3f(ref float p0, ref float p1, ref float p2, ref float p3)
      : base(new NoInitTag())   // Do not initialize mRawObject in base class
   {
      
      
      
      
      mRawObject   = gmtl_Vec_float_3__Vec__float_float_float_float(ref p0, ref p1, ref p2, ref p3);
      mWeOwnMemory = true;
      
      
      
      
   }

   // Internal constructor needed for marshaling purposes.
   internal Vec3f(IntPtr instPtr, bool ownMemory)
      : base(new NoInitTag())
   {
      mRawObject   = instPtr;
      mWeOwnMemory = ownMemory;
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static void delete_gmtl_Vec3f(IntPtr obj);

   // Destructor.
   ~Vec3f()
   {
      if ( mWeOwnMemory && IntPtr.Zero != mRawObject )
      {
         delete_gmtl_Vec3f(mRawObject);
         mWeOwnMemory = false;
         mRawObject   = IntPtr.Zero;
      }
   }

   // Operator overloads.


   // Nested enumeration gmtl.Vec<float,3>.Params.
   public enum Params
   {
      Size = 3
   };


} // class gmtl.Vec3f

/// <summary>
/// Custom marshaler for gmtl.Vec3f.  Use this with P/Invoke
/// calls when a C# object of this type needs to be passed to native code or
/// vice versa.  Essentially, this marshaler hides the existence of mRawObject.
/// </summary>
public class Vec3fMarshaler : ICustomMarshaler
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
      return ((gmtl.Vec3f) obj).mRawObject;
   }

   // Marshaling for native memory coming from C++.
   public Object MarshalNativeToManaged(IntPtr nativeObj)
   {
      return new gmtl.Vec3f(nativeObj, false);
   }

   public static ICustomMarshaler GetInstance(string cookie)
   {
      return mInstance;
   }

   private static Vec3fMarshaler mInstance = new Vec3fMarshaler();
}


} // namespace gmtl
