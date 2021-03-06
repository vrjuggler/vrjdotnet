// VRJ.NET is (C) Copyright 2004-2007 by Patrick Hartling
// Distributed under the GNU Lesser General Public License 2.1.  (See
// accompanying file COPYING.txt or http://www.gnu.org/copyleft/lesser.txt)

// Generated from Revision: 1.63 of RCSfile: class_cxx.tmpl,v



#include "sharppy.h"
#include <gmtl/Point.h>

extern "C"
{
   // Constructor wrapper.
   SHARPPY_API gmtl::Point3i* gmtl_Point_int_3__Point__0()
   {
      gmtl::Point3i* obj = new gmtl::Point3i();
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API gmtl::Point3i* gmtl_Point_int_3__Point__gmtl_Point3i1(const gmtl::Point3i* p0)
   {
      const gmtl::Point3i& marshal_p0 = *p0;
      gmtl::Point3i* obj = new gmtl::Point3i(marshal_p0);
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API gmtl::Point3i* gmtl_Point_int_3__Point__gmtl_VecBase_int_31(const gmtl::VecBase<int,3>* p0)
   {
      const gmtl::VecBase<int,3>& marshal_p0 = *p0;
      gmtl::Point3i* obj = new gmtl::Point3i(marshal_p0);
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API gmtl::Point3i* gmtl_Point_int_3__Point__int_int_int3(const int p0, const int p1, const int p2)
   {
      gmtl::Point3i* obj = new gmtl::Point3i(p0, p1, p2);
      return obj;
   }

   SHARPPY_API void delete_gmtl_Point3i(gmtl::Point3i* self_)
   {
      delete self_;
   }

} // extern "C" for gmtl::Point3i


