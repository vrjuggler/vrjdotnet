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
   SHARPPY_API gmtl::Coord4fZXY* gmtl_Coord_gmtl_Vec_float_4__gmtl_EulerAngle_float_gmtl_ZXY____Coord__0()
   {
      gmtl::Coord4fZXY* obj = new gmtl::Coord4fZXY();
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API gmtl::Coord4fZXY* gmtl_Coord_gmtl_Vec_float_4__gmtl_EulerAngle_float_gmtl_ZXY____Coord__gmtl_Coord4fZXY1(const gmtl::Coord4fZXY* p0)
   {
      const gmtl::Coord4fZXY& marshal_p0 = *p0;
      gmtl::Coord4fZXY* obj = new gmtl::Coord4fZXY(marshal_p0);
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API gmtl::Coord4fZXY* gmtl_Coord_gmtl_Vec_float_4__gmtl_EulerAngle_float_gmtl_ZXY____Coord__gmtl_Vec4f_gmtl_EulerAngleZXYf2(const gmtl::Vec4f* p0, const gmtl::EulerAngleZXYf* p1)
   {
      const gmtl::Vec4f& marshal_p0 = *p0;
      const gmtl::EulerAngleZXYf& marshal_p1 = *p1;
      gmtl::Coord4fZXY* obj = new gmtl::Coord4fZXY(marshal_p0, marshal_p1);
      return obj;
   }

/*
   // Constructor wrapper.
   SHARPPY_API gmtl::Coord4fZXY* gmtl_Coord_gmtl_Vec_float_4__gmtl_EulerAngle_float_gmtl_ZXY____Coord__float_float_float_float_float_float6(float p0, float p1, float p2, float p3, float p4, float p5)
   {
      gmtl::Coord4fZXY* obj = new gmtl::Coord4fZXY(p0, p1, p2, p3, p4, p5);
      return obj;
   }
*/

   // Constructor wrapper.
   SHARPPY_API gmtl::Coord4fZXY* gmtl_Coord_gmtl_Vec_float_4__gmtl_EulerAngle_float_gmtl_ZXY____Coord__float_float_float_float_float_float_float7(float p0, float p1, float p2, float p3, float p4, float p5, float p6)
   {
      gmtl::Coord4fZXY* obj = new gmtl::Coord4fZXY(p0, p1, p2, p3, p4, p5, p6);
      return obj;
   }

/*
   // Constructor wrapper.
   SHARPPY_API gmtl::Coord4fZXY* gmtl_Coord_gmtl_Vec_float_4__gmtl_EulerAngle_float_gmtl_ZXY____Coord__float_float_float_float_float_float_float_float8(float p0, float p1, float p2, float p3, float p4, float p5, float p6, float p7)
   {
      gmtl::Coord4fZXY* obj = new gmtl::Coord4fZXY(p0, p1, p2, p3, p4, p5, p6, p7);
      return obj;
   }
*/

   SHARPPY_API void delete_gmtl_Coord4fZXY(gmtl::Coord4fZXY* self_)
   {
      delete self_;
   }

   // Wrapper for non-virtual method gmtl::Coord<gmtl::Vec<float,4>,gmtl::EulerAngle<float,gmtl::ZXY> >::getPos()
   SHARPPY_API gmtl::Vec4f* gmtl_Coord_gmtl_Vec_float_4__gmtl_EulerAngle_float_gmtl_ZXY____getPos__0(gmtl::Coord4fZXY* self_)
   {
      gmtl::Vec4f* result;
      result = new gmtl::Vec4f(self_->getPos());
      return result;
   }


   // Wrapper for non-virtual method gmtl::Coord<gmtl::Vec<float,4>,gmtl::EulerAngle<float,gmtl::ZXY> >::getRot()
   SHARPPY_API gmtl::EulerAngleZXYf* gmtl_Coord_gmtl_Vec_float_4__gmtl_EulerAngle_float_gmtl_ZXY____getRot__0(gmtl::Coord4fZXY* self_)
   {
      gmtl::EulerAngleZXYf* result;
      result = new gmtl::EulerAngleZXYf(self_->getRot());
      return result;
   }


   // Wrapper for non-virtual method gmtl::Coord<gmtl::Vec<float,4>,gmtl::EulerAngle<float,gmtl::ZXY> >::pos()
   SHARPPY_API gmtl::Vec4f* gmtl_Coord_gmtl_Vec_float_4__gmtl_EulerAngle_float_gmtl_ZXY____pos__0(gmtl::Coord4fZXY* self_)
   {
      gmtl::Vec4f* result;
      result = new gmtl::Vec4f(self_->pos());
      return result;
   }


   // Wrapper for non-virtual method gmtl::Coord<gmtl::Vec<float,4>,gmtl::EulerAngle<float,gmtl::ZXY> >::rot()
   SHARPPY_API gmtl::EulerAngleZXYf* gmtl_Coord_gmtl_Vec_float_4__gmtl_EulerAngle_float_gmtl_ZXY____rot__0(gmtl::Coord4fZXY* self_)
   {
      gmtl::EulerAngleZXYf* result;
      result = new gmtl::EulerAngleZXYf(self_->rot());
      return result;
   }


} // extern "C" for gmtl::Coord4fZXY


