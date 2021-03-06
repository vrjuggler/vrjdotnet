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

public abstract class Input
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
      m_sampleDelegate = new sampleDelegate(sample);
      m_startSamplingDelegate = new startSamplingDelegate(startSampling);
      m_stopSamplingDelegate = new stopSamplingDelegate(stopSampling);
      m_updateDataDelegate = new updateDataDelegate(updateData);
      m_getBaseTypeDelegate = new getBaseTypeDelegate(getBaseType);
      m_writeObjectDelegate_vpr_ObjectWriter = new writeObjectDelegate_vpr_ObjectWriter(writeObjectAdapter);
      m_readObjectDelegate_vpr_ObjectReader = new readObjectDelegate_vpr_ObjectReader(readObjectAdapter);
      m_destroyDelegate = new destroyDelegate(destroy);
   }

   // Constructors.
   protected Input(NoInitTag doInit)
   {
      allocDelegates();
   }

   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gadget_Input_Input__0([MarshalAs(UnmanagedType.FunctionPtr)] configDelegate_jccl_ConfigElementPtr d0, [MarshalAs(UnmanagedType.FunctionPtr)] sampleDelegate d1, [MarshalAs(UnmanagedType.FunctionPtr)] startSamplingDelegate d2, [MarshalAs(UnmanagedType.FunctionPtr)] stopSamplingDelegate d3, [MarshalAs(UnmanagedType.FunctionPtr)] updateDataDelegate d4, [MarshalAs(UnmanagedType.FunctionPtr)] getBaseTypeDelegate d5, [MarshalAs(UnmanagedType.FunctionPtr)] writeObjectDelegate_vpr_ObjectWriter d6, [MarshalAs(UnmanagedType.FunctionPtr)] readObjectDelegate_vpr_ObjectReader d7, [MarshalAs(UnmanagedType.FunctionPtr)] destroyDelegate d8);

   public Input()
   {
      allocDelegates();
      mRawObject   = gadget_Input_Input__0(m_configDelegate_jccl_ConfigElementPtr, m_sampleDelegate, m_startSamplingDelegate, m_stopSamplingDelegate, m_updateDataDelegate, m_getBaseTypeDelegate, m_writeObjectDelegate_vpr_ObjectWriter, m_readObjectDelegate_vpr_ObjectReader, m_destroyDelegate);
      mWeOwnMemory = true;
   }

   // Internal constructor needed for marshaling purposes.
   internal Input(IntPtr instPtr, bool ownMemory)
   {
      mRawObject   = instPtr;
      mWeOwnMemory = ownMemory;
   }

   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static void delete_gadget_Input(IntPtr obj);

   // Destructor.
   ~Input()
   {
      if ( mWeOwnMemory && IntPtr.Zero != mRawObject )
      {
         delete_gadget_Input(mRawObject);
         mWeOwnMemory = false;
         mRawObject   = IntPtr.Zero;
      }
   }

   // Operator overloads.

   // Converter operators.

   // Start of non-virtual methods.
   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static string gadget_Input_getInstanceName__0(IntPtr obj);

   public  string getInstanceName()
   {
      string result;
      result = gadget_Input_getInstanceName__0(mRawObject);
      return result;
   }


   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static bool gadget_Input_isActive__0(IntPtr obj);

   public  bool isActive()
   {
      bool result;
      result = gadget_Input_isActive__0(mRawObject);
      return result;
   }


   // End of non-virtual methods.

   // Start of virtual methods.
   // Delegate for the config() callback.
   public delegate bool configDelegate_jccl_ConfigElementPtr([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(jccl.ConfigElementMarshaler))] jccl.ConfigElement p0);
   protected configDelegate_jccl_ConfigElementPtr m_configDelegate_jccl_ConfigElementPtr;

   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static bool gadget_Input_config__jccl_ConfigElementPtr1(IntPtr obj,
	[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(jccl.ConfigElementMarshaler))] jccl.ConfigElement p0);

   public virtual bool config(jccl.ConfigElement p0)
   {
      bool result;
      result = gadget_Input_config__jccl_ConfigElementPtr1(mRawObject, p0);
      return result;
   }


   // Delegate for the sample() callback.
   public delegate bool sampleDelegate();
   protected sampleDelegate m_sampleDelegate;

   public abstract bool sample();


   // Delegate for the startSampling() callback.
   public delegate bool startSamplingDelegate();
   protected startSamplingDelegate m_startSamplingDelegate;

   public abstract bool startSampling();


   // Delegate for the stopSampling() callback.
   public delegate bool stopSamplingDelegate();
   protected stopSamplingDelegate m_stopSamplingDelegate;

   public abstract bool stopSampling();


   // Delegate for the updateData() callback.
   public delegate void updateDataDelegate();
   protected updateDataDelegate m_updateDataDelegate;

   public abstract void updateData();


   // Delegate for the getBaseType() callback.
   public delegate string getBaseTypeDelegate();
   protected getBaseTypeDelegate m_getBaseTypeDelegate;

   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static string gadget_Input_getBaseType__0(IntPtr obj);

   public virtual string getBaseType()
   {
      string result;
      result = gadget_Input_getBaseType__0(mRawObject);
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
   private extern static void gadget_Input_writeObject__vpr_ObjectWriter1(IntPtr obj,
	[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(vpr.ObjectWriterMarshaler))] vpr.ObjectWriter p0);

   public virtual void writeObject(vpr.ObjectWriter p0)
   {
      gadget_Input_writeObject__vpr_ObjectWriter1(mRawObject, p0);
   }


   // Delegate for the readObject() callback.
   protected void readObjectAdapter(vpr.ObjectReader p0)
   {
      readObject(p0);
   }

   public delegate void readObjectDelegate_vpr_ObjectReader([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(vpr.ObjectReaderMarshaler))] vpr.ObjectReader p0);
   protected readObjectDelegate_vpr_ObjectReader m_readObjectDelegate_vpr_ObjectReader;

   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static void gadget_Input_readObject__vpr_ObjectReader1(IntPtr obj,
	[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(vpr.ObjectReaderMarshaler))] vpr.ObjectReader p0);

   public virtual void readObject(vpr.ObjectReader p0)
   {
      gadget_Input_readObject__vpr_ObjectReader1(mRawObject, p0);
   }


   // Delegate for the destroy() callback.
   public delegate void destroyDelegate();
   protected destroyDelegate m_destroyDelegate;

   protected abstract void destroy();


   // End of virtual methods.

   // Start of static methods.
   [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
   private extern static string gadget_Input_getElementType__0();

   public static string getElementType()
   {
      string result;
      result = gadget_Input_getElementType__0();
      return result;
   }


   // End of static methods.


} // class gadget.Input

