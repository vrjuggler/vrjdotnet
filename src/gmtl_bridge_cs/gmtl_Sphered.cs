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

public sealed class Sphered
{
   private IntPtr mRawObject = IntPtr.Zero;
   private bool mWeOwnMemory = false;

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
   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_Sphere_double__Sphere__0();

   public Sphered()
   {
      mRawObject   = gmtl_Sphere_double__Sphere__0();
      mWeOwnMemory = true;
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_Sphere_double__Sphere__gmtl_Point3d_double2([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(gmtl.Point3dMarshaler))] gmtl.Point3d p0, double p1);

   public Sphered(gmtl.Point3d p0, double p1)
   {
      mRawObject   = gmtl_Sphere_double__Sphere__gmtl_Point3d_double2(p0, p1);
      mWeOwnMemory = true;
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_Sphere_double__Sphere__gmtl_Sphered1([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(gmtl.SpheredMarshaler))] gmtl.Sphered p0);

   public Sphered(gmtl.Sphered p0)
   {
      mRawObject   = gmtl_Sphere_double__Sphere__gmtl_Sphered1(p0);
      mWeOwnMemory = true;
   }

   // Internal constructor needed for marshaling purposes.
   internal Sphered(IntPtr instPtr, bool ownMemory)
   {
      mRawObject   = instPtr;
      mWeOwnMemory = ownMemory;
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static void delete_gmtl_Sphered(IntPtr obj);

   // Destructor.
   ~Sphered()
   {
      if ( mWeOwnMemory && IntPtr.Zero != mRawObject )
      {
         delete_gmtl_Sphered(mRawObject);
         mWeOwnMemory = false;
         mRawObject   = IntPtr.Zero;
      }
   }

   // Operator overloads.

   // Converter operators.

   // Start of non-virtual methods.
   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   [return : MarshalAs(UnmanagedType.CustomMarshaler,
                       MarshalTypeRef = typeof(gmtl.Point3dMarshaler))]
   private extern static gmtl.Point3d gmtl_Sphere_double__getCenter__0(IntPtr obj);

   public  gmtl.Point3d getCenter()
   {
      gmtl.Point3d result;
      result = gmtl_Sphere_double__getCenter__0(mRawObject);
      return result;
   }


   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static double gmtl_Sphere_double__getRadius__0(IntPtr obj);

   public  double getRadius()
   {
      double result;
      result = gmtl_Sphere_double__getRadius__0(mRawObject);
      return result;
   }


   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static void gmtl_Sphere_double__setCenter__gmtl_Point3d1(IntPtr obj,
	[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(gmtl.Point3dMarshaler))] gmtl.Point3d p0);

   public  void setCenter(gmtl.Point3d p0)
   {
      gmtl_Sphere_double__setCenter__gmtl_Point3d1(mRawObject, p0);
   }


   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static void gmtl_Sphere_double__setRadius__double1(IntPtr obj,
	double p0);

   public  void setRadius(double p0)
   {
      gmtl_Sphere_double__setRadius__double1(mRawObject, p0);
   }


   // End of non-virtual methods.

   // Start of virtual methods.
   // End of virtual methods.


} // class gmtl.Sphered

/// <summary>
/// Custom marshaler for gmtl.Sphered.  Use this with P/Invoke
/// calls when a C# object of this type needs to be passed to native code or
/// vice versa.  Essentially, this marshaler hides the existence of mRawObject.
/// </summary>
public class SpheredMarshaler : ICustomMarshaler
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
      return ((gmtl.Sphered) obj).RawObject;
   }

   // Marshaling for native memory coming from C++.
   public Object MarshalNativeToManaged(IntPtr nativeObj)
   {
      return new gmtl.Sphered(nativeObj, false);
   }

   public static ICustomMarshaler GetInstance(string cookie)
   {
      return mInstance;
   }

   private static SpheredMarshaler mInstance = new SpheredMarshaler();
}


} // namespace gmtl
