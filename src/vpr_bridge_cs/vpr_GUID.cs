#region License
// VRJ.NET is (C) Copyright 2004-2007 by Patrick Hartling
// Distributed under the GNU Lesser General Public License 2.1.  (See
// accompanying file COPYING.txt or http://www.gnu.org/copyleft/lesser.txt)
#endregion License

// Generated from Revision: 1.79 of RCSfile: class_cs.tmpl,v
using System;
using System.Runtime.InteropServices;
using System.Reflection;





namespace vpr
{

public sealed class GUID
   : vpr.SerializableObject
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

   private void allocDelegates()
   {
   }

   // Constructors.
   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr vpr_GUID_GUID__vpr_GUID_GenerateTag1([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(vpr.GUID.GenerateTagMarshaler))] vpr.GUID.GenerateTag p0);

   public GUID(vpr.GUID.GenerateTag p0)
   {
      allocDelegates();
      mRawObject   = vpr_GUID_GUID__vpr_GUID_GenerateTag1(p0);
      mWeOwnMemory = true;
   }

   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr vpr_GUID_GUID__0();

   public GUID()
   {
      allocDelegates();
      mRawObject   = vpr_GUID_GUID__0();
      mWeOwnMemory = true;
   }

   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr vpr_GUID_GUID__vpr_GUID_StdGUID1([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(vpr.GUID.StdGUIDMarshaler))] vpr.GUID.StdGUID p0);

   public GUID(vpr.GUID.StdGUID p0)
   {
      allocDelegates();
      mRawObject   = vpr_GUID_GUID__vpr_GUID_StdGUID1(p0);
      mWeOwnMemory = true;
   }

   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr vpr_GUID_GUID__std_string1(string p0);

   public GUID(string p0)
   {
      allocDelegates();
      mRawObject   = vpr_GUID_GUID__std_string1(p0);
      mWeOwnMemory = true;
   }

   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr vpr_GUID_GUID__vpr_GUID_std_string2([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(vpr.GUIDMarshaler))] vpr.GUID p0, string p1);

   public GUID(vpr.GUID p0, string p1)
   {
      allocDelegates();
      mRawObject   = vpr_GUID_GUID__vpr_GUID_std_string2(p0, p1);
      mWeOwnMemory = true;
   }

   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr vpr_GUID_GUID__vpr_GUID1([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(vpr.GUIDMarshaler))] vpr.GUID p0);

   public GUID(vpr.GUID p0)
   {
      allocDelegates();
      mRawObject   = vpr_GUID_GUID__vpr_GUID1(p0);
      mWeOwnMemory = true;
   }

   // Internal constructor needed for marshaling purposes.
   internal GUID(IntPtr instPtr, bool ownMemory)
   {
      mRawObject   = instPtr;
      mWeOwnMemory = ownMemory;
   }

   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static void delete_vpr_GUID(IntPtr obj);

   // Destructor.
   ~GUID()
   {
      if ( mWeOwnMemory && IntPtr.Zero != mRawObject )
      {
         delete_vpr_GUID(mRawObject);
         mWeOwnMemory = false;
         mRawObject   = IntPtr.Zero;
      }
   }

   // Operator overloads.

   public override bool Equals(object obj)
   {
      if ( ! (obj is vpr.GUID) )
      {
         return false;
      }
      return this == (vpr.GUID) obj;
   }

   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static bool vpr_GUID_equal__vpr_GUID(IntPtr lhs,
	[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(vpr.GUIDMarshaler))] vpr.GUID rhs);

   public static bool operator==(vpr.GUID lhs, vpr.GUID rhs)
   {
      bool result;
      result = vpr_GUID_equal__vpr_GUID(lhs.mRawObject, rhs);
      return result;
   }

   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static bool vpr_GUID_not_equal__vpr_GUID(IntPtr lhs,
	[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(vpr.GUIDMarshaler))] vpr.GUID rhs);

   public static bool operator!=(vpr.GUID lhs, vpr.GUID rhs)
   {
      bool result;
      result = vpr_GUID_not_equal__vpr_GUID(lhs.mRawObject, rhs);
      return result;
   }

   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static bool vpr_GUID_less_than__vpr_GUID(IntPtr lhs,
	[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(vpr.GUIDMarshaler))] vpr.GUID rhs);

   public static bool operator<(vpr.GUID lhs, vpr.GUID rhs)
   {
      bool result;
      result = vpr_GUID_less_than__vpr_GUID(lhs.mRawObject, rhs);
      return result;
   }

   public static bool operator>(vpr.GUID lhs, vpr.GUID rhs)
   {
      return (! (lhs < rhs) && ! (lhs == rhs));
   }

   // Converter operators.

   // Start of non-virtual methods.
   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static string vpr_GUID_toString__0(IntPtr obj);

   public  string toString()
   {
      string result;
      result = vpr_GUID_toString__0(mRawObject);
      return result;
   }


   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static void vpr_GUID_generate__0(IntPtr obj);

   public  void generate()
   {
      vpr_GUID_generate__0(mRawObject);
   }


   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static void vpr_GUID_generate__vpr_GUID_std_string2(IntPtr obj,
	[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(vpr.GUIDMarshaler))] vpr.GUID p0,
	string p1);

   public  void generate(vpr.GUID p0, string p1)
   {
      vpr_GUID_generate__vpr_GUID_std_string2(mRawObject, p0, p1);
   }


   // End of non-virtual methods.

   // Start of virtual methods.
   // End of virtual methods.

   // Start of virtual methods.
   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static void vpr_GUID_writeObject__vpr_ObjectWriter1(IntPtr obj,
	[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(vpr.ObjectWriterMarshaler))] vpr.ObjectWriter p0);

   public  void writeObject(vpr.ObjectWriter p0)
   {
      vpr_GUID_writeObject__vpr_ObjectWriter1(mRawObject, p0);
   }


   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static void vpr_GUID_readObject__vpr_ObjectReader1(IntPtr obj,
	[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(vpr.ObjectReaderMarshaler))] vpr.ObjectReader p0);

   public  void readObject(vpr.ObjectReader p0)
   {
      vpr_GUID_readObject__vpr_ObjectReader1(mRawObject, p0);
   }


   // End of virtual methods.

   // Start of static data.
   // Getter function for vpr.GUID.generateTag
   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr vpr_GUID_generateTag_get();

   // Setter function for vpr.GUID.generateTag
   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static void vpr_GUID_generateTag_set(IntPtr v);

   // Property for vpr.GUID.generateTag
   public static vpr.GUID.GenerateTag generateTag
   {
      get { return new vpr.GUID.GenerateTag(vpr_GUID_generateTag_get(), false); }
      set { vpr_GUID_generateTag_set(value.RawObject); }
   }

   // Getter function for vpr.GUID.NullGUID
   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr vpr_GUID_NullGUID_get();


   // Property for vpr.GUID.NullGUID
   public static vpr.GUID NullGUID
   {
      get { return new vpr.GUID(vpr_GUID_NullGUID_get(), false); }
   }

   // End of static data.


   // Nested class vpr.GUID.GenerateTag.
