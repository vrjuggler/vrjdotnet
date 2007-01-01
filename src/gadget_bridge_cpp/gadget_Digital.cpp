// VRJ.NET is (C) Copyright 2004-2007 by Patrick Hartling
// Distributed under the GNU Lesser General Public License 2.1.  (See
// accompanying file COPYING.txt or http://www.gnu.org/copyleft/lesser.txt)

// Generated from Revision: 1.64 of RCSfile: class_cxx.tmpl,v



#include "sharppy.h"
#include <gadget/Type/Digital.h>
#include <gadget_Digital_Adapter.h>

extern "C"
{
   // Constructor wrapper.
   SHARPPY_API gadget_Digital_Adapter* gadget_Digital_Digital__0(gadget_Digital_Adapter::config_callback_jccl_ConfigElementPtr_t cb0, gadget_Digital_Adapter::writeObject_callback_vpr_ObjectWriter_t cb1, gadget_Digital_Adapter::readObject_callback_vpr_ObjectReader_t cb2)
   {
      gadget_Digital_Adapter* obj = new gadget_Digital_Adapter();
      obj->config_callback_jccl_ConfigElementPtr = cb0;
      obj->writeObject_callback_vpr_ObjectWriter = cb1;
      obj->readObject_callback_vpr_ObjectReader = cb2;
      return obj;
   }

   SHARPPY_API void delete_gadget_Digital(gadget_Digital_Adapter* self_)
   {
      delete self_;
   }

   // Wrapper for non-virtual method gadget::Digital::getDigitalData()
   SHARPPY_API gadget::DigitalData* gadget_Digital_getDigitalData__int0(gadget_Digital_Adapter* self_)
   {
      gadget::DigitalData* result;
      result = new gadget::DigitalData(self_->getDigitalData());
      return result;
   }

   // Wrapper for non-virtual method gadget::Digital::getDigitalData()
   SHARPPY_API gadget::DigitalData* gadget_Digital_getDigitalData__int1(gadget_Digital_Adapter* self_, int p0)
   {
      gadget::DigitalData* result;
      result = new gadget::DigitalData(self_->getDigitalData(p0));
      return result;
   }


   // Wrapper for non-virtual method gadget::Digital::swapDigitalBuffers()
   SHARPPY_API void gadget_Digital_swapDigitalBuffers__0(gadget_Digital_Adapter* self_)
   {
      self_->swapDigitalBuffers();
   }


   // Wrapper for virtual method gadget::Digital::config()
   SHARPPY_API bool gadget_Digital_config__jccl_ConfigElementPtr1(gadget_Digital_Adapter* self_, jccl::ConfigElementPtr* p0)
   {
      bool result;
      result = self_->gadget::Digital::config(*p0);
      return result;
   }


   // Wrapper for virtual method gadget::Digital::writeObject()
   SHARPPY_API void gadget_Digital_writeObject__vpr_ObjectWriter1(gadget_Digital_Adapter* self_, vpr::ObjectWriter* p0)
   {
      self_->gadget::Digital::writeObject(p0);
   }


   // Wrapper for virtual method gadget::Digital::readObject()
   SHARPPY_API void gadget_Digital_readObject__vpr_ObjectReader1(gadget_Digital_Adapter* self_, vpr::ObjectReader* p0)
   {
      self_->gadget::Digital::readObject(p0);
   }


} // extern "C" for gadget::Digital


