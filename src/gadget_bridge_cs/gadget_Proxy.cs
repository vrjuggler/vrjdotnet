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

public abstract class Proxy
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

   private void allocDelegates()
   {
      m_configDelegate_jccl_ConfigElementPtr = new configDelegate_jccl_ConfigElementPtr(config);
      m_refreshDelegate = new refreshDelegate(refresh);
      m_updateDataDelegate = new updateDataDelegate(updateData);
      m_getProxiedInputDeviceDelegate = new getProxiedInputDeviceDelegate(getProxiedInputDeviceAdapter);
      m_isStupifiedDelegate = new isStupifiedDelegate(isStupified);
      m_getTimeStampDelegate = new getTimeStampDelegate(getTimeStampAdapter);
   }

   // Constructors.
   protected Proxy(NoInitTag doInit)
   {
      allocDelegates();
   }

   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gadget_Proxy_Proxy__0([MarshalAs(UnmanagedType.FunctionPtr)] configDelegate_jccl_ConfigElementPtr d0, [MarshalAs(UnmanagedType.FunctionPtr)] refreshDelegate d1, [MarshalAs(UnmanagedType.FunctionPtr)] updateDataDelegate d2, [MarshalAs(UnmanagedType.FunctionPtr)] getProxiedInputDeviceDelegate d3, [MarshalAs(UnmanagedType.FunctionPtr)] isStupifiedDelegate d4, [MarshalAs(UnmanagedType.FunctionPtr)] getTimeStampDelegate d5);

   public Proxy()
   {
      allocDelegates();
      mRawObject   = gadget_Proxy_Proxy__0(m_configDelegate_jccl_ConfigElementPtr, m_refreshDelegate, m_updateDataDelegate, m_getProxiedInputDeviceDelegate, m_isStupifiedDelegate, m_getTimeStampDelegate);
      mWeOwnMemory = true;
   }

   // Internal constructor needed for marshaling purposes.
   internal Proxy(IntPtr instPtr, bool ownMemory)
   {
      mRawObject   = instPtr;
      mWeOwnMemory = ownMemory;
   }

   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static void delete_gadget_Proxy(IntPtr obj);

   // Destructor.
   ~Proxy()
   {
      if ( mWeOwnMemory && IntPtr.Zero != mRawObject )
      {
         delete_gadget_Proxy(mRawObject);
         mWeOwnMemory = false;
         mRawObject   = IntPtr.Zero;
      }
   }

   // Operator overloads.

   // Converter operators.

   // Start of non-virtual methods.
   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static string gadget_Proxy_getName__0(IntPtr obj);

   public  string getName()
   {
      string result;
      result = gadget_Proxy_getName__0(mRawObject);
      return result;
   }


   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static void gadget_Proxy_setName__std_string1(IntPtr obj,
	string p0);

   public  void setName(string p0)
   {
      gadget_Proxy_setName__std_string1(mRawObject, p0);
   }


   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static void gadget_Proxy_stupefy__bool0(IntPtr obj);

   public  void stupefy()
   {
      gadget_Proxy_stupefy__bool0(mRawObject);
   }

   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static void gadget_Proxy_stupefy__bool1(IntPtr obj,
	bool p0);

   public  void stupefy(bool p0)
   {
      gadget_Proxy_stupefy__bool1(mRawObject, p0);
   }


   // End of non-virtual methods.

   // Start of virtual methods.
   // Delegate for the config() callback.
   public delegate bool configDelegate_jccl_ConfigElementPtr([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(jccl.ConfigElementMarshaler))] jccl.ConfigElement p0);
   protected configDelegate_jccl_ConfigElementPtr m_configDelegate_jccl_ConfigElementPtr;

   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static bool gadget_Proxy_config__jccl_ConfigElementPtr1(IntPtr obj,
	[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(jccl.ConfigElementMarshaler))] jccl.ConfigElement p0);

   public virtual bool config(jccl.ConfigElement p0)
   {
      bool result;
      result = gadget_Proxy_config__jccl_ConfigElementPtr1(mRawObject, p0);
      return result;
   }


   // Delegate for the refresh() callback.
   public delegate bool refreshDelegate();
   protected refreshDelegate m_refreshDelegate;

   public abstract bool refresh();


   // Delegate for the updateData() callback.
   public delegate void updateDataDelegate();
   protected updateDataDelegate m_updateDataDelegate;

   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static void gadget_Proxy_updateData__0(IntPtr obj);

   public virtual void updateData()
   {
      gadget_Proxy_updateData__0(mRawObject);
   }


   // Delegate for the getProxiedInputDevice() callback.
   protected IntPtr getProxiedInputDeviceAdapter()
   {
      return getProxiedInputDevice().RawObject;
   }

   public delegate IntPtr getProxiedInputDeviceDelegate();
   protected getProxiedInputDeviceDelegate m_getProxiedInputDeviceDelegate;

   public abstract gadget.Input getProxiedInputDevice();


   // Delegate for the isStupified() callback.
   public delegate bool isStupifiedDelegate();
   protected isStupifiedDelegate m_isStupifiedDelegate;

   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static bool gadget_Proxy_isStupified__0(IntPtr obj);

   public virtual bool isStupified()
   {
      bool result;
      result = gadget_Proxy_isStupified__0(mRawObject);
      return result;
   }


   // Delegate for the getTimeStamp() callback.
   protected IntPtr getTimeStampAdapter()
   {
      return getTimeStamp().RawObject;
   }

   public delegate IntPtr getTimeStampDelegate();
   protected getTimeStampDelegate m_getTimeStampDelegate;

   public abstract vpr.Interval getTimeStamp();


   // End of virtual methods.

   // Start of static methods.
   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static string gadget_Proxy_getElementType__0();

   public static string getElementType()
   {
      string result;
      result = gadget_Proxy_getElementType__0();
      return result;
   }


   // End of static methods.


} // class gadget.Proxy

/// <summary>
/// Custom marshaler for gadget.Proxy.  Use this with P/Invoke
/// calls when a C# object of this type needs to be passed to native code or
/// vice versa.  Essentially, this marshaler hides the existence of mRawObject.
/// </summary>
public class ProxyMarshaler : ICustomMarshaler
{
   private class DummyProxy : gadget.Proxy
   {

      public DummyProxy(IntPtr rawObject)
         : base(new NoInitTag())
      {
         mRawObject = rawObject;
         mWeOwnMemory = false;
      }

      [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
      private extern static bool gadget_Proxy_refresh__0(IntPtr obj);

      public override bool refresh()
      {
         bool result;
         result = gadget_Proxy_refresh__0(mRawObject);
         return result;
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
      return ((gadget.Proxy) obj).RawObject;
   }

   // Marshaling for native memory coming from C++.
   public Object MarshalNativeToManaged(IntPtr nativeObj)
   {
      return new DummyProxy(nativeObj);
   }

   public static ICustomMarshaler GetInstance(string cookie)
   {
      return mInstance;
   }

   private static ProxyMarshaler mInstance = new ProxyMarshaler();
}


} // namespace gadget