public class GenerateTag
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
   protected GenerateTag(NoInitTag doInit)
   {
   }

   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr vpr_GUID_GenerateTag_GenerateTag__vpr_GUID_GenerateTag1([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(vpr.GUID.GenerateTagMarshaler))] vpr.GUID.GenerateTag p0);

   public GenerateTag(vpr.GUID.GenerateTag p0)
   {
      mRawObject   = vpr_GUID_GenerateTag_GenerateTag__vpr_GUID_GenerateTag1(p0);
      mWeOwnMemory = true;
   }

   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr vpr_GUID_GenerateTag_GenerateTag__0();

   public GenerateTag()
   {
      mRawObject   = vpr_GUID_GenerateTag_GenerateTag__0();
      mWeOwnMemory = true;
   }

   // Internal constructor needed for marshaling purposes.
   internal GenerateTag(IntPtr instPtr, bool ownMemory)
   {
      mRawObject   = instPtr;
      mWeOwnMemory = ownMemory;
   }

   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static void delete_vpr_GUID_GenerateTag(IntPtr obj);

   // Destructor.
   ~GenerateTag()
   {
      if ( mWeOwnMemory && IntPtr.Zero != mRawObject )
      {
         delete_vpr_GUID_GenerateTag(mRawObject);
         mWeOwnMemory = false;
         mRawObject   = IntPtr.Zero;
      }
   }

   // Operator overloads.

   // Converter operators.


} // class vpr.GUID.GenerateTag

/// <summary>
/// Custom marshaler for vpr.GUID.GenerateTag.  Use this with P/Invoke
/// calls when a C# object of this type needs to be passed to native code or
/// vice versa.  Essentially, this marshaler hides the existence of mRawObject.
/// </summary>
public class GenerateTagMarshaler : ICustomMarshaler
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
      return ((vpr.GUID.GenerateTag) obj).RawObject;
   }

   // Marshaling for native memory coming from C++.
   public Object MarshalNativeToManaged(IntPtr nativeObj)
   {
      return new vpr.GUID.GenerateTag(nativeObj, false);
   }

   public static ICustomMarshaler GetInstance(string cookie)
   {
      return mInstance;
   }

   private static GenerateTagMarshaler mInstance = new GenerateTagMarshaler();
}


   // Nested class vpr.GUID.StdGUID.
