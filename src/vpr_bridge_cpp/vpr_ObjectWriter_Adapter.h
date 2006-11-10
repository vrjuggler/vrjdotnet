// VRJ.NET is (C) Copyright 2004 by Patrick Hartling
// Distributed under the GNU Lesser General Public License 2.1.  (See
// accompanying file COPYING.txt or http://www.gnu.org/copyleft/lesser.txt)

// File:          $RCSfile$
// Date modified: $Date$
// Version:       $Revision$

// Generated from Revision: 1.18 of RCSfile: class_cxx_adapter.tmpl,v


#ifndef __VPR_OBJECTWRITER_ADAPTER__
#define __VPR_OBJECTWRITER_ADAPTER__

#include "sharppy.h"
#include <vpr/IO/ObjectWriter.h>

class SHARPPY_API vpr_ObjectWriter_Adapter : public vpr::ObjectWriter
{
public:
   virtual ~vpr_ObjectWriter_Adapter()
   {;}

   typedef void (*beginTag_callback_std_string_t)(char*);
   beginTag_callback_std_string_t beginTag_callback_std_string;

   /// Override for virtual function vpr::ObjectWriter::beginTag.
   virtual void beginTag(std::string p0)
   {
      char* marshal_p0 = strdup(p0.c_str());
      beginTag_callback_std_string(marshal_p0);
      free(marshal_p0);
   }

   typedef void (*endTag_callback_t)();
   endTag_callback_t endTag_callback;

   /// Override for virtual function vpr::ObjectWriter::endTag.
   virtual void endTag()
   {
      endTag_callback();
   }

   typedef void (*beginAttribute_callback_std_string_t)(char*);
   beginAttribute_callback_std_string_t beginAttribute_callback_std_string;

   /// Override for virtual function vpr::ObjectWriter::beginAttribute.
   virtual void beginAttribute(std::string p0)
   {
      char* marshal_p0 = strdup(p0.c_str());
      beginAttribute_callback_std_string(marshal_p0);
      free(marshal_p0);
   }

   typedef void (*endAttribute_callback_t)();
   endAttribute_callback_t endAttribute_callback;

   /// Override for virtual function vpr::ObjectWriter::endAttribute.
   virtual void endAttribute()
   {
      endAttribute_callback();
   }

   typedef void (*writeUint8_callback_vpr_Uint8_t)(vpr::Uint8);
   writeUint8_callback_vpr_Uint8_t writeUint8_callback_vpr_Uint8;

   /// Override for virtual function vpr::ObjectWriter::writeUint8.
   virtual void writeUint8(vpr::Uint8 p0)
   {
      writeUint8_callback_vpr_Uint8(p0);
   }

   typedef void (*writeUint16_callback_vpr_Uint16_t)(vpr::Uint16);
   writeUint16_callback_vpr_Uint16_t writeUint16_callback_vpr_Uint16;

   /// Override for virtual function vpr::ObjectWriter::writeUint16.
   virtual void writeUint16(vpr::Uint16 p0)
   {
      writeUint16_callback_vpr_Uint16(p0);
   }

   typedef void (*writeUint32_callback_vpr_Uint32_t)(vpr::Uint32);
   writeUint32_callback_vpr_Uint32_t writeUint32_callback_vpr_Uint32;

   /// Override for virtual function vpr::ObjectWriter::writeUint32.
   virtual void writeUint32(vpr::Uint32 p0)
   {
      writeUint32_callback_vpr_Uint32(p0);
   }

   typedef void (*writeUint64_callback_vpr_Uint64_t)(vpr::Uint64);
   writeUint64_callback_vpr_Uint64_t writeUint64_callback_vpr_Uint64;

   /// Override for virtual function vpr::ObjectWriter::writeUint64.
   virtual void writeUint64(vpr::Uint64 p0)
   {
      writeUint64_callback_vpr_Uint64(p0);
   }

   typedef void (*writeFloat_callback_float_t)(float);
   writeFloat_callback_float_t writeFloat_callback_float;

   /// Override for virtual function vpr::ObjectWriter::writeFloat.
   virtual void writeFloat(float p0)
   {
      writeFloat_callback_float(p0);
   }

   typedef void (*writeDouble_callback_double_t)(double);
   writeDouble_callback_double_t writeDouble_callback_double;

   /// Override for virtual function vpr::ObjectWriter::writeDouble.
   virtual void writeDouble(double p0)
   {
      writeDouble_callback_double(p0);
   }

   typedef void (*writeString_callback_std_string_t)(char*);
   writeString_callback_std_string_t writeString_callback_std_string;

   /// Override for virtual function vpr::ObjectWriter::writeString.
   virtual void writeString(std::string p0)
   {
      char* marshal_p0 = strdup(p0.c_str());
      writeString_callback_std_string(marshal_p0);
      free(marshal_p0);
   }

   typedef void (*writeBool_callback_bool_t)(bool);
   writeBool_callback_bool_t writeBool_callback_bool;

   /// Override for virtual function vpr::ObjectWriter::writeBool.
   virtual void writeBool(bool p0)
   {
      writeBool_callback_bool(p0);
   }

}; // class vpr_ObjectWriter_Adapter




#endif
