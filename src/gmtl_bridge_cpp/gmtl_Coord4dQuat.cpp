// VRJ.NET is (C) Copyright 2004-2007 by Patrick Hartling
// Distributed under the GNU Lesser General Public License 2.1.  (See
// accompanying file COPYING.txt or http://www.gnu.org/copyleft/lesser.txt)

// Generated from Revision: 1.63 of RCSfile: class_cxx.tmpl,v



#include "sharppy.h"
#include <gmtl/Vec.h>
#include <gmtl/Quat.h>
#include <gmtl/Coord.h>

extern "C"
{
   // Constructor wrapper.
   SHARPPY_API gmtl::Coord4dQuat* gmtl_Coord_gmtl_Vec_double_4__gmtl_Quat_double____Coord__0()
   {
      gmtl::Coord4dQuat* obj = new gmtl::Coord4dQuat();
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API gmtl::Coord4dQuat* gmtl_Coord_gmtl_Vec_double_4__gmtl_Quat_double____Coord__gmtl_Coord4dQuat1(const gmtl::Coord4dQuat* p0)
   {
      const gmtl::Coord4dQuat& marshal_p0 = *p0;
      gmtl::Coord4dQuat* obj = new gmtl::Coord4dQuat(marshal_p0);
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API gmtl::Coord4dQuat* gmtl_Coord_gmtl_Vec_double_4__gmtl_Quat_double____Coord__gmtl_Vec4d_gmtl_Quatd2(const gmtl::Vec4d* p0, const gmtl::Quatd* p1)
   {
      const gmtl::Vec4d& marshal_p0 = *p0;
      const gmtl::Quatd& marshal_p1 = *p1;
      gmtl::Coord4dQuat* obj = new gmtl::Coord4dQuat(marshal_p0, marshal_p1);
      return obj;
   }

/*
   // Constructor wrapper.
   SHARPPY_API gmtl::Coord4dQuat* gmtl_Coord_gmtl_Vec_double_4__gmtl_Quat_double____Coord__double_double_double_double_double_double6(double p0, double p1, double p2, double p3, double p4, double p5)
   {
      gmtl::Coord4dQuat* obj = new gmtl::Coord4dQuat(p0, p1, p2, p3, p4, p5);
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API gmtl::Coord4dQuat* gmtl_Coord_gmtl_Vec_double_4__gmtl_Quat_double____Coord__double_double_double_double_double_double_double7(double p0, double p1, double p2, double p3, double p4, double p5, double p6)
   {
      gmtl::Coord4dQuat* obj = new gmtl::Coord4dQuat(p0, p1, p2, p3, p4, p5, p6);
      return obj;
   }
*/

   // Constructor wrapper.
   SHARPPY_API gmtl::Coord4dQuat* gmtl_Coord_gmtl_Vec_double_4__gmtl_Quat_double____Coord__double_double_double_double_double_double_double_double8(double p0, double p1, double p2, double p3, double p4, double p5, double p6, double p7)
   {
      gmtl::Coord4dQuat* obj = new gmtl::Coord4dQuat(p0, p1, p2, p3, p4, p5, p6, p7);
      return obj;
   }

   SHARPPY_API void delete_gmtl_Coord4dQuat(gmtl::Coord4dQuat* self_)
   {
      delete self_;
   }

   // Wrapper for non-virtual method gmtl::Coord<gmtl::Vec<double,4>,gmtl::Quat<double> >::getPos()
   SHARPPY_API gmtl::Vec4d* gmtl_Coord_gmtl_Vec_double_4__gmtl_Quat_double____getPos__0(gmtl::Coord4dQuat* self_)
   {
      gmtl::Vec4d* result;
      result = new gmtl::Vec4d(self_->getPos());
      return result;
   }


   // Wrapper for non-virtual method gmtl::Coord<gmtl::Vec<double,4>,gmtl::Quat<double> >::getRot()
   SHARPPY_API gmtl::Quatd* gmtl_Coord_gmtl_Vec_double_4__gmtl_Quat_double____getRot__0(gmtl::Coord4dQuat* self_)
   {
      gmtl::Quatd* result;
      result = new gmtl::Quatd(self_->getRot());
      return result;
   }


   // Wrapper for non-virtual method gmtl::Coord<gmtl::Vec<double,4>,gmtl::Quat<double> >::pos()
   SHARPPY_API gmtl::Vec4d* gmtl_Coord_gmtl_Vec_double_4__gmtl_Quat_double____pos__0(gmtl::Coord4dQuat* self_)
   {
      gmtl::Vec4d* result;
      result = new gmtl::Vec4d(self_->pos());
      return result;
   }


   // Wrapper for non-virtual method gmtl::Coord<gmtl::Vec<double,4>,gmtl::Quat<double> >::rot()
   SHARPPY_API gmtl::Quatd* gmtl_Coord_gmtl_Vec_double_4__gmtl_Quat_double____rot__0(gmtl::Coord4dQuat* self_)
   {
      gmtl::Quatd* result;
      result = new gmtl::Quatd(self_->rot());
      return result;
   }


} // extern "C" for gmtl::Coord4dQuat


