// VRJ.NET is (C) Copyright 2004-2007 by Patrick Hartling
// Distributed under the GNU Lesser General Public License 2.1.  (See
// accompanying file COPYING.txt or http://www.gnu.org/copyleft/lesser.txt)

// Generated from Revision: 1.64 of RCSfile: class_cxx.tmpl,v



#include "sharppy.h"
#include <gadget/Type/Proxy.h>
#include <gadget_Proxy_Adapter.h>

extern "C"
{
   // Constructor wrapper.
   SHARPPY_API gadget_Proxy_Adapter* gadget_Proxy_Proxy__0(gadget_Proxy_Adapter::config_callback_jccl_ConfigElementPtr_t cb0, gadget_Proxy_Adapter::refresh_callback_t cb1, gadget_Proxy_Adapter::updateData_callback_t cb2, gadget_Proxy_Adapter::getProxiedInputDevice_callback_t cb3, gadget_Proxy_Adapter::isStupified_callback_t cb4, gadget_Proxy_Adapter::getTimeStamp_callback_t cb5)
   {
      gadget_Proxy_Adapter* obj = new gadget_Proxy_Adapter();
      obj->config_callback_jccl_ConfigElementPtr = cb0;
      obj->refresh_callback = cb1;
      obj->updateData_callback = cb2;
      obj->getProxiedInputDevice_callback = cb3;
      obj->isStupified_callback = cb4;
      obj->getTimeStamp_callback = cb5;
      return obj;
   }

   SHARPPY_API void delete_gadget_Proxy(gadget_Proxy_Adapter* self_)
   {
      delete self_;
   }

   // Wrapper for non-virtual method gadget::Proxy::getName()
   SHARPPY_API char* gadget_Proxy_getName__0(gadget_Proxy_Adapter* self_)
   {
      std::string temp_result;
      char* result;
      temp_result = self_->getName();
      result = strdup(temp_result.c_str());
      return result;
   }


   // Wrapper for non-virtual method gadget::Proxy::setName()
   SHARPPY_API void gadget_Proxy_setName__std_string1(gadget_Proxy_Adapter* self_, char* p0)
   {
      self_->setName(p0);
   }


   // Wrapper for non-virtual method gadget::Proxy::stupefy()
   SHARPPY_API void gadget_Proxy_stupefy__bool0(gadget_Proxy_Adapter* self_)
   {
      self_->stupefy();
   }

   // Wrapper for non-virtual method gadget::Proxy::stupefy()
   SHARPPY_API void gadget_Proxy_stupefy__bool1(gadget_Proxy_Adapter* self_, bool p0)
   {
      self_->stupefy(p0);
   }


   // Wrapper for virtual method gadget::Proxy::config()
   SHARPPY_API bool gadget_Proxy_config__jccl_ConfigElementPtr1(gadget_Proxy_Adapter* self_, jccl::ConfigElementPtr* p0)
   {
      bool result;
      result = self_->gadget::Proxy::config(*p0);
      return result;
   }


   // Wrapper for virtual method gadget::Proxy::refresh()
   SHARPPY_API bool gadget_Proxy_refresh__0(gadget_Proxy_Adapter* self_)
   {
      bool result;
      result = self_->refresh();
      return result;
   }


   // Wrapper for virtual method gadget::Proxy::updateData()
   SHARPPY_API void gadget_Proxy_updateData__0(gadget_Proxy_Adapter* self_)
   {
      self_->gadget::Proxy::updateData();
   }


   // Wrapper for virtual method gadget::Proxy::getProxiedInputDevice()
   SHARPPY_API gadget::Input* gadget_Proxy_getProxiedInputDevice__0(gadget_Proxy_Adapter* self_)
   {
      gadget::Input* result;
      result = self_->getProxiedInputDevice();
      return result;
   }


   // Wrapper for virtual method gadget::Proxy::isStupefied()
   SHARPPY_API bool gadget_Proxy_isStupefied__0(gadget_Proxy_Adapter* self_)
   {
      bool result;
      result = self_->gadget::Proxy::isStupefied();
      return result;
   }


   // Wrapper for virtual method gadget::Proxy::getTimeStamp()
   SHARPPY_API vpr::Interval* gadget_Proxy_getTimeStamp__0(gadget_Proxy_Adapter* self_)
   {
      vpr::Interval* result;
      result = new vpr::Interval(self_->getTimeStamp());
      return result;
   }


   // Wrapper for static method gadget::Proxy::getElementType()
   SHARPPY_API char* gadget_Proxy_getElementType__0()
   {
      std::string temp_result;
      char* result;
      temp_result = gadget::Proxy::getElementType();
      result = strdup(temp_result.c_str());
      return result;
   }


} // extern "C" for gadget::Proxy


