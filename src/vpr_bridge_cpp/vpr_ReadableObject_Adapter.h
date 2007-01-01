// VRJ.NET is (C) Copyright 2004 by Patrick Hartling
// Distributed under the GNU Lesser General Public License 2.1.  (See
// accompanying file COPYING.txt or http://www.gnu.org/copyleft/lesser.txt)

// Generated from Revision: 1.15 of RCSfile: class_cxx_adapter.tmpl,v


#ifndef __VPR_READABLEOBJECT_ADAPTER__
#define __VPR_READABLEOBJECT_ADAPTER__

#include "sharppy.h"
#include <vpr/IO/SerializableObject.h>

class SHARPPY_API vpr_ReadableObject_Adapter : public vpr::ReadableObject
{
public:
   virtual ~vpr_ReadableObject_Adapter()
   {;}

   typedef void (*readObject_callback_vpr_ObjectReader_t)(vpr::ObjectReader*);
   readObject_callback_vpr_ObjectReader_t readObject_callback_vpr_ObjectReader;

   /// Override for virtual function vpr::ReadableObject::readObject.
   virtual void readObject(vpr::ObjectReader* p0)
   {
      readObject_callback_vpr_ObjectReader(p0);
   }

}; // class vpr_ReadableObject_Adapter




#endif
