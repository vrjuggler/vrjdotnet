#region License
// VRJ.NET is (C) Copyright 2004-2007 by Patrick Hartling
// Distributed under the GNU Lesser General Public License 2.1.  (See
// accompanying file COPYING.txt or http://www.gnu.org/copyleft/lesser.txt)
#endregion License

// Generated from Revision: 1.78 of RCSfile: class_cs.tmpl,v
using System;
using System.Runtime.InteropServices;
using System.Reflection;





namespace gadget
{

public abstract class TypedProxy_gadget__Digital
   : gadget.Proxy
{
   private void allocDelegates()
   {
      m_refreshDelegate = new refreshDelegate(refresh);
      m_getDeviceNameDelegate = new getDeviceNameDelegate(getDeviceName);
   }

   // Constructors.
   protected TypedProxy_gadget__Digital(NoInitTag doInit)
      : base(doInit)
   {
      allocDelegates();
   }

   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gadget_TypedProxy_gadget_Digital__TypedProxy__0([MarshalAs(UnmanagedType.FunctionPtr)] refreshDelegate d0, [MarshalAs(UnmanagedType.FunctionPtr)] getDeviceNameDelegate d1, [MarshalAs(UnmanagedType.FunctionPtr)] configDelegate_jccl_ConfigElementPtr d2, [MarshalAs(UnmanagedType.FunctionPtr)] updateDataDelegate d3, [MarshalAs(UnmanagedType.FunctionPtr)] getProxiedInputDeviceDelegate d4, [MarshalAs(UnmanagedType.FunctionPtr)] isStupifiedDelegate d5, [MarshalAs(UnmanagedType.FunctionPtr)] getTimeStampDelegate d6);

   public TypedProxy_gadget__Digital()
      : base(new NoInitTag())   // Do not initialize mRawObject in base class
   {
      allocDelegates();
      mRawObject   = gadget_TypedProxy_gadget_Digital__TypedProxy__0(m_refreshDelegate, m_getDeviceNameDelegate, m_configDelegate_jccl_ConfigElementPtr, m_updateDataDelegate, m_getProxiedInputDeviceDelegate, m_isStupifiedDelegate, m_getTimeStampDelegate);
      mWeOwnMemory = true;
   }

   // Internal constructor needed for marshaling purposes.
   internal TypedProxy_gadget__Digital(IntPtr instPtr, bool ownMemory)
      : base(new NoInitTag())
   {
      mRawObject   = instPtr;
      mWeOwnMemory = ownMemory;
   }

   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static void delete_gadget_TypedProxy_gadget__Digital(IntPtr obj);

   // Destructor.
   ~TypedProxy_gadget__Digital()
   {
      if ( mWeOwnMemory && IntPtr.Zero != mRawObject )
      {
         delete_gadget_TypedProxy_gadget__Digital(mRawObject);
         mWeOwnMemory = false;
         mRawObject   = IntPtr.Zero;
      }
   }

   // Operator overloads.

   // Converter operators.

   // Start of virtual methods.
   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static bool gadget_TypedProxy_gadget_Digital__refresh__0(IntPtr obj);

   public override bool refresh()
   {
      bool result;
      result = gadget_TypedProxy_gadget_Digital__refresh__0(mRawObject);
      return result;
   }


   // Delegate for the getDeviceName() callback.
   public delegate string getDeviceNameDelegate();
   protected getDeviceNameDelegate m_getDeviceNameDelegate;

   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static string gadget_TypedProxy_gadget_Digital__getDeviceName__0(IntPtr obj);

   public virtual string getDeviceName()
   {
      string result;
      result = gadget_TypedProxy_gadget_Digital__getDeviceName__0(mRawObject);
      return result;
   }


   // End of virtual methods.


} // class gadget.TypedProxy_gadget__Digital

/// <summary>
/// Custom marshaler for gadget.TypedProxy_gadget__Digital.  Use this with P/Invoke
/// calls when a C# object of this type needs to be passed to native code or
/// vice versa.  Essentially, this marshaler hides the existence of mRawObject.
/// </summary>
public class TypedProxy_gadget__DigitalMarshaler : ICustomMarshaler
{
   private class DummyTypedProxy_gadget__Digital : gadget.TypedProxy_gadget__Digital
   {

      public DummyTypedProxy_gadget__Digital(IntPtr rawObject)
         : base(new NoInitTag())
      {
         mRawObject = rawObject;
         mWeOwnMemory = false;
      }

      [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
      [return : MarshalAs(UnmanagedType.CustomMarshaler,
                          MarshalTypeRef = typeof(gadget.InputMarshaler))]
      private extern static gadget.Input gadget_Proxy_getProxiedInputDevice__0(IntPtr obj);

      public override gadget.Input getProxiedInputDevice()
      {
         gadget.Input result;
         result = gadget_Proxy_getProxiedInputDevice__0(mRawObject);
         return result;
      }

      [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
      [return : MarshalAs(UnmanagedType.CustomMarshaler,
                          MarshalTypeRef = typeof(vpr.IntervalMarshaler))]
      private extern static vpr.Interval gadget_Proxy_getTimeStamp__0(IntPtr obj);

      public override vpr.Interval getTimeStamp()
      {
         vpr.Interval result;
         result = gadget_Proxy_getTimeStamp__0(mRawObject);
         return result;
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
      return ((gadget.TypedProxy_gadget__Digital) obj).RawObject;
   }

   // Marshaling for native memory coming from C++.
   public Object MarshalNativeToManaged(IntPtr nativeObj)
   {
      return new DummyTypedProxy_gadget__Digital(nativeObj);
   }

   public static ICustomMarshaler GetInstance(string cookie)
   {
      return mInstance;
   }

   private static TypedProxy_gadget__DigitalMarshaler mInstance = new TypedProxy_gadget__DigitalMarshaler();
}


} // namespace gadget
