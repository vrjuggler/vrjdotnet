/*************** <auto-copyright.pl BEGIN do not edit this line> **************
 *
 * VRJ.NET is (C) Copyright 2004 by Patrick Hartling
 *
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Library General Public
 * License as published by the Free Software Foundation; either
 * version 2 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Library General Public License for more details.
 *
 * You should have received a copy of the GNU Library General Public
 * License along with this library; if not, write to the
 * Free Software Foundation, Inc., 59 Temple Place - Suite 330,
 * Boston, MA 02111-1307, USA.
 *
 * -----------------------------------------------------------------
 * File:          $RCSfile$
 * Date modified: $Date$
 * Version:       $Revision$
 * -----------------------------------------------------------------
 *
 *************** <auto-copyright.pl END do not edit this line> ***************/

// Generated from Revision: 1.58 of RCSfile: class_cxx.tmpl,v



#include "sharppy.h"
#include <gmtl/Matrix.h>
#include <gmtl/VecBase.h>
#include <gmtl/Vec.h>
#include <gmtl/Quat.h>
#include <gmtl/Point.h>
#include <gmtl/EulerAngle.h>
#include <gmtl/AxisAngle.h>
#include <gmtl/Sphere.h>
#include <gmtl/AABox.h>
#include <gmtl/Ray.h>

extern "C"
{
   // Constructor wrapper.
   SHARPPY_API gmtl::Rayd* gmtl_Ray_double__Ray__()
   {
      gmtl::Rayd* obj = new gmtl::Rayd();
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API gmtl::Rayd* gmtl_Ray_double__Ray__gmtl_Point_double_3_gmtl_Vec3d(const gmtl::Point<double,3>* p0, const gmtl::Vec3d* p1)
   {
      const gmtl::Point<double,3>& marshal_p0 = *p0; // Pre-call marshaling for p0
      const gmtl::Vec3d& marshal_p1 = *p1; // Pre-call marshaling for p1
      gmtl::Rayd* obj = new gmtl::Rayd(marshal_p0, marshal_p1);
      ; // Post-call marshaling for p0
      ; // Post-call marshaling for p1
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API gmtl::Rayd* gmtl_Ray_double__Ray__gmtl_Rayd(const gmtl::Rayd* p0)
   {
      const gmtl::Rayd& marshal_p0 = *p0; // Pre-call marshaling for p0
      gmtl::Rayd* obj = new gmtl::Rayd(marshal_p0);
      ; // Post-call marshaling for p0
      return obj;
   }

   SHARPPY_API void delete_gmtl_Rayd(gmtl::Rayd* self_)
   {
      delete self_;
   }

   // Wrapper for non-virtual method gmtl::Ray<double>::getOrigin()
   SHARPPY_API const gmtl::Point<double,3>* gmtl_Ray_double__getOrigin__(gmtl::Rayd* self_)
   {
      const gmtl::Point<double,3>* result;
      result = new const gmtl::Point<double,3>(self_->getOrigin());

      return result;
   }

   // Wrapper for non-virtual method gmtl::Ray<double>::setOrigin()
   SHARPPY_API void gmtl_Ray_double__setOrigin__gmtl_Point_double_3(gmtl::Rayd* self_, const gmtl::Point<double,3>* p0)
   {
      const gmtl::Point<double,3>& marshal_p0 = *p0; // Pre-call marshaling for p0
      self_->setOrigin(marshal_p0);
      ; // Post-call marshaling for p0
   }

   // Wrapper for non-virtual method gmtl::Ray<double>::getDir()
   SHARPPY_API const gmtl::Vec3d* gmtl_Ray_double__getDir__(gmtl::Rayd* self_)
   {
      const gmtl::Vec3d* result;
      result = new const gmtl::Vec3d(self_->getDir());

      return result;
   }

   // Wrapper for non-virtual method gmtl::Ray<double>::setDir()
   SHARPPY_API void gmtl_Ray_double__setDir__gmtl_Vec3d(gmtl::Rayd* self_, const gmtl::Vec3d* p0)
   {
      const gmtl::Vec3d& marshal_p0 = *p0; // Pre-call marshaling for p0
      self_->setDir(marshal_p0);
      ; // Post-call marshaling for p0
   }






} // extern "C" for gmtl::Rayd

