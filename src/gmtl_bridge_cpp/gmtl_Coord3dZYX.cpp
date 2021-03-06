// VRJ.NET is (C) Copyright 2004-2007 by Patrick Hartling
// Distributed under the GNU Lesser General Public License 2.1.  (See
// accompanying file COPYING.txt or http://www.gnu.org/copyleft/lesser.txt)

// Generated from Revision: 1.63 of RCSfile: class_cxx.tmpl,v



#include "sharppy.h"
#include <gmtl/Vec.h>
#include <gmtl/EulerAngle.h>
#include <gmtl/Coord.h>

extern "C"
{
   // Constructor wrapper.
   SHARPPY_API gmtl::Coord3dZYX* gmtl_Coord_gmtl_Vec_double_3__gmtl_EulerAngle_double_gmtl_ZYX____Coord__0()
   {
      gmtl::Coord3dZYX* obj = new gmtl::Coord3dZYX();
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API gmtl::Coord3dZYX* gmtl_Coord_gmtl_Vec_double_3__gmtl_EulerAngle_double_gmtl_ZYX____Coord__gmtl_Coord3dZYX1(const gmtl::Coord3dZYX* p0)
   {
      const gmtl::Coord3dZYX& marshal_p0 = *p0;
      gmtl::Coord3dZYX* obj = new gmtl::Coord3dZYX(marshal_p0);
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API gmtl::Coord3dZYX* gmtl_Coord_gmtl_Vec_double_3__gmtl_EulerAngle_double_gmtl_ZYX____Coord__gmtl_Vec3d_gmtl_EulerAngleZYXd2(const gmtl::Vec3d* p0, const gmtl::EulerAngleZYXd* p1)
   {
      const gmtl::Vec3d& marshal_p0 = *p0;
      const gmtl::EulerAngleZYXd& marshal_p1 = *p1;
      gmtl::Coord3dZYX* obj = new gmtl::Coord3dZYX(marshal_p0, marshal_p1);
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API gmtl::Coord3dZYX* gmtl_Coord_gmtl_Vec_double_3__gmtl_EulerAngle_double_gmtl_ZYX____Coord__double_double_double_double_double_double6(double p0, double p1, double p2, double p3, double p4, double p5)
   {
      gmtl::Coord3dZYX* obj = new gmtl::Coord3dZYX(p0, p1, p2, p3, p4, p5);
      return obj;
   }

/*
   // Constructor wrapper.
   SHARPPY_API gmtl::Coord3dZYX* gmtl_Coord_gmtl_Vec_double_3__gmtl_EulerAngle_double_gmtl_ZYX____Coord__double_double_double_double_double_double_double7(double p0, double p1, double p2, double p3, double p4, double p5, double p6)
   {
      gmtl::Coord3dZYX* obj = new gmtl::Coord3dZYX(p0, p1, p2, p3, p4, p5, p6);
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API gmtl::Coord3dZYX* gmtl_Coord_gmtl_Vec_double_3__gmtl_EulerAngle_double_gmtl_ZYX____Coord__double_double_double_double_double_double_double_double8(double p0, double p1, double p2, double p3, double p4, double p5, double p6, double p7)
   {
      gmtl::Coord3dZYX* obj = new gmtl::Coord3dZYX(p0, p1, p2, p3, p4, p5, p6, p7);
      return obj;
   }
*/

   SHARPPY_API void delete_gmtl_Coord3dZYX(gmtl::Coord3dZYX* self_)
   {
      delete self_;
   }

   // Wrapper for non-virtual method gmtl::Coord<gmtl::Vec<double,3>,gmtl::EulerAngle<double,gmtl::ZYX> >::getPos()
   SHARPPY_API gmtl::Vec3d* gmtl_Coord_gmtl_Vec_double_3__gmtl_EulerAngle_double_gmtl_ZYX____getPos__0(gmtl::Coord3dZYX* self_)
   {
      gmtl::Vec3d* result;
      result = new gmtl::Vec3d(self_->getPos());
      return result;
   }


   // Wrapper for non-virtual method gmtl::Coord<gmtl::Vec<double,3>,gmtl::EulerAngle<double,gmtl::ZYX> >::getRot()
   SHARPPY_API gmtl::EulerAngleZYXd* gmtl_Coord_gmtl_Vec_double_3__gmtl_EulerAngle_double_gmtl_ZYX____getRot__0(gmtl::Coord3dZYX* self_)
   {
      gmtl::EulerAngleZYXd* result;
      result = new gmtl::EulerAngleZYXd(self_->getRot());
      return result;
   }


   // Wrapper for non-virtual method gmtl::Coord<gmtl::Vec<double,3>,gmtl::EulerAngle<double,gmtl::ZYX> >::pos()
   SHARPPY_API gmtl::Vec3d* gmtl_Coord_gmtl_Vec_double_3__gmtl_EulerAngle_double_gmtl_ZYX____pos__0(gmtl::Coord3dZYX* self_)
   {
      gmtl::Vec3d* result;
      result = new gmtl::Vec3d(self_->pos());
      return result;
   }


   // Wrapper for non-virtual method gmtl::Coord<gmtl::Vec<double,3>,gmtl::EulerAngle<double,gmtl::ZYX> >::rot()
   SHARPPY_API gmtl::EulerAngleZYXd* gmtl_Coord_gmtl_Vec_double_3__gmtl_EulerAngle_double_gmtl_ZYX____rot__0(gmtl::Coord3dZYX* self_)
   {
      gmtl::EulerAngleZYXd* result;
      result = new gmtl::EulerAngleZYXd(self_->rot());
      return result;
   }


} // extern "C" for gmtl::Coord3dZYX


