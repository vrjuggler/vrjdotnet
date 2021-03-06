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

public abstract class ObjectWriter
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
      m_writeUint8Delegate_vpr_Uint8 = new writeUint8Delegate_vpr_Uint8(writeUint8Adapter);
      m_writeUint16Delegate_vpr_Uint16 = new writeUint16Delegate_vpr_Uint16(writeUint16Adapter);
      m_writeUint32Delegate_vpr_Uint32 = new writeUint32Delegate_vpr_Uint32(writeUint32Adapter);
      m_writeUint64Delegate_vpr_Uint64 = new writeUint64Delegate_vpr_Uint64(writeUint64Adapter);
      m_writeFloatDelegate_float = new writeFloatDelegate_float(writeFloatAdapter);
      m_writeDoubleDelegate_double = new writeDoubleDelegate_double(writeDoubleAdapter);
      m_writeStringDelegate_std_string = new writeStringDelegate_std_string(writeStringAdapter);
      m_writeBoolDelegate_bool = new writeBoolDelegate_bool(writeBoolAdapter);
   }

   // Constructors.
   protected ObjectWriter(NoInitTag doInit)
   {
      allocDelegates();
   }

   // Internal constructor needed for marshaling purposes.
   internal ObjectWriter(IntPtr instPtr, bool ownMemory)
   {
      mRawObject   = instPtr;
      mWeOwnMemory = ownMemory;
   }

   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static void delete_vpr_ObjectWriter(IntPtr obj);

   // Destructor.
   ~ObjectWriter()
   {
      if ( mWeOwnMemory && IntPtr.Zero != mRawObject )
      {
         delete_vpr_ObjectWriter(mRawObject);
         mWeOwnMemory = false;
         mRawObject   = IntPtr.Zero;
      }
   }

   // Operator overloads.

   // Converter operators.

   // Start of non-virtual methods.
   [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
   private extern static bool vpr_ObjectWriter_isBinary__0(IntPtr obj);

   public  bool isBinary()
   {
      bool result;
      result = vpr_ObjectWriter_isBinary__0(mRawObject);
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


   // Delegate for the writeUint8() callback.
   protected void writeUint8Adapter(byte p0)
   {
      writeUint8(p0);
   }

   public delegate void writeUint8Delegate_vpr_Uint8(byte p0);
   protected writeUint8Delegate_vpr_Uint8 m_writeUint8Delegate_vpr_Uint8;

   public abstract void writeUint8(byte p0);


   // Delegate for the writeUint16() callback.
   protected void writeUint16Adapter(ushort p0)
   {
      writeUint16(p0);
   }

   public delegate void writeUint16Delegate_vpr_Uint16(ushort p0);
   protected writeUint16Delegate_vpr_Uint16 m_writeUint16Delegate_vpr_Uint16;

   public abstract void writeUint16(ushort p0);


   // Delegate for the writeUint32() callback.
   protected void writeUint32Adapter(uint p0)
   {
      writeUint32(p0);
   }

   public delegate void writeUint32Delegate_vpr_Uint32(uint p0);
   protected writeUint32Delegate_vpr_Uint32 m_writeUint32Delegate_vpr_Uint32;

   public abstract void writeUint32(uint p0);


   // Delegate for the writeUint64() callback.
   protected void writeUint64Adapter(ulong p0)
   {
      writeUint64(p0);
   }

   public delegate void writeUint64Delegate_vpr_Uint64(ulong p0);
   protected writeUint64Delegate_vpr_Uint64 m_writeUint64Delegate_vpr_Uint64;

   public abstract void writeUint64(ulong p0);


   // Delegate for the writeFloat() callback.
   protected void writeFloatAdapter(float p0)
   {
      writeFloat(p0);
   }

   public delegate void writeFloatDelegate_float(float p0);
   protected writeFloatDelegate_float m_writeFloatDelegate_float;

   public abstract void writeFloat(float p0);


   // Delegate for the writeDouble() callback.
   protected void writeDoubleAdapter(double p0)
   {
      writeDouble(p0);
   }

   public delegate void writeDoubleDelegate_double(double p0);
   protected writeDoubleDelegate_double m_writeDoubleDelegate_double;

   public abstract void writeDouble(double p0);


   // Delegate for the writeString() callback.
   protected void writeStringAdapter(string p0)
   {
      writeString(p0);
   }

   public delegate void writeStringDelegate_std_string(string p0);
   protected writeStringDelegate_std_string m_writeStringDelegate_std_string;

   public abstract void writeString(string p0);


   // Delegate for the writeBool() callback.
   protected void writeBoolAdapter(bool p0)
   {
      writeBool(p0);
   }

   public delegate void writeBoolDelegate_bool(bool p0);
   protected writeBoolDelegate_bool m_writeBoolDelegate_bool;

   public abstract void writeBool(bool p0);


   // End of virtual methods.


} // class vpr.ObjectWriter

/// <summary>
/// Custom marshaler for vpr.ObjectWriter.  Use this with P/Invoke
/// calls when a C# object of this type needs to be passed to native code or
/// vice versa.  Essentially, this marshaler hides the existence of mRawObject.
/// </summary>
public class ObjectWriterMarshaler : ICustomMarshaler
{
   private class DummyObjectWriter : vpr.ObjectWriter
   {

      public DummyObjectWriter(IntPtr rawObject)
         : base(new NoInitTag())
      {
         mRawObject = rawObject;
         mWeOwnMemory = false;
      }

      [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
      private extern static void vpr_ObjectWriter_beginTag__std_string1(IntPtr obj,
	string p0);

      public override void beginTag(string p0)
      {
         vpr_ObjectWriter_beginTag__std_string1(mRawObject, p0);
      }

      [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
      private extern static void vpr_ObjectWriter_endTag__0(IntPtr obj);

      public override void endTag()
      {
         vpr_ObjectWriter_endTag__0(mRawObject);
      }

      [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
      private extern static void vpr_ObjectWriter_beginAttribute__std_string1(IntPtr obj,
	string p0);

      public override void beginAttribute(string p0)
      {
         vpr_ObjectWriter_beginAttribute__std_string1(mRawObject, p0);
      }

      [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
      private extern static void vpr_ObjectWriter_endAttribute__0(IntPtr obj);

      public override void endAttribute()
      {
         vpr_ObjectWriter_endAttribute__0(mRawObject);
      }

      [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
      private extern static void vpr_ObjectWriter_writeUint8__vpr_Uint81(IntPtr obj,
	byte p0);

      public override void writeUint8(byte p0)
      {
         vpr_ObjectWriter_writeUint8__vpr_Uint81(mRawObject, p0);
      }

      [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
      private extern static void vpr_ObjectWriter_writeUint16__vpr_Uint161(IntPtr obj,
	ushort p0);

      public override void writeUint16(ushort p0)
      {
         vpr_ObjectWriter_writeUint16__vpr_Uint161(mRawObject, p0);
      }

      [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
      private extern static void vpr_ObjectWriter_writeUint32__vpr_Uint321(IntPtr obj,
	uint p0);

      public override void writeUint32(uint p0)
      {
         vpr_ObjectWriter_writeUint32__vpr_Uint321(mRawObject, p0);
      }

      [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
      private extern static void vpr_ObjectWriter_writeUint64__vpr_Uint641(IntPtr obj,
	ulong p0);

      public override void writeUint64(ulong p0)
      {
         vpr_ObjectWriter_writeUint64__vpr_Uint641(mRawObject, p0);
      }

      [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
      private extern static void vpr_ObjectWriter_writeFloat__float1(IntPtr obj,
	float p0);

      public override void writeFloat(float p0)
      {
         vpr_ObjectWriter_writeFloat__float1(mRawObject, p0);
      }

      [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
      private extern static void vpr_ObjectWriter_writeDouble__double1(IntPtr obj,
	double p0);

      public override void writeDouble(double p0)
      {
         vpr_ObjectWriter_writeDouble__double1(mRawObject, p0);
      }

      [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
      private extern static void vpr_ObjectWriter_writeString__std_string1(IntPtr obj,
	string p0);

      public override void writeString(string p0)
      {
         vpr_ObjectWriter_writeString__std_string1(mRawObject, p0);
      }

      [DllImport("vpr_bridge", CharSet = CharSet.Ansi)]
      private extern static void vpr_ObjectWriter_writeBool__bool1(IntPtr obj,
	bool p0);

      public override void writeBool(bool p0)
      {
         vpr_ObjectWriter_writeBool__bool1(mRawObject, p0);
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
      return ((vpr.ObjectWriter) obj).RawObject;
   }

   // Marshaling for native memory coming from C++.
   public Object MarshalNativeToManaged(IntPtr nativeObj)
   {
      return new DummyObjectWriter(nativeObj);
   }

   public static ICustomMarshaler GetInstance(string cookie)
   {
      return mInstance;
   }

   private static ObjectWriterMarshaler mInstance = new ObjectWriterMarshaler();
}


} // namespace vpr
