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

public class VecBase_float_4
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
   protected VecBase_float_4(NoInitTag doInit)
   {
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_VecBase_float_4__VecBase__0();

   public VecBase_float_4()
   {
      mRawObject   = gmtl_VecBase_float_4__VecBase__0();
      mWeOwnMemory = true;
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_VecBase_float_4__VecBase__gmtl_VecBase_float_41([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(gmtl.VecBase_float_4Marshaler))] gmtl.VecBase_float_4 p0);

   public VecBase_float_4(gmtl.VecBase_float_4 p0)
   {
      mRawObject   = gmtl_VecBase_float_4__VecBase__gmtl_VecBase_float_41(p0);
      mWeOwnMemory = true;
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_VecBase_float_4__VecBase__float_float_float_float4(float p0, float p1, float p2, float p3);

   public VecBase_float_4(float p0, float p1, float p2, float p3)
   {
      mRawObject   = gmtl_VecBase_float_4__VecBase__float_float_float_float4(p0, p1, p2, p3);
      mWeOwnMemory = true;
   }

   // Internal constructor needed for marshaling purposes.
   internal VecBase_float_4(IntPtr instPtr, bool ownMemory)
   {
      mRawObject   = instPtr;
      mWeOwnMemory = ownMemory;
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static void delete_gmtl_VecBase_float_4(IntPtr obj);

   // Destructor.
   ~VecBase_float_4()
   {
      if ( mWeOwnMemory && IntPtr.Zero != mRawObject )
      {
         delete_gmtl_VecBase_float_4(mRawObject);
         mWeOwnMemory = false;
         mRawObject   = IntPtr.Zero;
      }
   }

   // Operator overloads.

   // Converter operators.

   // Start of non-virtual methods.
   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static void gmtl_VecBase_float_4__set__float1(IntPtr obj,
	float p0);

   public  void set(float p0)
   {
      gmtl_VecBase_float_4__set__float1(mRawObject, p0);
   }


   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static void gmtl_VecBase_float_4__set__float_float_float_float4(IntPtr obj,
	float p0,
	float p1,
	float p2,
	float p3);

   public  void set(float p0, float p1, float p2, float p3)
   {
      gmtl_VecBase_float_4__set__float_float_float_float4(mRawObject, p0, p1, p2, p3);
   }


   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static void gmtl_VecBase_float_4__getData__0(IntPtr obj,
	[In, Out] float[] arrayHolder);

   public  float[] getData()
   {
      float[] array_holder = new float[4];
      gmtl_VecBase_float_4__getData__0(mRawObject, array_holder);
      return array_holder;
   }


   // End of non-virtual methods.

   // Nested enumeration gmtl.VecBase<float,4>.Params.
   public enum Params
   {
      Size = 4
   };


} // class gmtl.VecBase_float_4

/// <summary>
/// Custom marshaler for gmtl.VecBase_float_4.  Use this with P/Invoke
/// calls when a C# object of this type needs to be passed to native code or
/// vice versa.  Essentially, this marshaler hides the existence of mRawObject.
/// </summary>
public class VecBase_float_4Marshaler : ICustomMarshaler
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
      return ((gmtl.VecBase_float_4) obj).RawObject;
   }

   // Marshaling for native memory coming from C++.
   public Object MarshalNativeToManaged(IntPtr nativeObj)
   {
      return new gmtl.VecBase_float_4(nativeObj, false);
   }

   public static ICustomMarshaler GetInstance(string cookie)
   {
      return mInstance;
   }

   private static VecBase_float_4Marshaler mInstance = new VecBase_float_4Marshaler();
}


} // namespace gmtl
