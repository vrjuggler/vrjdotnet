#region License
// VRJ.NET is (C) Copyright 2004-2007 by Patrick Hartling
// Distributed under the GNU Lesser General Public License 2.1.  (See
// accompanying file COPYING.txt or http://www.gnu.org/copyleft/lesser.txt)
#endregion License

// Generated from Revision: 1.78 of RCSfile: class_cs.tmpl,v
using System;
using System.Runtime.InteropServices;
using System.Reflection;





namespace gmtl
{

public class VecBase_double_3
{
   protected IntPtr mRawObject = IntPtr.Zero;
   protected bool mWeOwnMemory = false;
   protected class NoInitTag {}

   /// <summary>
   /// This is needed for the custom marshaler to be able to perform a
   /// reflective lookup.  The custom marshaler also uses this method to get
   /// access to the value of mRawObject when necessary.
   /// </summary>
   public IntPtr RawObject
   {
      get { return mRawObject; }
   }

   // Constructors.
   protected VecBase_double_3(NoInitTag doInit)
   {
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_VecBase_double_3__VecBase__0();

   public VecBase_double_3()
   {
      mRawObject   = gmtl_VecBase_double_3__VecBase__0();
      mWeOwnMemory = true;
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_VecBase_double_3__VecBase__gmtl_VecBase_double_31([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(gmtl.VecBase_double_3Marshaler))] gmtl.VecBase_double_3 p0);

   public VecBase_double_3(gmtl.VecBase_double_3 p0)
   {
      mRawObject   = gmtl_VecBase_double_3__VecBase__gmtl_VecBase_double_31(p0);
      mWeOwnMemory = true;
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_VecBase_double_3__VecBase__double_double_double3(double p0, double p1, double p2);

   public VecBase_double_3(double p0, double p1, double p2)
   {
      mRawObject   = gmtl_VecBase_double_3__VecBase__double_double_double3(p0, p1, p2);
      mWeOwnMemory = true;
   }

   // Internal constructor needed for marshaling purposes.
   internal VecBase_double_3(IntPtr instPtr, bool ownMemory)
   {
      mRawObject   = instPtr;
      mWeOwnMemory = ownMemory;
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static void delete_gmtl_VecBase_double_3(IntPtr obj);

   // Destructor.
   ~VecBase_double_3()
   {
      if ( mWeOwnMemory && IntPtr.Zero != mRawObject )
      {
         delete_gmtl_VecBase_double_3(mRawObject);
         mWeOwnMemory = false;
         mRawObject   = IntPtr.Zero;
      }
   }

   // Operator overloads.

   // Converter operators.

   // Start of non-virtual methods.
   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static void gmtl_VecBase_double_3__set__double1(IntPtr obj,
	double p0);

   public  void set(double p0)
   {
      gmtl_VecBase_double_3__set__double1(mRawObject, p0);
   }


   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static void gmtl_VecBase_double_3__set__double_double_double3(IntPtr obj,
	double p0,
	double p1,
	double p2);

   public  void set(double p0, double p1, double p2)
   {
      gmtl_VecBase_double_3__set__double_double_double3(mRawObject, p0, p1, p2);
   }


   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static void gmtl_VecBase_double_3__getData__0(IntPtr obj,
	[In, Out] double[] arrayHolder);

   public  double[] getData()
   {
      double[] array_holder = new double[3];
      gmtl_VecBase_double_3__getData__0(mRawObject, array_holder);
      return array_holder;
   }


   // End of non-virtual methods.

   // Nested enumeration gmtl.VecBase<double,3>.Params.
   public enum Params
   {
      Size = 3
   };


} // class gmtl.VecBase_double_3

/// <summary>
/// Custom marshaler for gmtl.VecBase_double_3.  Use this with P/Invoke
/// calls when a C# object of this type needs to be passed to native code or
/// vice versa.  Essentially, this marshaler hides the existence of mRawObject.
/// </summary>
public class VecBase_double_3Marshaler : ICustomMarshaler
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
      return ((gmtl.VecBase_double_3) obj).RawObject;
   }

   // Marshaling for native memory coming from C++.
   public Object MarshalNativeToManaged(IntPtr nativeObj)
   {
      return new gmtl.VecBase_double_3(nativeObj, false);
   }

   public static ICustomMarshaler GetInstance(string cookie)
   {
      return mInstance;
   }

   private static VecBase_double_3Marshaler mInstance = new VecBase_double_3Marshaler();
}


} // namespace gmtl
