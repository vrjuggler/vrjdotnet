#region License
// VRJ.NET is (C) Copyright 2004-2007 by Patrick Hartling
// Distributed under the GNU Lesser General Public License 2.1.  (See
// accompanying file COPYING.txt or http://www.gnu.org/copyleft/lesser.txt)
#endregion License

// Generated from Revision: 1.78 of RCSfile: class_cs.tmpl,v
using System;
using System.Runtime.InteropServices;
using System.Reflection;





namespace vpr
{

public interface ReadableObject
{
   void readObject(vpr.ObjectReader p0);

}

/// <summary>
/// Custom marshaler for vpr.ReadableObject.  Use this with P/Invoke
/// calls when a C# object of this type needs to be passed to native code or
/// vice versa.  Essentially, this marshaler hides the existence of mRawObject.
/// </summary>
public class ReadableObjectMarshaler : ICustomMarshaler
{
   private class DummyReadableObject : vpr.ReadableObject
   {
      private IntPtr mRawObject = IntPtr.Zero;

      internal IntPtr RawObject
      {
         get { return mRawObject; }
      }

      public DummyReadableObject(IntPtr rawObject)
      {
         mRawObject = rawObject;
      }

      [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
      private extern static void vpr_ReadableObject_readObject__vpr_ObjectReader1(IntPtr obj,
	[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(vpr.ObjectReaderMarshaler))] vpr.ObjectReader p0);

      public void readObject(vpr.ObjectReader p0)
      {
         vpr_ReadableObject_readObject__vpr_ObjectReader1(mRawObject, p0);
      }

   }

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
      // Try the fast return method first.  If it fails, catch the exception
      // and use the slow technique instead.
      try
      {
         return ((DummyReadableObject) obj).RawObject;
      }
      catch(System.InvalidCastException ex)
      {
         PropertyInfo raw_obj_prop =
            obj.GetType().GetProperty("RawObject",
                                      BindingFlags.NonPublic | BindingFlags.Instance);
         if ( null != raw_obj_prop )
         {
            return (IntPtr) raw_obj_prop.GetValue(obj, null);
         }
      }

      // Marshaling failed.
      return IntPtr.Zero;
   }

   // Marshaling for native memory coming from C++.
   public Object MarshalNativeToManaged(IntPtr nativeObj)
   {
      return new DummyReadableObject(nativeObj);
   }

   public static ICustomMarshaler GetInstance(string cookie)
   {
      return mInstance;
   }

   private static ReadableObjectMarshaler mInstance = new ReadableObjectMarshaler();
}


} // namespace vpr
