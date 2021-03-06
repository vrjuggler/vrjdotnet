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

public abstract class ObjectReader
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
      m_beginTagDelegate_std_string = new beginTagDelegate_std_string(beginTagAdapter);
      m_endTagDelegate = new endTagDelegate(endTagAdapter);
      m_beginAttributeDelegate_std_string = new beginAttributeDelegate_std_string(beginAttributeAdapter);
      m_endAttributeDelegate = new endAttributeDelegate(endAttributeAdapter);
      m_resetReadingDelegate = new resetReadingDelegate(resetReading);
      m_pushStateDelegate = new pushStateDelegate(pushState);
      m_popStateDelegate = new popStateDelegate(popState);
      m_readUint8Delegate = new readUint8Delegate(readUint8);
      m_readUint16Delegate = new readUint16Delegate(readUint16);
      m_readUint32Delegate = new readUint32Delegate(readUint32);
      m_readUint64Delegate = new readUint64Delegate(readUint64);
      m_readFloatDelegate = new readFloatDelegate(readFloat);
      m_readDoubleDelegate = new readDoubleDelegate(readDouble);
      m_readStringDelegate = new readStringDelegate(readString);
      m_readBoolDelegate = new readBoolDelegate(readBool);
      m_readUint8Delegate_vpr_Uint8 = new readUint8Delegate_vpr_Uint8(readUint8);
      m_readUint16Delegate_vpr_Uint16 = new readUint16Delegate_vpr_Uint16(readUint16);
      m_readUint32Delegate_vpr_Uint32 = new readUint32Delegate_vpr_Uint32(readUint32);
      m_readUint64Delegate_vpr_Uint64 = new readUint64Delegate_vpr_Uint64(readUint64);
      m_readFloatDelegate_float = new readFloatDelegate_float(readFloat);
      m_readDoubleDelegate_double = new readDoubleDelegate_double(readDouble);
      m_readStringDelegate_std_string = new readStringDelegate_std_string(readString);
      m_readBoolDelegate_bool = new readBoolDelegate_bool(readBool);
   }

   // Constructors.
   protected ObjectReader(NoInitTag doInit)
   {
      allocDelegates();
   }

   // Internal constructor needed for marshaling purposes.
   internal ObjectReader(IntPtr instPtr, bool ownMemory)
   {
      mRawObject   = instPtr;
      mWeOwnMemory = ownMemory;
   }

   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static void delete_vpr_ObjectReader(IntPtr obj);

   // Destructor.
   ~ObjectReader()
   {
      if ( mWeOwnMemory && IntPtr.Zero != mRawObject )
      {
         delete_vpr_ObjectReader(mRawObject);
         mWeOwnMemory = false;
         mRawObject   = IntPtr.Zero;
      }
   }

   // Operator overloads.

   // Converter operators.

   // Start of non-virtual methods.
   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static bool vpr_ObjectReader_isBinary__0(IntPtr obj);

   public  bool isBinary()
   {
      bool result;
      result = vpr_ObjectReader_isBinary__0(mRawObject);
      return result;
   }


   // End of non-virtual methods.

   // Start of virtual methods.
   // Delegate for the beginTag() callback.
   protected void beginTagAdapter(string p0)
   {
      beginTag(p0);
   }

   public delegate void beginTagDelegate_std_string(string p0);
   protected beginTagDelegate_std_string m_beginTagDelegate_std_string;

   public abstract void beginTag(string p0);


   // Delegate for the endTag() callback.
   protected void endTagAdapter()
   {
      endTag();
   }

   public delegate void endTagDelegate();
   protected endTagDelegate m_endTagDelegate;

   public abstract void endTag();


   // Delegate for the beginAttribute() callback.
   protected void beginAttributeAdapter(string p0)
   {
      beginAttribute(p0);
   }

   public delegate void beginAttributeDelegate_std_string(string p0);
   protected beginAttributeDelegate_std_string m_beginAttributeDelegate_std_string;

   public abstract void beginAttribute(string p0);


   // Delegate for the endAttribute() callback.
   protected void endAttributeAdapter()
   {
      endAttribute();
   }

   public delegate void endAttributeDelegate();
   protected endAttributeDelegate m_endAttributeDelegate;

   public abstract void endAttribute();


   // Delegate for the resetReading() callback.
   public delegate void resetReadingDelegate();
   protected resetReadingDelegate m_resetReadingDelegate;

   public abstract void resetReading();


   // Delegate for the pushState() callback.
   public delegate void pushStateDelegate();
   protected pushStateDelegate m_pushStateDelegate;

   public abstract void pushState();


   // Delegate for the popState() callback.
   public delegate void popStateDelegate();
   protected popStateDelegate m_popStateDelegate;

   public abstract void popState();


   // Delegate for the readUint8() callback.
   public delegate byte readUint8Delegate();
   protected readUint8Delegate m_readUint8Delegate;

   public abstract byte readUint8();


   // Delegate for the readUint16() callback.
   public delegate ushort readUint16Delegate();
   protected readUint16Delegate m_readUint16Delegate;

   public abstract ushort readUint16();


   // Delegate for the readUint32() callback.
   public delegate uint readUint32Delegate();
   protected readUint32Delegate m_readUint32Delegate;

   public abstract uint readUint32();


   // Delegate for the readUint64() callback.
   public delegate ulong readUint64Delegate();
   protected readUint64Delegate m_readUint64Delegate;

   public abstract ulong readUint64();


   // Delegate for the readFloat() callback.
   public delegate float readFloatDelegate();
   protected readFloatDelegate m_readFloatDelegate;

   public abstract float readFloat();


   // Delegate for the readDouble() callback.
   public delegate double readDoubleDelegate();
   protected readDoubleDelegate m_readDoubleDelegate;

   public abstract double readDouble();


   // Delegate for the readString() callback.
   public delegate string readStringDelegate();
   protected readStringDelegate m_readStringDelegate;

   public abstract string readString();


   // Delegate for the readBool() callback.
   public delegate bool readBoolDelegate();
   protected readBoolDelegate m_readBoolDelegate;

   public abstract bool readBool();


   // Delegate for the readUint8() callback.
   public delegate void readUint8Delegate_vpr_Uint8(ref byte p0);
   protected readUint8Delegate_vpr_Uint8 m_readUint8Delegate_vpr_Uint8;

   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static void vpr_ObjectReader_readUint8__vpr_Uint81(IntPtr obj,
	ref byte p0);

   public virtual void readUint8(ref byte p0)
   {
      vpr_ObjectReader_readUint8__vpr_Uint81(mRawObject, ref p0);
   }


   // Delegate for the readUint16() callback.
   public delegate void readUint16Delegate_vpr_Uint16(ref ushort p0);
   protected readUint16Delegate_vpr_Uint16 m_readUint16Delegate_vpr_Uint16;

   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static void vpr_ObjectReader_readUint16__vpr_Uint161(IntPtr obj,
	ref ushort p0);

   public virtual void readUint16(ref ushort p0)
   {
      vpr_ObjectReader_readUint16__vpr_Uint161(mRawObject, ref p0);
   }


   // Delegate for the readUint32() callback.
   public delegate void readUint32Delegate_vpr_Uint32(ref uint p0);
   protected readUint32Delegate_vpr_Uint32 m_readUint32Delegate_vpr_Uint32;

   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static void vpr_ObjectReader_readUint32__vpr_Uint321(IntPtr obj,
	ref uint p0);

   public virtual void readUint32(ref uint p0)
   {
      vpr_ObjectReader_readUint32__vpr_Uint321(mRawObject, ref p0);
   }


   // Delegate for the readUint64() callback.
   public delegate void readUint64Delegate_vpr_Uint64(ref ulong p0);
   protected readUint64Delegate_vpr_Uint64 m_readUint64Delegate_vpr_Uint64;

   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static void vpr_ObjectReader_readUint64__vpr_Uint641(IntPtr obj,
	ref ulong p0);

   public virtual void readUint64(ref ulong p0)
   {
      vpr_ObjectReader_readUint64__vpr_Uint641(mRawObject, ref p0);
   }


   // Delegate for the readFloat() callback.
   public delegate void readFloatDelegate_float(ref float p0);
   protected readFloatDelegate_float m_readFloatDelegate_float;

   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static void vpr_ObjectReader_readFloat__float1(IntPtr obj,
	ref float p0);

   public virtual void readFloat(ref float p0)
   {
      vpr_ObjectReader_readFloat__float1(mRawObject, ref p0);
   }


   // Delegate for the readDouble() callback.
   public delegate void readDoubleDelegate_double(ref double p0);
   protected readDoubleDelegate_double m_readDoubleDelegate_double;

   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static void vpr_ObjectReader_readDouble__double1(IntPtr obj,
	ref double p0);

   public virtual void readDouble(ref double p0)
   {
      vpr_ObjectReader_readDouble__double1(mRawObject, ref p0);
   }


   // Delegate for the readString() callback.
   public delegate void readStringDelegate_std_string(string p0);
   protected readStringDelegate_std_string m_readStringDelegate_std_string;

   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static void vpr_ObjectReader_readString__std_string1(IntPtr obj,
	string p0);

   public virtual void readString(string p0)
   {
      vpr_ObjectReader_readString__std_string1(mRawObject, p0);
   }


   // Delegate for the readBool() callback.
   public delegate void readBoolDelegate_bool(ref bool p0);
   protected readBoolDelegate_bool m_readBoolDelegate_bool;

   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static void vpr_ObjectReader_readBool__bool1(IntPtr obj,
	ref bool p0);

   public virtual void readBool(ref bool p0)
   {
      vpr_ObjectReader_readBool__bool1(mRawObject, ref p0);
   }


   // End of virtual methods.


} // class vpr.ObjectReader

