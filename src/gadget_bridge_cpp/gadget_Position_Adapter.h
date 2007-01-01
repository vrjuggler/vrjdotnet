// VRJ.NET is (C) Copyright 2004-2007 by Patrick Hartling
// Distributed under the GNU Lesser General Public License 2.1.  (See
// accompanying file COPYING.txt or http://www.gnu.org/copyleft/lesser.txt)

// Generated from Revision: 1.18 of RCSfile: class_cxx_adapter.tmpl,v


#ifndef __GADGET_POSITION_ADAPTER__
#define __GADGET_POSITION_ADAPTER__

#include "sharppy.h"
#include <gadget/Type/Position.h>

class SHARPPY_API gadget_Position_Adapter : public gadget::Position
{
public:
   gadget_Position_Adapter()
      : gadget::Position()
   {;}

   virtual ~gadget_Position_Adapter()
   {;}

   typedef bool (*config_callback_jccl_ConfigElementPtr_t)(jccl::ConfigElementPtr*);
   config_callback_jccl_ConfigElementPtr_t config_callback_jccl_ConfigElementPtr;

   /// Override for virtual function gadget::Position::config.
   virtual bool config(jccl::ConfigElementPtr p0)
   {
      jccl::ConfigElementPtr* p_p0 = new jccl::ConfigElementPtr(p0);
      bool result = config_callback_jccl_ConfigElementPtr(p_p0);
      return result;
   }

   typedef void (*writeObject_callback_vpr_ObjectWriter_t)(vpr::ObjectWriter*);
   writeObject_callback_vpr_ObjectWriter_t writeObject_callback_vpr_ObjectWriter;

   /// Override for virtual function gadget::Position::writeObject.
   virtual void writeObject(vpr::ObjectWriter* p0)
   {
      writeObject_callback_vpr_ObjectWriter(p0);
   }

   typedef void (*readObject_callback_vpr_ObjectReader_t)(vpr::ObjectReader*);
   readObject_callback_vpr_ObjectReader_t readObject_callback_vpr_ObjectReader;

   /// Override for virtual function gadget::Position::readObject.
   virtual void readObject(vpr::ObjectReader* p0)
   {
      readObject_callback_vpr_ObjectReader(p0);
   }

}; // class gadget_Position_Adapter




#endif