public class StdGUID
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
   protected StdGUID(NoInitTag doInit)
   {
   }

   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr vpr_GUID_StdGUID_StdGUID__vpr_GUID_StdGUID1([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(vpr.GUID.StdGUIDMarshaler))] vpr.GUID.StdGUID p0);

   public StdGUID(vpr.GUID.StdGUID p0)
   {
      mRawObject   = vpr_GUID_StdGUID_StdGUID__vpr_GUID_StdGUID1(p0);
      mWeOwnMemory = true;
   }

   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr vpr_GUID_StdGUID_StdGUID__0();

   public StdGUID()
   {
      mRawObject   = vpr_GUID_StdGUID_StdGUID__0();
      mWeOwnMemory = true;
   }

   // Internal constructor needed for marshaling purposes.
   internal StdGUID(IntPtr instPtr, bool ownMemory)
   {
      mRawObject   = instPtr;
      mWeOwnMemory = ownMemory;
   }

   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static void delete_vpr_GUID_StdGUID(IntPtr obj);

   // Destructor.
   ~StdGUID()
   {
      if ( mWeOwnMemory && IntPtr.Zero != mRawObject )
      {
         delete_vpr_GUID_StdGUID(mRawObject);
         mWeOwnMemory = false;
         mRawObject   = IntPtr.Zero;
      }
   }

   // Operator overloads.

   // Converter operators.


} // class vpr.GUID.StdGUID

/// <summary>
/// Custom marshaler for vpr.GUID.StdGUID.  Use this with P/Invoke
/// calls when a C# object of this type needs to be passed to native code or
/// vice versa.  Essentially, this marshaler hides the existence of mRawObject.
/// </summary>
public class StdGUIDMarshaler : ICustomMarshaler
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
      return ((vpr.GUID.StdGUID) obj).RawObject;
   }

   // Marshaling for native memory coming from C++.
   public Object MarshalNativeToManaged(IntPtr nativeObj)
   {
      return new vpr.GUID.StdGUID(nativeObj, false);
   }

   public static ICustomMarshaler GetInstance(string cookie)
   {
      return mInstance;
   }

   private static StdGUIDMarshaler mInstance = new StdGUIDMarshaler();
}


   // Nested class vpr.GUID.hash.
public class hash
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
   protected hash(NoInitTag doInit)
   {
   }

   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr vpr_GUID_hash_hash__vpr_GUID_hash1([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(vpr.GUID.hashMarshaler))] vpr.GUID.hash p0);

   public hash(vpr.GUID.hash p0)
   {
      mRawObject   = vpr_GUID_hash_hash__vpr_GUID_hash1(p0);
      mWeOwnMemory = true;
   }

   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr vpr_GUID_hash_hash__0();

   public hash()
   {
      mRawObject   = vpr_GUID_hash_hash__0();
      mWeOwnMemory = true;
   }

   // Internal constructor needed for marshaling purposes.
   internal hash(IntPtr instPtr, bool ownMemory)
   {
      mRawObject   = instPtr;
      mWeOwnMemory = ownMemory;
   }

   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static void delete_vpr_GUID_hash(IntPtr obj);

   // Destructor.
   ~hash()
   {
      if ( mWeOwnMemory && IntPtr.Zero != mRawObject )
      {
         delete_vpr_GUID_hash(mRawObject);
         mWeOwnMemory = false;
         mRawObject   = IntPtr.Zero;
      }
   }

   // Operator overloads.

   // Converter operators.


} // class vpr.GUID.hash

/// <summary>
/// Custom marshaler for vpr.GUID.hash.  Use this with P/Invoke
/// calls when a C# object of this type needs to be passed to native code or
/// vice versa.  Essentially, this marshaler hides the existence of mRawObject.
/// </summary>
public class hashMarshaler : ICustomMarshaler
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
      return ((vpr.GUID.hash) obj).RawObject;
   }

   // Marshaling for native memory coming from C++.
   public Object MarshalNativeToManaged(IntPtr nativeObj)
   {
      return new vpr.GUID.hash(nativeObj, false);
   }

   public static ICustomMarshaler GetInstance(string cookie)
   {
      return mInstance;
   }

   private static hashMarshaler mInstance = new hashMarshaler();
}


} // class vpr.GUID

/// <summary>
/// Custom marshaler for vpr.GUID.  Use this with P/Invoke
/// calls when a C# object of this type needs to be passed to native code or
/// vice versa.  Essentially, this marshaler hides the existence of mRawObject.
/// </summary>
public class GUIDMarshaler : ICustomMarshaler
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
      return ((vpr.GUID) obj).RawObject;
   }

   // Marshaling for native memory coming from C++.
   public Object MarshalNativeToManaged(IntPtr nativeObj)
   {
      return new vpr.GUID(nativeObj, false);
   }

   public static ICustomMarshaler GetInstance(string cookie)
   {
      return mInstance;
   }

   private static GUIDMarshaler mInstance = new GUIDMarshaler();
}


} // namespace vpr