/// <summary>
/// Custom marshaler for vpr.ObjectReader.  Use this with P/Invoke
/// calls when a C# object of this type needs to be passed to native code or
/// vice versa.  Essentially, this marshaler hides the existence of mRawObject.
/// </summary>
public class ObjectReaderMarshaler : ICustomMarshaler
{
   private class DummyObjectReader : vpr.ObjectReader
   {

      public DummyObjectReader(IntPtr rawObject)
         : base(new NoInitTag())
      {
         mRawObject = rawObject;
         mWeOwnMemory = false;
      }

      [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
      private extern static void vpr_ObjectReader_beginTag__std_string1(IntPtr obj,
	string p0);

      public override void beginTag(string p0)
      {
         vpr_ObjectReader_beginTag__std_string1(mRawObject, p0);
      }

      [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
      private extern static void vpr_ObjectReader_endTag__0(IntPtr obj);

      public override void endTag()
      {
         vpr_ObjectReader_endTag__0(mRawObject);
      }

      [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
      private extern static void vpr_ObjectReader_beginAttribute__std_string1(IntPtr obj,
	string p0);

      public override void beginAttribute(string p0)
      {
         vpr_ObjectReader_beginAttribute__std_string1(mRawObject, p0);
      }

      [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
      private extern static void vpr_ObjectReader_endAttribute__0(IntPtr obj);

      public override void endAttribute()
      {
         vpr_ObjectReader_endAttribute__0(mRawObject);
      }

      [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
      private extern static void vpr_ObjectReader_resetReading__0(IntPtr obj);

      public override void resetReading()
      {
         vpr_ObjectReader_resetReading__0(mRawObject);
      }

      [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
      private extern static void vpr_ObjectReader_pushState__0(IntPtr obj);

      public override void pushState()
      {
         vpr_ObjectReader_pushState__0(mRawObject);
      }

      [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
      private extern static void vpr_ObjectReader_popState__0(IntPtr obj);

      public override void popState()
      {
         vpr_ObjectReader_popState__0(mRawObject);
      }

      [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
      private extern static byte vpr_ObjectReader_readUint8__0(IntPtr obj);

      public override byte readUint8()
      {
         byte result;
         result = vpr_ObjectReader_readUint8__0(mRawObject);
         return result;
      }

      [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
      private extern static ushort vpr_ObjectReader_readUint16__0(IntPtr obj);

      public override ushort readUint16()
      {
         ushort result;
         result = vpr_ObjectReader_readUint16__0(mRawObject);
         return result;
      }

      [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
      private extern static uint vpr_ObjectReader_readUint32__0(IntPtr obj);

      public override uint readUint32()
      {
         uint result;
         result = vpr_ObjectReader_readUint32__0(mRawObject);
         return result;
      }

      [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
      private extern static ulong vpr_ObjectReader_readUint64__0(IntPtr obj);

      public override ulong readUint64()
      {
         ulong result;
         result = vpr_ObjectReader_readUint64__0(mRawObject);
         return result;
      }

      [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
      private extern static float vpr_ObjectReader_readFloat__0(IntPtr obj);

      public override float readFloat()
      {
         float result;
         result = vpr_ObjectReader_readFloat__0(mRawObject);
         return result;
      }

      [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
      private extern static double vpr_ObjectReader_readDouble__0(IntPtr obj);

      public override double readDouble()
      {
         double result;
         result = vpr_ObjectReader_readDouble__0(mRawObject);
         return result;
      }

      [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
      private extern static string vpr_ObjectReader_readString__0(IntPtr obj);

      public override string readString()
      {
         string result;
         result = vpr_ObjectReader_readString__0(mRawObject);
         return result;
      }

      [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
      private extern static bool vpr_ObjectReader_readBool__0(IntPtr obj);

      public override bool readBool()
      {
         bool result;
         result = vpr_ObjectReader_readBool__0(mRawObject);
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
      return ((vpr.ObjectReader) obj).RawObject;
   }

   // Marshaling for native memory coming from C++.
   public Object MarshalNativeToManaged(IntPtr nativeObj)
   {
      return new DummyObjectReader(nativeObj);
   }

   public static ICustomMarshaler GetInstance(string cookie)
   {
      return mInstance;
   }

   private static ObjectReaderMarshaler mInstance = new ObjectReaderMarshaler();
}


} // namespace vpr
