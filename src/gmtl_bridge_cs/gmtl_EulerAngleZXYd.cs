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

public sealed class EulerAngleZXYd
{
   protected internal IntPtr mRawObject = IntPtr.Zero;
   protected bool mWeOwnMemory = false;
   protected class NoInitTag {}

   internal IntPtr RawObject
   {
      get { return mRawObject; }
   }

   // Constructors.
   protected EulerAngleZXYd(NoInitTag doInit)
   {
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_EulerAngle_double_gmtl_ZXY__EulerAngle__();

   public EulerAngleZXYd()
   {
      mRawObject   = gmtl_EulerAngle_double_gmtl_ZXY__EulerAngle__();
      mWeOwnMemory = true;
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_EulerAngle_double_gmtl_ZXY__EulerAngle__gmtl_EulerAngleZXYd([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(gmtl.EulerAngleZXYdMarshaler))] gmtl.EulerAngleZXYd p0);

   public EulerAngleZXYd(gmtl.EulerAngleZXYd p0)
   {
      
      mRawObject   = gmtl_EulerAngle_double_gmtl_ZXY__EulerAngle__gmtl_EulerAngleZXYd(p0);
      mWeOwnMemory = true;
      
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_EulerAngle_double_gmtl_ZXY__EulerAngle__double_double_double(double p0,
	double p1,
	double p2);

   public EulerAngleZXYd(double p0, double p1, double p2)
   {
      mRawObject   = gmtl_EulerAngle_double_gmtl_ZXY__EulerAngle__double_double_double(p0, p1, p2);
      mWeOwnMemory = true;
   }

   // Internal constructor needed for marshaling purposes.
   internal EulerAngleZXYd(IntPtr instPtr, bool ownMemory)
   {
      mRawObject   = instPtr;
      mWeOwnMemory = ownMemory;
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static void delete_gmtl_EulerAngleZXYd(IntPtr obj);

   // Destructor.
   ~EulerAngleZXYd()
   {
      if ( mWeOwnMemory && IntPtr.Zero != mRawObject )
      {
         delete_gmtl_EulerAngleZXYd(mRawObject);
         mWeOwnMemory = false;
         mRawObject   = IntPtr.Zero;
      }
   }

   // Operator overloads.

   // Converter operators.

   // Start of non-virtual methods.
   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static void gmtl_EulerAngle_double_gmtl_ZXY__set__double_double_double(IntPtr obj,
	ref double p0,
	ref double p1,
	ref double p2);

   public  void set(ref double p0, ref double p1, ref double p2)
   {
      
      
      
      gmtl_EulerAngle_double_gmtl_ZXY__set__double_double_double(mRawObject, ref p0, ref p1, ref p2);
      
      
      
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static double gmtl_EulerAngle_double_gmtl_ZXY__getData__(IntPtr obj);

   public  double getData()
   {
      double result;
      result = gmtl_EulerAngle_double_gmtl_ZXY__getData__(mRawObject);
      return result;
   }

/*
   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static double gmtl_EulerAngle_double_gmtl_ZXY__getData__(IntPtr obj);

   public  double getData()
   {
      double result;
      result = gmtl_EulerAngle_double_gmtl_ZXY__getData__(mRawObject);
      return result;
   }
*/

   // End of non-virtual methods.

   // Start of virtual methods.
   // End of virtual methods.

   // Nested enumeration gmtl.EulerAngle<double,gmtl.ZXY>.Params.
   public enum Params
   {
      Order = 2, Size = 3
   };


} // class gmtl.EulerAngleZXYd

/// <summary>
/// Custom marshaler for gmtl.EulerAngleZXYd.  Use this with P/Invoke
/// calls when a C# object of this type needs to be passed to native code or
/// vice versa.  Essentially, this marshaler hides the existence of mRawObject.
/// </summary>
public class EulerAngleZXYdMarshaler : ICustomMarshaler
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
      return ((gmtl.EulerAngleZXYd) obj).mRawObject;
   }

   // Marshaling for native memory coming from C++.
   public Object MarshalNativeToManaged(IntPtr nativeObj)
   {
      return new gmtl.EulerAngleZXYd(nativeObj, false);
   }

   public static ICustomMarshaler GetInstance(string cookie)
   {
      return mInstance;
   }

   private static EulerAngleZXYdMarshaler mInstance = new EulerAngleZXYdMarshaler();
}


} // namespace gmtl