/*************** <auto-copyright.pl BEGIN do not edit this line> **************
 *
 * VRJ.NET is (C) Copyright 2004 by Patrick Hartling
 *
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Library General Public
 * License as published by the Free Software Foundation; either
 * version 2 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Library General Public License for more details.
 *
 * You should have received a copy of the GNU Library General Public
 * License along with this library; if not, write to the
 * Free Software Foundation, Inc., 59 Temple Place - Suite 330,
 * Boston, MA 02111-1307, USA.
 *
 * -----------------------------------------------------------------
 * File:          $RCSfile$
 * Date modified: $Date$
 * Version:       $Revision$
 * -----------------------------------------------------------------
 *
 *************** <auto-copyright.pl END do not edit this line> ***************/

// Generated from $Revision$ of $RCSfile$
using System;
using System.Runtime.InteropServices;
using System.Reflection;





namespace vrj
{

public sealed class Display
{
   protected internal IntPtr mRawObject = IntPtr.Zero;
   protected bool mWeOwnMemory = false;
   protected class NoInitTag {}

   internal IntPtr RawObject
   {
      get { return mRawObject; }
   }

   private void allocDelegates()
   {
   }

   // Constructors.
   protected Display(NoInitTag doInit)
   {
      allocDelegates();
   }

   [DllImport("vrj_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr vrj_Display_Display__vrj_Display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(vrj.DisplayMarshaler))] vrj.Display p0);

   public Display(vrj.Display p0)
   {
      allocDelegates();
      
      mRawObject   = vrj_Display_Display__vrj_Display(p0);
      mWeOwnMemory = true;
      
   }

   [DllImport("vrj_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr vrj_Display_Display__();

   public Display()
   {
      allocDelegates();
      mRawObject   = vrj_Display_Display__();
      mWeOwnMemory = true;
   }

   // Internal constructor needed for marshaling purposes.
   internal Display(IntPtr instPtr, bool ownMemory)
   {
      mRawObject   = instPtr;
      mWeOwnMemory = ownMemory;
   }

   [DllImport("vrj_bridge", CharSet = CharSet.Ansi)]
   private extern static void delete_vrj_Display(IntPtr obj);

   // Destructor.
   ~Display()
   {
      if ( mWeOwnMemory && IntPtr.Zero != mRawObject )
      {
         delete_vrj_Display(mRawObject);
         mWeOwnMemory = false;
         mRawObject   = IntPtr.Zero;
      }
   }

   // Operator overloads.

   // Converter operators.

   // Start of non-virtual methods.
   [DllImport("vrj_bridge", CharSet = CharSet.Ansi)]
   private extern static void vrj_Display_configDisplayWindow__boost_shared_ptr_jccl__ConfigElement(IntPtr obj,
	[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(jccl.ConfigElementMarshaler))] jccl.ConfigElement p0);

   public  void configDisplayWindow(jccl.ConfigElement p0)
   {
      vrj_Display_configDisplayWindow__boost_shared_ptr_jccl__ConfigElement(mRawObject, p0);
   }

   [DllImport("vrj_bridge", CharSet = CharSet.Ansi)]
   private extern static void vrj_Display_configViewports__boost_shared_ptr_jccl__ConfigElement(IntPtr obj,
	[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(jccl.ConfigElementMarshaler))] jccl.ConfigElement p0);

   public  void configViewports(jccl.ConfigElement p0)
   {
      vrj_Display_configViewports__boost_shared_ptr_jccl__ConfigElement(mRawObject, p0);
   }

   [DllImport("vrj_bridge", CharSet = CharSet.Ansi)]
   private extern static void vrj_Display_updateProjections__float(IntPtr obj,
	float p0);

   public  void updateProjections(float p0)
   {
      vrj_Display_updateProjections__float(mRawObject, p0);
   }

   [DllImport("vrj_bridge", CharSet = CharSet.Ansi)]
   private extern static bool vrj_Display_isActive__(IntPtr obj);

   public  bool isActive()
   {
      bool result;
      result = vrj_Display_isActive__(mRawObject);
      return result;
   }

   [DllImport("vrj_bridge", CharSet = CharSet.Ansi)]
   private extern static void vrj_Display_setName__std_basic_string_char_std__char_traits_char__std__allocator_char__(IntPtr obj,
	string p0);

   public  void setName(string p0)
   {
      vrj_Display_setName__std_basic_string_char_std__char_traits_char__std__allocator_char__(mRawObject, p0);
   }

   [DllImport("vrj_bridge", CharSet = CharSet.Ansi)]
   private extern static string vrj_Display_getName__(IntPtr obj);

   public  string getName()
   {
      string result;
      result = vrj_Display_getName__(mRawObject);
      return result;
   }

   [DllImport("vrj_bridge", CharSet = CharSet.Ansi)]
   private extern static bool vrj_Display_shouldDrawBorder__(IntPtr obj);

   public  bool shouldDrawBorder()
   {
      bool result;
      result = vrj_Display_shouldDrawBorder__(mRawObject);
      return result;
   }

   [DllImport("vrj_bridge", CharSet = CharSet.Ansi)]
   private extern static void vrj_Display_setOriginAndSize__int_int_int_int_bool(IntPtr obj,
	int p0,
	int p1,
	int p2,
	int p3,
	bool p4);

   public  void setOriginAndSize(int p0, int p1, int p2, int p3, bool p4)
   {
      vrj_Display_setOriginAndSize__int_int_int_int_bool(mRawObject, p0, p1, p2, p3, p4);
   }

   [DllImport("vrj_bridge", CharSet = CharSet.Ansi)]
   private extern static void vrj_Display_getOriginAndSize__int_int_int_int(IntPtr obj,
	ref int p0,
	ref int p1,
	ref int p2,
	ref int p3);

   public  void getOriginAndSize(ref int p0, ref int p1, ref int p2, ref int p3)
   {
      
      
      
      
      vrj_Display_getOriginAndSize__int_int_int_int(mRawObject, ref p0, ref p1, ref p2, ref p3);
      
      
      
      
   }

   [DllImport("vrj_bridge", CharSet = CharSet.Ansi)]
   private extern static void vrj_Display_setPipe__int(IntPtr obj,
	int p0);

   public  void setPipe(int p0)
   {
      vrj_Display_setPipe__int(mRawObject, p0);
   }

   [DllImport("vrj_bridge", CharSet = CharSet.Ansi)]
   private extern static int vrj_Display_getPipe__(IntPtr obj);

   public  int getPipe()
   {
      int result;
      result = vrj_Display_getPipe__(mRawObject);
      return result;
   }

   [DllImport("vrj_bridge", CharSet = CharSet.Ansi)]
   private extern static bool vrj_Display_isStereoRequested__(IntPtr obj);

   public  bool isStereoRequested()
   {
      bool result;
      result = vrj_Display_isStereoRequested__(mRawObject);
      return result;
   }

   [DllImport("vrj_bridge", CharSet = CharSet.Ansi)]
   [return : MarshalAs(UnmanagedType.CustomMarshaler,
                       MarshalTypeRef = typeof(jccl.ConfigElementMarshaler))]
   private extern static jccl.ConfigElement vrj_Display_getConfigElement__(IntPtr obj);

   public  jccl.ConfigElement getConfigElement()
   {
      jccl.ConfigElement result;
      result = vrj_Display_getConfigElement__(mRawObject);
      return result;
   }

   [DllImport("vrj_bridge", CharSet = CharSet.Ansi)]
   [return : MarshalAs(UnmanagedType.CustomMarshaler,
                       MarshalTypeRef = typeof(jccl.ConfigElementMarshaler))]
   private extern static jccl.ConfigElement vrj_Display_getGlFrameBufferConfig__(IntPtr obj);

   public  jccl.ConfigElement getGlFrameBufferConfig()
   {
      jccl.ConfigElement result;
      result = vrj_Display_getGlFrameBufferConfig__(mRawObject);
      return result;
   }

   [DllImport("vrj_bridge", CharSet = CharSet.Ansi)]
   private extern static uint vrj_Display_getNumViewports__(IntPtr obj);

   public  uint getNumViewports()
   {
      uint result;
      result = vrj_Display_getNumViewports__(mRawObject);
      return result;
   }

   // End of non-virtual methods.

   // Start of virtual methods.
   // End of virtual methods.

   // Start of virtual methods.
   [DllImport("vrj_bridge", CharSet = CharSet.Ansi)]
   private extern static void vrj_Display_config__boost_shared_ptr_jccl__ConfigElement(IntPtr obj,
	[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(jccl.ConfigElementMarshaler))] jccl.ConfigElement p0);

   public  void config(jccl.ConfigElement p0)
   {
      vrj_Display_config__boost_shared_ptr_jccl__ConfigElement(mRawObject, p0);
   }

   // End of virtual methods.


} // class vrj.Display

/// <summary>
/// Custom marshaler for vrj.Display.  Use this with P/Invoke
/// calls when a C# object of this type needs to be passed to native code or
/// vice versa.  Essentially, this marshaler hides the existence of mRawObject.
/// </summary>
public class DisplayMarshaler : ICustomMarshaler
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
      return ((vrj.Display) obj).mRawObject;
   }

   // Marshaling for native memory coming from C++.
   public Object MarshalNativeToManaged(IntPtr nativeObj)
   {
      return new vrj.Display(nativeObj, false);
   }

   public static ICustomMarshaler GetInstance(string cookie)
   {
      return mInstance;
   }

   private static DisplayMarshaler mInstance = new DisplayMarshaler();
}


} // namespace vrj