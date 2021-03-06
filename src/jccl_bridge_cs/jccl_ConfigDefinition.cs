#region License
// VRJ.NET is (C) Copyright 2004-2007 by Patrick Hartling
// Distributed under the GNU Lesser General Public License 2.1.  (See
// accompanying file COPYING.txt or http://www.gnu.org/copyleft/lesser.txt)
#endregion License

// Generated from Revision: 1.79 of RCSfile: class_cs.tmpl,v
using System;
using System.Runtime.InteropServices;
using System.Reflection;





namespace jccl
{

public sealed class ConfigDefinition
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

   // Constructors.
   [DllImport("jccl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr jccl_ConfigDefinition_ConfigDefinition__0();

   public ConfigDefinition()
   {
      mRawObject   = jccl_ConfigDefinition_ConfigDefinition__0();
      mWeOwnMemory = true;
   }

/*
   [DllImport("jccl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr jccl_ConfigDefinition_ConfigDefinition__std_string_cppdom_NodePtr2(string p0, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(cppdom.NodeMarshaler))] cppdom.Node p1);

   public ConfigDefinition(string p0, cppdom.Node p1)
   {
      mRawObject   = jccl_ConfigDefinition_ConfigDefinition__std_string_cppdom_NodePtr2(p0, p1);
      mWeOwnMemory = true;
   }
*/

   [DllImport("jccl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr jccl_ConfigDefinition_ConfigDefinition__jccl_ConfigDefinition1([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(jccl.ConfigDefinitionMarshaler))] jccl.ConfigDefinition p0);

   public ConfigDefinition(jccl.ConfigDefinition p0)
   {
      mRawObject   = jccl_ConfigDefinition_ConfigDefinition__jccl_ConfigDefinition1(p0);
      mWeOwnMemory = true;
   }

   // Internal constructor needed for marshaling purposes.
   internal ConfigDefinition(IntPtr instPtr, bool ownMemory)
   {
      mRawObject   = instPtr;
      mWeOwnMemory = ownMemory;
   }

   [DllImport("jccl_bridge", CharSet = CharSet.Ansi)]
   private extern static void delete_jccl_ConfigDefinition(IntPtr obj);

   // Destructor.
   ~ConfigDefinition()
   {
      if ( mWeOwnMemory && IntPtr.Zero != mRawObject )
      {
         delete_jccl_ConfigDefinition(mRawObject);
         mWeOwnMemory = false;
         mRawObject   = IntPtr.Zero;
      }
   }

   // Operator overloads.

   public override bool Equals(object obj)
   {
      if ( ! (obj is jccl.ConfigDefinition) )
      {
         return false;
      }
      return this == (jccl.ConfigDefinition) obj;
   }

   [DllImport("jccl_bridge", CharSet = CharSet.Ansi)]
   private extern static bool jccl_ConfigDefinition_equal__jccl_ConfigDefinition(IntPtr lhs,
	[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(jccl.ConfigDefinitionMarshaler))] jccl.ConfigDefinition rhs);

   public static bool operator==(jccl.ConfigDefinition lhs, jccl.ConfigDefinition rhs)
   {
      bool result;
      result = jccl_ConfigDefinition_equal__jccl_ConfigDefinition(lhs.mRawObject, rhs);
      return result;
   }

   [DllImport("jccl_bridge", CharSet = CharSet.Ansi)]
   private extern static bool jccl_ConfigDefinition_not_equal__jccl_ConfigDefinition(IntPtr lhs,
	[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(jccl.ConfigDefinitionMarshaler))] jccl.ConfigDefinition rhs);

   public static bool operator!=(jccl.ConfigDefinition lhs, jccl.ConfigDefinition rhs)
   {
      bool result;
      result = jccl_ConfigDefinition_not_equal__jccl_ConfigDefinition(lhs.mRawObject, rhs);
      return result;
   }

   // Converter operators.

   // Start of non-virtual methods.
   [DllImport("jccl_bridge", CharSet = CharSet.Ansi)]
   private extern static string jccl_ConfigDefinition_getName__0(IntPtr obj);

   public  string getName()
   {
      string result;
      result = jccl_ConfigDefinition_getName__0(mRawObject);
      return result;
   }


   [DllImport("jccl_bridge", CharSet = CharSet.Ansi)]
   private extern static string jccl_ConfigDefinition_getToken__0(IntPtr obj);

   public  string getToken()
   {
      string result;
      result = jccl_ConfigDefinition_getToken__0(mRawObject);
      return result;
   }


   [DllImport("jccl_bridge", CharSet = CharSet.Ansi)]
   private extern static uint jccl_ConfigDefinition_getVersion__0(IntPtr obj);

   public  uint getVersion()
   {
      uint result;
      result = jccl_ConfigDefinition_getVersion__0(mRawObject);
      return result;
   }


   [DllImport("jccl_bridge", CharSet = CharSet.Ansi)]
   private extern static string jccl_ConfigDefinition_getHelp__0(IntPtr obj);

   public  string getHelp()
   {
      string result;
      result = jccl_ConfigDefinition_getHelp__0(mRawObject);
      return result;
   }


   // End of non-virtual methods.

   // Start of virtual methods.
   // End of virtual methods.


} // class jccl.ConfigDefinition

/// <summary>
/// Custom marshaler for jccl.ConfigDefinition.  Use this with P/Invoke
/// calls when a C# object of this type needs to be passed to native code or
/// vice versa.  Essentially, this marshaler hides the existence of mRawObject.
/// </summary>
public class ConfigDefinitionMarshaler : ICustomMarshaler
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
      return ((jccl.ConfigDefinition) obj).RawObject;
   }

   // Marshaling for native memory coming from C++.
   public Object MarshalNativeToManaged(IntPtr nativeObj)
   {
      return new jccl.ConfigDefinition(nativeObj, false);
   }

   public static ICustomMarshaler GetInstance(string cookie)
   {
      return mInstance;
   }

   private static ConfigDefinitionMarshaler mInstance = new ConfigDefinitionMarshaler();
}


} // namespace jccl
