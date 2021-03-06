// VRJ.NET is (C) Copyright 2004-2007 by Patrick Hartling
// Distributed under the GNU Lesser General Public License 2.1.  (See
// accompanying file COPYING.txt or http://www.gnu.org/copyleft/lesser.txt)

// Generated from Revision: 1.18 of RCSfile: class_cxx_adapter.tmpl,v


#ifndef __GADGET_ANALOG_ADAPTER__
#define __GADGET_ANALOG_ADAPTER__

#include "sharppy.h"
#include <gadget/Type/Analog.h>

class SHARPPY_API gadget_Analog_Adapter : public gadget::Analog
{
public:
   gadget_Analog_Adapter()
      : gadget::Analog()
   {;}

   virtual ~gadget_Analog_Adapter()
   {;}

   typedef void (*writeObject_callback_vpr_ObjectWriter_t)(vpr::ObjectWriter*);
   writeObject_callback_vpr_ObjectWriter_t writeObject_callback_vpr_ObjectWriter;

   /// Override for virtual function gadget::Analog::writeObject.
   virtual void writeObject(vpr::ObjectWriter* p0)
   {
      writeObject_callback_vpr_ObjectWriter(p0);
   }

   typedef void (*readObject_callback_vpr_ObjectReader_t)(vpr::ObjectReader*);
   readObject_callback_vpr_ObjectReader_t readObject_callback_vpr_ObjectReader;

   /// Override for virtual function gadget::Analog::readObject.
   virtual void readObject(vpr::ObjectReader* p0)
   {
      readObject_callback_vpr_ObjectReader(p0);
   }

   typedef bool (*config_callback_jccl_ConfigElementPtr_t)(jccl::ConfigElementPtr*);
   config_callback_jccl_ConfigElementPtr_t config_callback_jccl_ConfigElementPtr;

   /// Override for virtual function gadget::Analog::config.
   virtual bool config(jccl::ConfigElementPtr p0)
   {
      jccl::ConfigElementPtr* p_p0 = new jccl::ConfigElementPtr(p0);
      bool result = config_callback_jccl_ConfigElementPtr(p_p0);
      return result;
   }

   /// Public wrapper for protected non-virtual function gadget::Analog::normalizeMinToMax.
   void normalizeMinToMax(const float& p0, float& p1)
   {
      gadget::Analog::normalizeMinToMax(p0, p1);
   }

   /// Public wrapper for protected non-virtual function gadget::Analog::getMin.
   float getMin()
   {
      float result = gadget::Analog::getMin();
      return result;
   }

   /// Public wrapper for protected non-virtual function gadget::Analog::getMax.
   float getMax()
   {
      float result = gadget::Analog::getMax();
      return result;
   }

   /// Public wrapper for protected non-virtual function gadget::Analog::setMin.
   void setMin(float p0)
   {
      gadget::Analog::setMin(p0);
   }

   /// Public wrapper for protected non-virtual function gadget::Analog::setMax.
   void setMax(float p0)
   {
      gadget::Analog::setMax(p0);
   }

}; // class gadget_Analog_Adapter




#endif
