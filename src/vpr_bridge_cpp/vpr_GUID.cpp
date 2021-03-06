// VRJ.NET is (C) Copyright 2004-2007 by Patrick Hartling
// Distributed under the GNU Lesser General Public License 2.1.  (See
// accompanying file COPYING.txt or http://www.gnu.org/copyleft/lesser.txt)

// Generated from Revision: 1.64 of RCSfile: class_cxx.tmpl,v



#include "sharppy.h"
#include <vpr/Util/GUID.h>

extern "C"
{
   // Constructor wrapper.
   SHARPPY_API vpr::GUID* vpr_GUID_GUID__vpr_GUID_GenerateTag1(const vpr::GUID::GenerateTag* p0)
   {
      const vpr::GUID::GenerateTag& marshal_p0 = *p0;
      vpr::GUID* obj = new vpr::GUID(marshal_p0);
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API vpr::GUID* vpr_GUID_GUID__0()
   {
      vpr::GUID* obj = new vpr::GUID();
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API vpr::GUID* vpr_GUID_GUID__vpr_GUID_StdGUID1(const vpr::GUID::StdGUID* p0)
   {
      const vpr::GUID::StdGUID& marshal_p0 = *p0;
      vpr::GUID* obj = new vpr::GUID(marshal_p0);
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API vpr::GUID* vpr_GUID_GUID__std_string1(const char* p0)
   {
      vpr::GUID* obj = new vpr::GUID(p0);
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API vpr::GUID* vpr_GUID_GUID__vpr_GUID_std_string2(const vpr::GUID* p0, const char* p1)
   {
      const vpr::GUID& marshal_p0 = *p0;
      vpr::GUID* obj = new vpr::GUID(marshal_p0, p1);
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API vpr::GUID* vpr_GUID_GUID__vpr_GUID1(const vpr::GUID* p0)
   {
      const vpr::GUID& marshal_p0 = *p0;
      vpr::GUID* obj = new vpr::GUID(marshal_p0);
      return obj;
   }

   SHARPPY_API void delete_vpr_GUID(vpr::GUID* self_)
   {
      delete self_;
   }

   // Wrapper for non-virtual method vpr::GUID::toString()
   SHARPPY_API char* vpr_GUID_toString__0(vpr::GUID* self_)
   {
      std::string temp_result;
      char* result;
      temp_result = self_->toString();
      result = strdup(temp_result.c_str());
      return result;
   }


   // Wrapper for non-virtual method vpr::GUID::generate()
   SHARPPY_API void vpr_GUID_generate__0(vpr::GUID* self_)
   {
      self_->generate();
   }


   // Wrapper for non-virtual method vpr::GUID::generate()
   SHARPPY_API void vpr_GUID_generate__vpr_GUID_std_string2(vpr::GUID* self_, const vpr::GUID* p0, const char* p1)
   {
      const vpr::GUID& marshal_p0 = *p0;
      self_->generate(marshal_p0, p1);
   }


   // Wrapper for virtual method vpr::GUID::writeObject()
   SHARPPY_API void vpr_GUID_writeObject__vpr_ObjectWriter1(vpr::GUID* self_, vpr::ObjectWriter* p0)
   {
      self_->writeObject(p0);
   }


   // Wrapper for virtual method vpr::GUID::readObject()
   SHARPPY_API void vpr_GUID_readObject__vpr_ObjectReader1(vpr::GUID* self_, vpr::ObjectReader* p0)
   {
      self_->readObject(p0);
   }


   // Wrapper for reading static data member vpr::GUID::generateTag
   SHARPPY_API vpr::GUID::GenerateTag* vpr_GUID_generateTag_get()
   {
      return &vpr::GUID::generateTag;
   }

   // Wrapper for modifying static data member vpr::GUID::generateTag
   SHARPPY_API void vpr_GUID_generateTag_set(vpr::GUID::GenerateTag* v)
   {
      vpr::GUID::generateTag = *v;
   }

   // Wrapper for reading static data member vpr::GUID::NullGUID
   SHARPPY_API const vpr::GUID* vpr_GUID_NullGUID_get()
   {
      return &vpr::GUID::NullGUID;
   }


   // Wrapper for non-virtual method vpr::GUID::operator ==()
   SHARPPY_API bool vpr_GUID_equal__vpr_GUID1(vpr::GUID* self_, const vpr::GUID* p0)
   {
      const vpr::GUID& marshal_p0 = *p0;
      bool result;
      result = self_->operator==(marshal_p0);
      return result;
   }


   // Wrapper for non-virtual method vpr::GUID::operator !=()
   SHARPPY_API bool vpr_GUID_not_equal__vpr_GUID1(vpr::GUID* self_, const vpr::GUID* p0)
   {
      const vpr::GUID& marshal_p0 = *p0;
      bool result;
      result = self_->operator!=(marshal_p0);
      return result;
   }


   // Wrapper for non-virtual method vpr::GUID::operator <()
   SHARPPY_API bool vpr_GUID_less_than__vpr_GUID1(vpr::GUID* self_, const vpr::GUID* p0)
   {
      const vpr::GUID& marshal_p0 = *p0;
      bool result;
      result = self_->operator<(marshal_p0);
      return result;
   }


} // extern "C" for vpr::GUID

// Nested class vpr::GUID::GenerateTag.
extern "C"
{
   // Constructor wrapper.
   SHARPPY_API vpr::GUID::GenerateTag* vpr_GUID_GenerateTag_GenerateTag__vpr_GUID_GenerateTag1(const vpr::GUID::GenerateTag* p0)
   {
      const vpr::GUID::GenerateTag& marshal_p0 = *p0;
      vpr::GUID::GenerateTag* obj = new vpr::GUID::GenerateTag(marshal_p0);
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API vpr::GUID::GenerateTag* vpr_GUID_GenerateTag_GenerateTag__0()
   {
      vpr::GUID::GenerateTag* obj = new vpr::GUID::GenerateTag();
      return obj;
   }

   SHARPPY_API void delete_vpr_GUID_GenerateTag(vpr::GUID::GenerateTag* self_)
   {
      delete self_;
   }

} // extern "C" for vpr::GUID::GenerateTag


// Nested class vpr::GUID::StdGUID.
extern "C"
{
   // Constructor wrapper.
   SHARPPY_API vpr::GUID::StdGUID* vpr_GUID_StdGUID_StdGUID__vpr_GUID_StdGUID1(const vpr::GUID::StdGUID* p0)
   {
      const vpr::GUID::StdGUID& marshal_p0 = *p0;
      vpr::GUID::StdGUID* obj = new vpr::GUID::StdGUID(marshal_p0);
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API vpr::GUID::StdGUID* vpr_GUID_StdGUID_StdGUID__0()
   {
      vpr::GUID::StdGUID* obj = new vpr::GUID::StdGUID();
      return obj;
   }

   SHARPPY_API void delete_vpr_GUID_StdGUID(vpr::GUID::StdGUID* self_)
   {
      delete self_;
   }

} // extern "C" for vpr::GUID::StdGUID


// Nested class vpr::GUID::hash.
extern "C"
{
   // Constructor wrapper.
   SHARPPY_API vpr::GUID::hash* vpr_GUID_hash_hash__vpr_GUID_hash1(const vpr::GUID::hash* p0)
   {
      const vpr::GUID::hash& marshal_p0 = *p0;
      vpr::GUID::hash* obj = new vpr::GUID::hash(marshal_p0);
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API vpr::GUID::hash* vpr_GUID_hash_hash__0()
   {
      vpr::GUID::hash* obj = new vpr::GUID::hash();
      return obj;
   }

   SHARPPY_API void delete_vpr_GUID_hash(vpr::GUID::hash* self_)
   {
      delete self_;
   }

} // extern "C" for vpr::GUID::hash



