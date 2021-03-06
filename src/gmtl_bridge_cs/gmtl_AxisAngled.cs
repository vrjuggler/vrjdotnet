#region License
// VRJ.NET is (C) Copyright 2004-2007 by Patrick Hartling
// Distributed under the GNU Lesser General Public License 2.1.  (See
// accompanying file COPYING.txt or http://www.gnu.org/copyleft/lesser.txt)
#endregion License

// Generated from Revision: 1.79 of RCSfile: class_cs.tmpl,v
using System;
using System.Runtime.InteropServices;
using System.Reflection;





namespace gmtl
{

public sealed class AxisAngled
   : gmtl.VecBase_double_4
{
   // Constructors.
   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_AxisAngle_double__AxisAngle__0();

   public AxisAngled()
      : base(new NoInitTag())   // Do not initialize mRawObject in base class
   {
      mRawObject   = gmtl_AxisAngle_double__AxisAngle__0();
      mWeOwnMemory = true;
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_AxisAngle_double__AxisAngle__gmtl_AxisAngled1([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(gmtl.AxisAngledMarshaler))] gmtl.AxisAngled p0);

   public AxisAngled(gmtl.AxisAngled p0)
      : base(new NoInitTag())   // Do not initialize mRawObject in base class
   {
      mRawObject   = gmtl_AxisAngle_double__AxisAngle__gmtl_AxisAngled1(p0);
      mWeOwnMemory = true;
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_AxisAngle_double__AxisAngle__double_double_double_double4(double p0, double p1, double p2, double p3);

   public AxisAngled(double p0, double p1, double p2, double p3)
      : base(new NoInitTag())   // Do not initialize mRawObject in base class
   {
      mRawObject   = gmtl_AxisAngle_double__AxisAngle__double_double_double_double4(p0, p1, p2, p3);
      mWeOwnMemory = true;
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_AxisAngle_double__AxisAngle__double_gmtl_Vec3d2(double p0, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(gmtl.Vec3dMarshaler))] gmtl.Vec3d p1);

   public AxisAngled(double p0, gmtl.Vec3d p1)
      : base(new NoInitTag())   // Do not initialize mRawObject in base class
   {
      mRawObject   = gmtl_AxisAngle_double__AxisAngle__double_gmtl_Vec3d2(p0, p1);
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
   private extern static void gmtl_AxisAngle_double__set__double_double_double_double4(IntPtr obj,
	double p0,
	double p1,
	double p2,
	double p3);

   public new void set(double p0, double p1, double p2, double p3)
   {
      gmtl_AxisAngle_double__set__double_double_double_double4(mRawObject, p0, p1, p2, p3);
   }


   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static void gmtl_AxisAngle_double__set__double_gmtl_Vec3d2(IntPtr obj,
	double p0,
	[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(gmtl.Vec3dMarshaler))] gmtl.Vec3d p1);

   public new void set(double p0, gmtl.Vec3d p1)
   {
      gmtl_AxisAngle_double__set__double_gmtl_Vec3d2(mRawObject, p0, p1);
   }


   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static void gmtl_AxisAngle_double__setAxis__gmtl_Vec3d1(IntPtr obj,
	[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(gmtl.Vec3dMarshaler))] gmtl.Vec3d p0);

   public  void setAxis(gmtl.Vec3d p0)
   {
      gmtl_AxisAngle_double__setAxis__gmtl_Vec3d1(mRawObject, p0);
   }


   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static void gmtl_AxisAngle_double__setAngle__double1(IntPtr obj,
	double p0);

   public  void setAngle(double p0)
   {
      gmtl_AxisAngle_double__setAngle__double1(mRawObject, p0);
   }


   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   [return : MarshalAs(UnmanagedType.CustomMarshaler,
                       MarshalTypeRef = typeof(gmtl.Vec3dMarshaler))]
   private extern static gmtl.Vec3d gmtl_AxisAngle_double__getAxis__0(IntPtr obj);

   public  gmtl.Vec3d getAxis()
   {
      gmtl.Vec3d result;
      result = gmtl_AxisAngle_double__getAxis__0(mRawObject);
      return result;
   }


   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static double gmtl_AxisAngle_double__getAngle__0(IntPtr obj);

   public  double getAngle()
   {
      double result;
      result = gmtl_AxisAngle_double__getAngle__0(mRawObject);
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
      return ((gmtl.AxisAngled) obj).RawObject;
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
