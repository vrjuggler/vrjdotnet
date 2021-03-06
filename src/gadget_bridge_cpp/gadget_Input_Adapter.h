// VRJ.NET is (C) Copyright 2004-2007 by Patrick Hartling
// Distributed under the GNU Lesser General Public License 2.1.  (See
// accompanying file COPYING.txt or http://www.gnu.org/copyleft/lesser.txt)

// Generated from Revision: 1.19 of RCSfile: class_cxx_adapter.tmpl,v


#ifndef __GADGET_INPUT_ADAPTER__
#define __GADGET_INPUT_ADAPTER__

#include "sharppy.h"
#include <gadget/Type/Input.h>

class SHARPPY_API gadget_Input_Adapter : public gadget::Input
{
public:
   gadget_Input_Adapter()
      : gadget::Input()
   {;}

   virtual ~gadget_Input_Adapter()
   {;}

   typedef bool (*config_callback_jccl_ConfigElementPtr_t)(jccl::ConfigElementPtr*);
   config_callback_jccl_ConfigElementPtr_t config_callback_jccl_ConfigElementPtr;

   /// Override for virtual function gadget::Input::config.
   virtual bool config(jccl::ConfigElementPtr p0)
   {
      jccl::ConfigElementPtr* p_p0 = new jccl::ConfigElementPtr(p0);
      bool result = config_callback_jccl_ConfigElementPtr(p_p0);
      return result;
   }

   typedef bool (*sample_callback_t)();
   sample_callback_t sample_callback;

   /// Override for virtual function gadget::Input::sample.
   virtual bool sample()
   {
      bool result = sample_callback();
      return result;
   }

   typedef bool (*startSampling_callback_t)();
   startSampling_callback_t startSampling_callback;

   /// Override for virtual function gadget::Input::startSampling.
   virtual bool startSampling()
   {
      bool result = startSampling_callback();
      return result;
   }

   typedef bool (*stopSampling_callback_t)();
   stopSampling_callback_t stopSampling_callback;

   /// Override for virtual function gadget::Input::stopSampling.
   virtual bool stopSampling()
   {
      bool result = stopSampling_callback();
      return result;
   }

   typedef void (*updateData_callback_t)();
   updateData_callback_t updateData_callback;

   /// Override for virtual function gadget::Input::updateData.
   virtual void updateData()
   {
      updateData_callback();
   }


   typedef void (*writeObject_callback_vpr_ObjectWriter_t)(vpr::ObjectWriter*);
   writeObject_callback_vpr_ObjectWriter_t writeObject_callback_vpr_ObjectWriter;

   /// Override for virtual function gadget::Input::writeObject.
   virtual void writeObject(vpr::ObjectWriter* p0)
   {
      writeObject_callback_vpr_ObjectWriter(p0);
   }

   typedef void (*readObject_callback_vpr_ObjectReader_t)(vpr::ObjectReader*);
   readObject_callback_vpr_ObjectReader_t readObject_callback_vpr_ObjectReader;

   /// Override for virtual function gadget::Input::readObject.
   virtual void readObject(vpr::ObjectReader* p0)
   {
      readObject_callback_vpr_ObjectReader(p0);
   }

   typedef void (*destroy_callback_t)();
   destroy_callback_t destroy_callback;

   /// Override for virtual function gadget::Input::destroy.
   virtual void destroy()
   {
      destroy_callback();
   }

}; // class gadget_Input_Adapter




#endif
