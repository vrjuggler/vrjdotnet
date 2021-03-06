// VRJ.NET is (C) Copyright 2004-2007 by Patrick Hartling
// Distributed under the GNU Lesser General Public License 2.1.  (See
// accompanying file COPYING.txt or http://www.gnu.org/copyleft/lesser.txt)

// Generated from Revision: 1.15 of RCSfile: class_cxx_adapter.tmpl,v


#ifndef __VPR_WRITEABLEOBJECT_ADAPTER__
#define __VPR_WRITEABLEOBJECT_ADAPTER__

#include "sharppy.h"
#include <vpr/IO/SerializableObject.h>

class SHARPPY_API vpr_WriteableObject_Adapter : public vpr::WriteableObject
{
public:
   virtual ~vpr_WriteableObject_Adapter()
   {;}

   typedef void (*writeObject_callback_vpr_ObjectWriter_t)(vpr::ObjectWriter*);
   writeObject_callback_vpr_ObjectWriter_t writeObject_callback_vpr_ObjectWriter;

   /// Override for virtual function vpr::WriteableObject::writeObject.
   virtual void writeObject(vpr::ObjectWriter* p0)
   {
      writeObject_callback_vpr_ObjectWriter(p0);
   }

}; // class vpr_WriteableObject_Adapter




#endif
