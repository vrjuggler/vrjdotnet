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

public class Digital
   : vpr.SerializableObject
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
      m_getBaseTypeDelegate = new getBaseTypeDelegate(getBaseType);
      m_writeObjectDelegate_vpr_ObjectWriter = new writeObjectDelegate_vpr_ObjectWriter(writeObjectAdapter);
      m_readObjectDelegate_vpr_ObjectReader = new readObjectDelegate_vpr_ObjectReader(readObjectAdapter);
   }

   // Constructors.
   protected Digital(NoInitTag doInit)
   {
      allocDelegates();
   }

   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gadget_Digital_Digital__0([MarshalAs(UnmanagedType.FunctionPtr)] configDelegate_jccl_ConfigElementPtr d0, [MarshalAs(UnmanagedType.FunctionPtr)] getBaseTypeDelegate d1, [MarshalAs(UnmanagedType.FunctionPtr)] writeObjectDelegate_vpr_ObjectWriter d2, [MarshalAs(UnmanagedType.FunctionPtr)] readObjectDelegate_vpr_ObjectReader d3);

   public Digital()
   {
      allocDelegates();
      mRawObject   = gadget_Digital_Digital__0(m_configDelegate_jccl_ConfigElementPtr, m_getBaseTypeDelegate, m_writeObjectDelegate_vpr_ObjectWriter, m_readObjectDelegate_vpr_ObjectReader);
      mWeOwnMemory = true;
   }

   // Internal constructor needed for marshaling purposes.
   internal Digital(IntPtr instPtr, bool ownMemory)
   {
      mRawObject   = instPtr;
      mWeOwnMemory = ownMemory;
   }

   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static void delete_gadget_Digital(IntPtr obj);

   // Destructor.
   ~Digital()
   {
      if ( mWeOwnMemory && IntPtr.Zero != mRawObject )
      {
         delete_gadget_Digital(mRawObject);
         mWeOwnMemory = false;
         mRawObject   = IntPtr.Zero;
      }
   }

   // Operator overloads.

   // Converter operators.

   // Start of non-virtual methods.
   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   [return : MarshalAs(UnmanagedType.CustomMarshaler,
                       MarshalTypeRef = typeof(gadget.DigitalDataMarshaler))]
   private extern static gadget.DigitalData gadget_Digital_getDigitalData__int0(IntPtr obj);

   public  gadget.DigitalData getDigitalData()
   {
      gadget.DigitalData result;
      result = gadget_Digital_getDigitalData__int0(mRawObject);
      return result;
   }

   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   [return : MarshalAs(UnmanagedType.CustomMarshaler,
                       MarshalTypeRef = typeof(gadget.DigitalDataMarshaler))]
   private extern static gadget.DigitalData gadget_Digital_getDigitalData__int1(IntPtr obj,
	int p0);

   public  gadget.DigitalData getDigitalData(int p0)
   {
      gadget.DigitalData result;
      result = gadget_Digital_getDigitalData__int1(mRawObject, p0);
      return result;
   }


   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static void gadget_Digital_swapDigitalBuffers__0(IntPtr obj);

   public  void swapDigitalBuffers()
   {
      gadget_Digital_swapDigitalBuffers__0(mRawObject);
   }


   // End of non-virtual methods.

   // Start of virtual methods.
   // Delegate for the config() callback.
   public delegate bool configDelegate_jccl_ConfigElementPtr([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(jccl.ConfigElementMarshaler))] jccl.ConfigElement p0);
   protected configDelegate_jccl_ConfigElementPtr m_configDelegate_jccl_ConfigElementPtr;

   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static bool gadget_Digital_config__jccl_ConfigElementPtr1(IntPtr obj,
	[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(jccl.ConfigElementMarshaler))] jccl.ConfigElement p0);

   public virtual bool config(jccl.ConfigElement p0)
   {
      bool result;
      result = gadget_Digital_config__jccl_ConfigElementPtr1(mRawObject, p0);
      return result;
   }


   // Delegate for the getBaseType() callback.
   public delegate string getBaseTypeDelegate();
   protected getBaseTypeDelegate m_getBaseTypeDelegate;

   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static string gadget_Digital_getBaseType__0(IntPtr obj);

   public virtual string getBaseType()
   {
      string result;
      result = gadget_Digital_getBaseType__0(mRawObject);
      return result;
   }


   // Delegate for the writeObject() callback.
   protected void writeObjectAdapter(vpr.ObjectWriter p0)
   {
      writeObject(p0);
   }

   public delegate void writeObjectDelegate_vpr_ObjectWriter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(vpr.ObjectWriterMarshaler))] vpr.ObjectWriter p0);
   protected writeObjectDelegate_vpr_ObjectWriter m_writeObjectDelegate_vpr_ObjectWriter;

   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static void gadget_Digital_writeObject__vpr_ObjectWriter1(IntPtr obj,
	[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(vpr.ObjectWriterMarshaler))] vpr.ObjectWriter p0);

   public virtual void writeObject(vpr.ObjectWriter p0)
   {
      gadget_Digital_writeObject__vpr_ObjectWriter1(mRawObject, p0);
   }


   // Delegate for the readObject() callback.
   protected void readObjectAdapter(vpr.ObjectReader p0)
   {
      readObject(p0);
   }

   public delegate void readObjectDelegate_vpr_ObjectReader([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(vpr.ObjectReaderMarshaler))] vpr.ObjectReader p0);
   protected readObjectDelegate_vpr_ObjectReader m_readObjectDelegate_vpr_ObjectReader;

   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static void gadget_Digital_readObject__vpr_ObjectReader1(IntPtr obj,
	[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(vpr.ObjectReaderMarshaler))] vpr.ObjectReader p0);

   public virtual void readObject(vpr.ObjectReader p0)
   {
      gadget_Digital_readObject__vpr_ObjectReader1(mRawObject, p0);
   }


   // End of virtual methods.

   // Nested enumeration gadget.Digital.State.
   public enum State
   {
      TOGGLE_OFF = 3, ON = 1, OFF = 0, TOGGLE_ON = 2
   };


} // class gadget.Digital

/// <summary>
/// Custom marshaler for gadget.Digital.  Use this with P/Invoke
/// calls when a C# object of this type needs to be passed to native code or
/// vice versa.  Essentially, this marshaler hides the existence of mRawObject.
/// </summary>
public class DigitalMarshaler : ICustomMarshaler
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
      return ((gadget.Digital) obj).RawObject;
   }

   // Marshaling for native memory coming from C++.
   public Object MarshalNativeToManaged(IntPtr nativeObj)
   {
      return new gadget.Digital(nativeObj, false);
   }

   public static ICustomMarshaler GetInstance(string cookie)
   {
      return mInstance;
   }

   private static DigitalMarshaler mInstance = new DigitalMarshaler();
}


} // namespace gadget
