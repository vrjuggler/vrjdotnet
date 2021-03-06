#region License
// VRJ.NET is (C) Copyright 2004-2007 by Patrick Hartling
// Distributed under the GNU Lesser General Public License 2.1.  (See
// accompanying file COPYING.txt or http://www.gnu.org/copyleft/lesser.txt)
#endregion License

// Generated from Revision: 1.78 of RCSfile: class_cs.tmpl,v
using System;
using System.Runtime.InteropServices;
using System.Reflection;





namespace jccl
{

public abstract class ConfigElementHandler
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
      m_configCanHandleDelegate_jccl_ConfigElementPtr = new configCanHandleDelegate_jccl_ConfigElementPtr(configCanHandle);
      m_configProcessPendingDelegate = new configProcessPendingDelegate(configProcessPending);
      m_configAddDelegate_jccl_ConfigElementPtr = new configAddDelegate_jccl_ConfigElementPtr(configAdd);
      m_configRemoveDelegate_jccl_ConfigElementPtr = new configRemoveDelegate_jccl_ConfigElementPtr(configRemove);
   }

   // Constructors.
   protected ConfigElementHandler(NoInitTag doInit)
   {
      allocDelegates();
   }

   [DllImport("jccl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr jccl_ConfigElementHandler_ConfigElementHandler__0([MarshalAs(UnmanagedType.FunctionPtr)] configCanHandleDelegate_jccl_ConfigElementPtr d0, [MarshalAs(UnmanagedType.FunctionPtr)] configProcessPendingDelegate d1, [MarshalAs(UnmanagedType.FunctionPtr)] configAddDelegate_jccl_ConfigElementPtr d2, [MarshalAs(UnmanagedType.FunctionPtr)] configRemoveDelegate_jccl_ConfigElementPtr d3);

   public ConfigElementHandler()
   {
      allocDelegates();
      mRawObject   = jccl_ConfigElementHandler_ConfigElementHandler__0(m_configCanHandleDelegate_jccl_ConfigElementPtr, m_configProcessPendingDelegate, m_configAddDelegate_jccl_ConfigElementPtr, m_configRemoveDelegate_jccl_ConfigElementPtr);
      mWeOwnMemory = true;
   }

   // Internal constructor needed for marshaling purposes.
   internal ConfigElementHandler(IntPtr instPtr, bool ownMemory)
   {
      mRawObject   = instPtr;
      mWeOwnMemory = ownMemory;
   }

   [DllImport("jccl_bridge", CharSet = CharSet.Ansi)]
   private extern static void delete_jccl_ConfigElementHandler(IntPtr obj);

   // Destructor.
   ~ConfigElementHandler()
   {
      if ( mWeOwnMemory && IntPtr.Zero != mRawObject )
      {
         delete_jccl_ConfigElementHandler(mRawObject);
         mWeOwnMemory = false;
         mRawObject   = IntPtr.Zero;
      }
   }

   // Operator overloads.

   // Converter operators.

   // Start of virtual methods.
   // Delegate for the configCanHandle() callback.
   public delegate bool configCanHandleDelegate_jccl_ConfigElementPtr([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(jccl.ConfigElementMarshaler))] jccl.ConfigElement p0);
   protected configCanHandleDelegate_jccl_ConfigElementPtr m_configCanHandleDelegate_jccl_ConfigElementPtr;

   public abstract bool configCanHandle(jccl.ConfigElement p0);


   // Delegate for the configProcessPending() callback.
   public delegate int configProcessPendingDelegate();
   protected configProcessPendingDelegate m_configProcessPendingDelegate;

   [DllImport("jccl_bridge", CharSet = CharSet.Ansi)]
   private extern static int jccl_ConfigElementHandler_configProcessPending__0(IntPtr obj);

   public virtual int configProcessPending()
   {
      int result;
      result = jccl_ConfigElementHandler_configProcessPending__0(mRawObject);
      return result;
   }


   // Delegate for the configAdd() callback.
   public delegate bool configAddDelegate_jccl_ConfigElementPtr([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(jccl.ConfigElementMarshaler))] jccl.ConfigElement p0);
   protected configAddDelegate_jccl_ConfigElementPtr m_configAddDelegate_jccl_ConfigElementPtr;

   public abstract bool configAdd(jccl.ConfigElement p0);


   // Delegate for the configRemove() callback.
   public delegate bool configRemoveDelegate_jccl_ConfigElementPtr([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(jccl.ConfigElementMarshaler))] jccl.ConfigElement p0);
   protected configRemoveDelegate_jccl_ConfigElementPtr m_configRemoveDelegate_jccl_ConfigElementPtr;

   public abstract bool configRemove(jccl.ConfigElement p0);


   // End of virtual methods.


} // class jccl.ConfigElementHandler

/// <summary>
/// Custom marshaler for jccl.ConfigElementHandler.  Use this with P/Invoke
/// calls when a C# object of this type needs to be passed to native code or
/// vice versa.  Essentially, this marshaler hides the existence of mRawObject.
/// </summary>
public class ConfigElementHandlerMarshaler : ICustomMarshaler
{
   private class DummyConfigElementHandler : jccl.ConfigElementHandler
   {

      public DummyConfigElementHandler(IntPtr rawObject)
         : base(new NoInitTag())
      {
         mRawObject = rawObject;
         mWeOwnMemory = false;
      }

      [DllImport("jccl_bridge", CharSet = CharSet.Ansi)]
      private extern static bool jccl_ConfigElementHandler_configCanHandle__jccl_ConfigElementPtr1(IntPtr obj,
	[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(jccl.ConfigElementMarshaler))] jccl.ConfigElement p0);

      public override bool configCanHandle(jccl.ConfigElement p0)
      {
         bool result;
         result = jccl_ConfigElementHandler_configCanHandle__jccl_ConfigElementPtr1(mRawObject, p0);
         return result;
      }

      [DllImport("jccl_bridge", CharSet = CharSet.Ansi)]
      private extern static bool jccl_ConfigElementHandler_configAdd__jccl_ConfigElementPtr1(IntPtr obj,
	[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(jccl.ConfigElementMarshaler))] jccl.ConfigElement p0);

      public override bool configAdd(jccl.ConfigElement p0)
      {
         bool result;
         result = jccl_ConfigElementHandler_configAdd__jccl_ConfigElementPtr1(mRawObject, p0);
         return result;
      }

      [DllImport("jccl_bridge", CharSet = CharSet.Ansi)]
      private extern static bool jccl_ConfigElementHandler_configRemove__jccl_ConfigElementPtr1(IntPtr obj,
	[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(jccl.ConfigElementMarshaler))] jccl.ConfigElement p0);

      public override bool configRemove(jccl.ConfigElement p0)
      {
         bool result;
         result = jccl_ConfigElementHandler_configRemove__jccl_ConfigElementPtr1(mRawObject, p0);
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
      return ((jccl.ConfigElementHandler) obj).RawObject;
   }

   // Marshaling for native memory coming from C++.
   public Object MarshalNativeToManaged(IntPtr nativeObj)
   {
      return new DummyConfigElementHandler(nativeObj);
   }

   public static ICustomMarshaler GetInstance(string cookie)
   {
      return mInstance;
   }

   private static ConfigElementHandlerMarshaler mInstance = new ConfigElementHandlerMarshaler();
}


} // namespace jccl