/// <summary>
/// Custom marshaler for gadget.Input.  Use this with P/Invoke
/// calls when a C# object of this type needs to be passed to native code or
/// vice versa.  Essentially, this marshaler hides the existence of mRawObject.
/// </summary>
public class InputMarshaler : ICustomMarshaler
{
   private class DummyInput : gadget.Input
   {

      public DummyInput(IntPtr rawObject)
         : base(new NoInitTag())
      {
         mRawObject = rawObject;
         mWeOwnMemory = false;
      }

      [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
      private extern static bool gadget_Input_sample__0(IntPtr obj);

      public override bool sample()
      {
         bool result;
         result = gadget_Input_sample__0(mRawObject);
         return result;
      }

      [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
      private extern static bool gadget_Input_startSampling__0(IntPtr obj);

      public override bool startSampling()
      {
         bool result;
         result = gadget_Input_startSampling__0(mRawObject);
         return result;
      }

      [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
      private extern static bool gadget_Input_stopSampling__0(IntPtr obj);

      public override bool stopSampling()
      {
         bool result;
         result = gadget_Input_stopSampling__0(mRawObject);
         return result;
      }

      [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
      private extern static void gadget_Input_updateData__0(IntPtr obj);

      public override void updateData()
      {
         gadget_Input_updateData__0(mRawObject);
      }

      [DllImport("gadget_bridge", CharSet = CharSet.Ansi)]
      private extern static void gadget_Input_destroy__0(IntPtr obj);

      protected override void destroy()
      {
         gadget_Input_destroy__0(mRawObject);
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
      return ((gadget.Input) obj).RawObject;
   }

   // Marshaling for native memory coming from C++.
   public Object MarshalNativeToManaged(IntPtr nativeObj)
   {
      return new DummyInput(nativeObj);
   }

   public static ICustomMarshaler GetInstance(string cookie)
   {
      return mInstance;
   }

   private static InputMarshaler mInstance = new InputMarshaler();
}


} // namespace gadget
