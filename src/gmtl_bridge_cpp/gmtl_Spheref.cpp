// VRJ.NET is (C) Copyright 2004-2007 by Patrick Hartling
// Distributed under the GNU Lesser General Public License 2.1.  (See
// accompanying file COPYING.txt or http://www.gnu.org/copyleft/lesser.txt)

// Generated from Revision: 1.63 of RCSfile: class_cxx.tmpl,v



#include "sharppy.h"
#include <gmtl/Sphere.h>

extern "C"
{
   // Constructor wrapper.
   SHARPPY_API gmtl::Spheref* gmtl_Sphere_float__Sphere__0()
   {
      gmtl::Spheref* obj = new gmtl::Spheref();
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API gmtl::Spheref* gmtl_Sphere_float__Sphere__gmtl_Point3f_float2(const gmtl::Point3f* p0, const float p1)
   {
      const gmtl::Point3f& marshal_p0 = *p0;
      gmtl::Spheref* obj = new gmtl::Spheref(marshal_p0, p1);
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API gmtl::Spheref* gmtl_Sphere_float__Sphere__gmtl_Spheref1(const gmtl::Spheref* p0)
   {
      const gmtl::Spheref& marshal_p0 = *p0;
      gmtl::Spheref* obj = new gmtl::Spheref(marshal_p0);
      return obj;
   }

   SHARPPY_API void delete_gmtl_Spheref(gmtl::Spheref* self_)
   {
      delete self_;
   }

   // Wrapper for non-virtual method gmtl::Sphere<float>::getCenter()
   SHARPPY_API gmtl::Point3f* gmtl_Sphere_float__getCenter__0(gmtl::Spheref* self_)
   {
      gmtl::Point3f* result;
      result = new gmtl::Point3f(self_->getCenter());
      return result;
   }


   // Wrapper for non-virtual method gmtl::Sphere<float>::getRadius()
   SHARPPY_API  float gmtl_Sphere_float__getRadius__0(gmtl::Spheref* self_)
   {
       float result;
      result = self_->getRadius();
      return result;
   }


   // Wrapper for non-virtual method gmtl::Sphere<float>::setCenter()
   SHARPPY_API void gmtl_Sphere_float__setCenter__gmtl_Point3f1(gmtl::Spheref* self_, const gmtl::Point3f* p0)
   {
      const gmtl::Point3f& marshal_p0 = *p0;
      self_->setCenter(marshal_p0);
   }


   // Wrapper for non-virtual method gmtl::Sphere<float>::setRadius()
   SHARPPY_API void gmtl_Sphere_float__setRadius__float1(gmtl::Spheref* self_, const float p0)
   {
      self_->setRadius(p0);
   }


} // extern "C" for gmtl::Spheref


