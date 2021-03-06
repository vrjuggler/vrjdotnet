// VRJ.NET is (C) Copyright 2004-2007 by Patrick Hartling
// Distributed under the GNU Lesser General Public License 2.1.  (See
// accompanying file COPYING.txt or http://www.gnu.org/copyleft/lesser.txt)

// Generated from Revision: 1.64 of RCSfile: class_cxx.tmpl,v



#include "sharppy.h"
#include <gadget/Type/Position.h>
#include <gadget/Type/Proxy.h>
#include <gadget_TypedProxy_gadget__Position_Adapter.h>

extern "C"
{
   // Constructor wrapper.
   SHARPPY_API gadget_TypedProxy_gadget__Position_Adapter* gadget_TypedProxy_gadget_Position__TypedProxy__0(gadget_TypedProxy_gadget__Position_Adapter::refresh_callback_t cb0, gadget_TypedProxy_gadget__Position_Adapter::getDeviceName_callback_t cb1, gadget_TypedProxy_gadget__Position_Adapter::config_callback_jccl_ConfigElementPtr_t cb2, gadget_TypedProxy_gadget__Position_Adapter::updateData_callback_t cb3, gadget_TypedProxy_gadget__Position_Adapter::getProxiedInputDevice_callback_t cb4, gadget_TypedProxy_gadget__Position_Adapter::isStupified_callback_t cb5, gadget_TypedProxy_gadget__Position_Adapter::getTimeStamp_callback_t cb6)
   {
      gadget_TypedProxy_gadget__Position_Adapter* obj = new gadget_TypedProxy_gadget__Position_Adapter();
      obj->refresh_callback = cb0;
      obj->getDeviceName_callback = cb1;
      obj->config_callback_jccl_ConfigElementPtr = cb2;
      obj->updateData_callback = cb3;
      obj->getProxiedInputDevice_callback = cb4;
      obj->isStupified_callback = cb5;
      obj->getTimeStamp_callback = cb6;
      return obj;
   }

   SHARPPY_API void delete_gadget_TypedProxy_gadget__Position(gadget_TypedProxy_gadget__Position_Adapter* self_)
   {
      delete self_;
   }

   // Wrapper for virtual method gadget::TypedProxy<gadget::Position>::refresh()
   SHARPPY_API bool gadget_TypedProxy_gadget_Position__refresh__0(gadget_TypedProxy_gadget__Position_Adapter* self_)
   {
      bool result;
      result = self_->gadget::TypedProxy<gadget::Position>::refresh();
      return result;
   }


   // Wrapper for virtual method gadget::TypedProxy<gadget::Position>::getDeviceName()
   SHARPPY_API char* gadget_TypedProxy_gadget_Position__getDeviceName__0(gadget_TypedProxy_gadget__Position_Adapter* self_)
   {
      std::basic_string<char,std::char_traits<char>,std::allocator<char> > temp_result;
      char* result;
      temp_result = self_->gadget::TypedProxy<gadget::Position>::getDeviceName();
      result = strdup(temp_result.c_str());
      return result;
   }


} // extern "C" for gadget::TypedProxy<gadget::Position>


