#region License
// VRJ.NET is (C) Copyright 2004-2007 by Patrick Hartling
// Distributed under the GNU Lesser General Public License 2.1.  (See
// accompanying file COPYING.txt or http://www.gnu.org/copyleft/lesser.txt)
#endregion License

// Generated from Revision: 1.79 of RCSfile: class_cs.tmpl,v
using System;
using System.Runtime.InteropServices;
using System.Reflection;





namespace gadget
{

public sealed class DigitalProxy
   : gadget.TypedProxy_gadget__Digital
{
   private void allocDelegates()
   {
   }

   // Constructors.
   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gadget_DigitalProxy_DigitalProxy__gadget_DigitalProxy1([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(gadget.DigitalProxyMarshaler))] gadget.DigitalProxy p0);

   public DigitalProxy(gadget.DigitalProxy p0)
      : base(new NoInitTag())   // Do not initialize mRawObject in base class
   {
      allocDelegates();
      mRawObject   = gadget_DigitalProxy_DigitalProxy__gadget_DigitalProxy1(p0);
      mWeOwnMemory = true;
   }

   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gadget_DigitalProxy_DigitalProxy__0();

   public DigitalProxy()
      : base(new NoInitTag())   // Do not initialize mRawObject in base class
   {
      allocDelegates();
      mRawObject   = gadget_DigitalProxy_DigitalProxy__0();
      mWeOwnMemory = true;
   }

   // Internal constructor needed for marshaling purposes.
   internal DigitalProxy(IntPtr instPtr, bool ownMemory)
      : base(new NoInitTag())
   {
      mRawObject   = instPtr;
      mWeOwnMemory = ownMemory;
   }

   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static void delete_gadget_DigitalProxy(IntPtr obj);

   // Destructor.
   ~DigitalProxy()
   {
      if ( mWeOwnMemory && IntPtr.Zero != mRawObject )
      {
         delete_gadget_DigitalProxy(mRawObject);
         mWeOwnMemory = false;
         mRawObject   = IntPtr.Zero;
      }
   }

   // Operator overloads.

   // Converter operators.

   // Start of non-virtual methods.
   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static gadget.Digital.State gadget_DigitalProxy_getData__0(IntPtr obj);

   public  gadget.Digital.State getData()
   {
      gadget.Digital.State result;
      result = gadget_DigitalProxy_getData__0(mRawObject);
      return result;
   }


   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   [return : MarshalAs(UnmanagedType.CustomMarshaler,
                       MarshalTypeRef = typeof(gadget.DigitalDataMarshaler))]
   private extern static gadget.DigitalData gadget_DigitalProxy_getDigitalData__0(IntPtr obj);

   public  gadget.DigitalData getDigitalData()
   {
      gadget.DigitalData result;
      result = gadget_DigitalProxy_getDigitalData__0(mRawObject);
      return result;
   }


   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   [return : MarshalAs(UnmanagedType.CustomMarshaler,
                       MarshalTypeRef = typeof(gadget.DigitalMarshaler))]
   private extern static gadget.Digital gadget_DigitalProxy_getDigitalPtr__0(IntPtr obj);

   public  gadget.Digital getDigitalPtr()
   {
      gadget.Digital result;
      result = gadget_DigitalProxy_getDigitalPtr__0(mRawObject);
      return result;
   }


   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static int gadget_DigitalProxy_getUnit__0(IntPtr obj);

   public  int getUnit()
   {
      int result;
      result = gadget_DigitalProxy_getUnit__0(mRawObject);
      return result;
   }


   // End of non-virtual methods.

   // Start of virtual methods.
   // End of virtual methods.

   // Start of virtual methods.
   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static void gadget_DigitalProxy_updateData__0(IntPtr obj);

   public override void updateData()
   {
      gadget_DigitalProxy_updateData__0(mRawObject);
   }


   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   [return : MarshalAs(UnmanagedType.CustomMarshaler,
                       MarshalTypeRef = typeof(vpr.IntervalMarshaler))]
   private extern static vpr.Interval gadget_DigitalProxy_getTimeStamp__0(IntPtr obj);

   public override vpr.Interval getTimeStamp()
   {
      vpr.Interval result;
      result = gadget_DigitalProxy_getTimeStamp__0(mRawObject);
      return result;
   }


   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static bool gadget_DigitalProxy_config__jccl_ConfigElementPtr1(IntPtr obj,
	[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(jccl.ConfigElementMarshaler))] jccl.ConfigElement p0);

   public override bool config(jccl.ConfigElement p0)
   {
      bool result;
      result = gadget_DigitalProxy_config__jccl_ConfigElementPtr1(mRawObject, p0);
      return result;
   }


   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   [return : MarshalAs(UnmanagedType.CustomMarshaler,
                       MarshalTypeRef = typeof(gadget.InputMarshaler))]
   private extern static gadget.Input gadget_DigitalProxy_getProxiedInputDevice__0(IntPtr obj);

   public override gadget.Input getProxiedInputDevice()
   {
      gadget.Input result;
      result = gadget_DigitalProxy_getProxiedInputDevice__0(mRawObject);
      return result;
   }


   // End of virtual methods.

   // Start of static methods.
   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static string gadget_DigitalProxy_getElementType__0();

   public new static string getElementType()
   {
      string result;
      result = gadget_DigitalProxy_getElementType__0();
      return result;
   }


   // End of static methods.


} // class gadget.DigitalProxy

/// <summary>
/// Custom marshaler for gadget.DigitalProxy.  Use this with P/Invoke
/// calls when a C# object of this type needs to be passed to native code or
/// vice versa.  Essentially, this marshaler hides the existence of mRawObject.
/// </summary>
public class DigitalProxyMarshaler : ICustomMarshaler
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
      return ((gadget.DigitalProxy) obj).RawObject;
   }

   // Marshaling for native memory coming from C++.
   public Object MarshalNativeToManaged(IntPtr nativeObj)
   {
      return new gadget.DigitalProxy(nativeObj, false);
   }

   public static ICustomMarshaler GetInstance(string cookie)
   {
      return mInstance;
   }

   private static DigitalProxyMarshaler mInstance = new DigitalProxyMarshaler();
}


} // namespace gadget
